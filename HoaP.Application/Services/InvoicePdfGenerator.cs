using HoaP.Application.ViewModels.HotelProfile;
using HoaP.Application.ViewModels.Invoice;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace HoaP.Application.Services
{
    public class InvoicePdfGenerator
    {
        public byte[] GeneratePdf(DetailInvoiceViewModel invoice, HotelProfileViewModel? hotel)
        {
            var document = new InvoiceDocument(invoice, hotel);
            return document.GeneratePdf();
        }
    }

    public class InvoiceDocument : IDocument
    {
        private readonly DetailInvoiceViewModel _invoice;
        private readonly HotelProfileViewModel? _hotel;

        public InvoiceDocument(DetailInvoiceViewModel invoice, HotelProfileViewModel? hotel)
        {
            _invoice = invoice;
            _hotel = hotel;
        }

        public DocumentMetadata GetMetadata() => DocumentMetadata.Default;

        public void Compose(IDocumentContainer container)
        {
            container.Page(page =>
            {
                page.Size(PageSizes.A4);
                page.Margin(40);
                page.DefaultTextStyle(x => x.FontSize(10));

                page.Header().Element(ComposeHeader);
                page.Content().Element(ComposeContent);
                page.Footer().Element(ComposeFooter);
            });
        }

        private void ComposeHeader(IContainer container)
        {
            container.Column(column =>
            {
                column.Item().Row(row =>
                {
                    row.RelativeItem().Column(col =>
                    {
                        if (_hotel?.Logo != null)
                        {
                            col.Item().Width(120).Image(_hotel.Logo);
                        }
                    });

                    row.RelativeItem().AlignRight().Column(col =>
                    {
                        col.Item().Text(_invoice.IsCanceled ? "STORNO FAKTURA" : "FAKTURA - DAŇOVÝ DOKLAD")
                            .FontSize(18).Bold().FontColor(Colors.Blue.Darken2);
                        col.Item().Text($"Číslo: {_invoice.InvoiceNumber}").FontSize(12).Bold();
                    });
                });

                column.Item().PaddingTop(15).LineHorizontal(1).LineColor(Colors.Grey.Lighten1);
            });
        }

        private void ComposeContent(IContainer container)
        {
            container.PaddingTop(15).Column(column =>
            {
                // Dodavatel + Odberatel
                column.Item().Row(row =>
                {
                    row.RelativeItem().Border(1).BorderColor(Colors.Grey.Lighten1).Padding(10).Column(col =>
                    {
                        col.Item().Text("Dodavatel").FontSize(11).Bold().FontColor(Colors.Blue.Darken2);
                        col.Item().PaddingTop(5);
                        col.Item().Text(_hotel?.Name ?? "Hotel").Bold();
                        col.Item().Text(_hotel?.Address ?? "");
                        col.Item().Text($"{_hotel?.PostalCode} {_hotel?.City}");
                        col.Item().Text(_hotel?.Country ?? "");
                        col.Item().PaddingTop(5);
                        col.Item().Text($"IČO: {_hotel?.ICO ?? "neuvedeno"}").Bold();
                        if (!string.IsNullOrEmpty(_hotel?.DIC))
                            col.Item().Text($"DIČ: {_hotel.DIC}").Bold();
                        if (!string.IsNullOrEmpty(_hotel?.Phone))
                            col.Item().Text($"Tel: {_hotel.Phone}");
                        if (!string.IsNullOrEmpty(_hotel?.Email))
                            col.Item().Text($"Email: {_hotel.Email}");
                    });

                    row.ConstantItem(15);

                    row.RelativeItem().Border(1).BorderColor(Colors.Grey.Lighten1).Padding(10).Column(col =>
                    {
                        col.Item().Text("Odběratel").FontSize(11).Bold().FontColor(Colors.Blue.Darken2);
                        col.Item().PaddingTop(5);
                        col.Item().Text(_invoice.CustomerName).Bold();
                        if (!string.IsNullOrEmpty(_invoice.CustomerAddress))
                            col.Item().Text(_invoice.CustomerAddress);
                        var cityLine = $"{_invoice.CustomerPostalCode} {_invoice.CustomerCity}".Trim();
                        if (!string.IsNullOrEmpty(cityLine))
                            col.Item().Text(cityLine);
                        if (!string.IsNullOrEmpty(_invoice.CustomerCountry))
                            col.Item().Text(_invoice.CustomerCountry);
                    });
                });

                column.Item().PaddingTop(15);

                // Datumy a platebni udaje
                column.Item().Row(row =>
                {
                    row.RelativeItem().Column(col =>
                    {
                        col.Item().Text($"Datum vystavení: {_invoice.IssueDate:dd.MM.yyyy}");
                        if (_invoice.DateOfTaxableSupply.HasValue)
                            col.Item().Text($"DUZP: {_invoice.DateOfTaxableSupply:dd.MM.yyyy}");
                        col.Item().Text($"Datum splatnosti: {_invoice.DueDate:dd.MM.yyyy}").Bold();
                    });

                    row.RelativeItem().Column(col =>
                    {
                        if (!string.IsNullOrEmpty(_invoice.PaymentMethod))
                            col.Item().Text($"Forma úhrady: {_invoice.PaymentMethod}");
                        if (!string.IsNullOrEmpty(_invoice.VariableSymbol))
                            col.Item().Text($"Variabilní symbol: {_invoice.VariableSymbol}").Bold();
                        if (!string.IsNullOrEmpty(_invoice.BankAccount))
                            col.Item().Text($"Bankovní účet: {_invoice.BankAccount}");
                    });
                });

                column.Item().PaddingTop(15);

                // Polozky faktury
                var symbol = _invoice.CurrencySymbol ?? "Kč";

                column.Item().Table(table =>
                {
                    table.ColumnsDefinition(columns =>
                    {
                        columns.RelativeColumn(4);
                        columns.ConstantColumn(50);
                        columns.ConstantColumn(80);
                        columns.ConstantColumn(50);
                        columns.ConstantColumn(80);
                    });

                    table.Header(header =>
                    {
                        header.Cell().Background(Colors.Blue.Darken2).Padding(5)
                            .Text("Položka").FontColor(Colors.White).Bold();
                        header.Cell().Background(Colors.Blue.Darken2).Padding(5).AlignRight()
                            .Text("Množství").FontColor(Colors.White).Bold();
                        header.Cell().Background(Colors.Blue.Darken2).Padding(5).AlignRight()
                            .Text("Cena/ks").FontColor(Colors.White).Bold();
                        header.Cell().Background(Colors.Blue.Darken2).Padding(5).AlignRight()
                            .Text("DPH %").FontColor(Colors.White).Bold();
                        header.Cell().Background(Colors.Blue.Darken2).Padding(5).AlignRight()
                            .Text("Celkem").FontColor(Colors.White).Bold();
                    });

                    var isAlternate = false;

                    foreach (var item in _invoice.Items)
                    {
                        var bgColor = isAlternate ? Colors.Grey.Lighten4 : Colors.White;

                        table.Cell().Background(bgColor).Padding(5).Text(item.Description);
                        table.Cell().Background(bgColor).Padding(5).AlignRight().Text($"{item.Quantity}");
                        table.Cell().Background(bgColor).Padding(5).AlignRight().Text($"{item.UnitPrice:N2} {symbol}");
                        table.Cell().Background(bgColor).Padding(5).AlignRight().Text($"{item.VatRate:N0} %");
                        table.Cell().Background(bgColor).Padding(5).AlignRight().Text($"{item.Price:N2} {symbol}");

                        isAlternate = !isAlternate;
                    }
                });

                column.Item().PaddingTop(15);

                // DPH rozpad
                var vatGroups = _invoice.Items
                    .GroupBy(i => i.VatRate)
                    .Select(g => new
                    {
                        Rate = g.Key,
                        Base = g.Sum(i => i.Price / (1 + i.VatRate / 100)),
                        Vat = g.Sum(i => i.Price - i.Price / (1 + i.VatRate / 100)),
                        Total = g.Sum(i => i.Price)
                    })
                    .ToList();

                if (vatGroups.Count > 0)
                {
                    column.Item().Table(table =>
                    {
                        table.ColumnsDefinition(columns =>
                        {
                            columns.RelativeColumn();
                            columns.ConstantColumn(100);
                            columns.ConstantColumn(100);
                            columns.ConstantColumn(100);
                        });

                        table.Header(header =>
                        {
                            header.Cell().Background(Colors.Grey.Lighten2).Padding(5).Text("Sazba DPH").Bold();
                            header.Cell().Background(Colors.Grey.Lighten2).Padding(5).AlignRight().Text("Základ").Bold();
                            header.Cell().Background(Colors.Grey.Lighten2).Padding(5).AlignRight().Text("DPH").Bold();
                            header.Cell().Background(Colors.Grey.Lighten2).Padding(5).AlignRight().Text("Celkem").Bold();
                        });

                        foreach (var vg in vatGroups)
                        {
                            table.Cell().Padding(5).Text($"{vg.Rate:N0} %");
                            table.Cell().Padding(5).AlignRight().Text($"{vg.Base:N2} {symbol}");
                            table.Cell().Padding(5).AlignRight().Text($"{vg.Vat:N2} {symbol}");
                            table.Cell().Padding(5).AlignRight().Text($"{vg.Total:N2} {symbol}");
                        }
                    });
                }

                column.Item().PaddingTop(15);

                // Souhrn
                column.Item().AlignRight().Column(col =>
                {
                    var subtotal = _invoice.Items.Sum(i => i.Price);
                    col.Item().Text($"Mezisoučet: {subtotal:N2} {symbol}");

                    if (_invoice.Discount > 0)
                        col.Item().Text($"Sleva: -{_invoice.Discount:N2} {symbol}");

                    if (_invoice.Prepayment > 0)
                        col.Item().Text($"Záloha: -{_invoice.Prepayment:N2} {symbol}");

                    col.Item().PaddingTop(5).Text($"Celkem k úhradě: {_invoice.Price:N2} {symbol}")
                        .FontSize(14).Bold().FontColor(Colors.Blue.Darken2);
                });

                if (!string.IsNullOrEmpty(_invoice.Description))
                {
                    column.Item().PaddingTop(15).Text($"Poznámka: {_invoice.Description}").Italic();
                }
            });
        }

        private void ComposeFooter(IContainer container)
        {
            container.Column(col =>
            {
                col.Item().LineHorizontal(1).LineColor(Colors.Grey.Lighten1);
                col.Item().PaddingTop(5).Row(row =>
                {
                    row.RelativeItem().Text($"Vystavil: {_invoice.CreatedBy}").FontSize(8);
                    row.RelativeItem().AlignRight().Text(text =>
                    {
                        text.Span("Strana ").FontSize(8);
                        text.CurrentPageNumber().FontSize(8);
                        text.Span(" z ").FontSize(8);
                        text.TotalPages().FontSize(8);
                    });
                });
            });
        }
    }
}

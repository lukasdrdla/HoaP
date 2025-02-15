using HoaP.Application.ViewModels.Invoice;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;


public class InvoicePdfGenerator
{
    public byte[] GeneratePdf(DetailInvoiceViewModel invoice)
    {
        var document = new InvoiceDocument(invoice);
        return document.GeneratePdf();
    }
}

public class InvoiceDocument : IDocument
{
    private readonly DetailInvoiceViewModel _invoice;

    public InvoiceDocument(DetailInvoiceViewModel invoice)
    {
        _invoice = invoice;
    }

    public DocumentMetadata GetMetadata() => DocumentMetadata.Default;

    public void Compose(IDocumentContainer container)
    {
        container.Page(page =>
        {
            page.Margin(50);

            page.Content().Column(column =>
            {
                column.Item().Text($"Faktura č. {_invoice.Id}")
                    .FontSize(24).Bold().Underline().AlignCenter();
                column.Item().Text($"Datum vystavení: {_invoice.IssueDate:dd.MM.yyyy}")
                    .FontSize(12).AlignCenter();
                column.Item().Text($"Datum splatnosti: {_invoice.DueDate:dd.MM.yyyy}")
                    .FontSize(12).AlignCenter();

                column.Item().PaddingTop(10);

                column.Item().Text("========================================")
                    .FontSize(12);

                column.Item().PaddingTop(10);

                column.Item().Text($"Zákazník: {_invoice.CustomerName ?? "Neznámý zákazník"}")
                    .FontSize(14).Bold();
                column.Item().Text($"Stav: {(_invoice.IsCanceled ? "Stornováno" : (_invoice.IsPaid ? "Zaplaceno" : "Nezaplaceno"))}")
                    .FontSize(14);

                column.Item().PaddingTop(10);

                column.Item().Text($"Celková částka: {_invoice.Price:C}")
                    .FontSize(16).Bold();

                column.Item().PaddingTop(10);

                column.Item().Text("========================================")
                    .FontSize(12);

                column.Item().PaddingTop(10);

                column.Item().Text($"Sleva: {_invoice.Discount:C}")
                    .FontSize(12);
                column.Item().Text($"Předplatba: {_invoice.Prepayment:C}")
                    .FontSize(12);
            });
        });
    }
}

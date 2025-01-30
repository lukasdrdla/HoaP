using HoaP.Application.ViewModels.Invoice;
using QuestPDF.Fluent;
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
            page.Content().Column(column =>
            {
                column.Item().Text($"Faktura č. {_invoice.Id}").FontSize(20).Bold();
                column.Item().Text($"Zákazník: {_invoice.CustomerName}");
                column.Item().Text($"Datum vystavení: {_invoice.IssueDate:dd.MM.yyyy}");
                column.Item().Text($"Datum splatnosti: {_invoice.DueDate:dd.MM.yyyy}");
                column.Item().Text($"Celková částka: {_invoice.Price:C}");
                column.Item().Text($"Stav: {(_invoice.IsPaid ? "Zaplaceno" : "Nezaplaceno")}");
            });
        });
    }
}

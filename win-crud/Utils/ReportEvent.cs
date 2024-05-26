using iTextSharp.text;
using iTextSharp.text.pdf;

namespace win_crud.Utils;
public class ReportEvent : PdfPageEventHelper
{
    private PdfContentByte Wdc;
    private int TotalPages { get; set; }

    private BaseFont BaseFontFooter { get; set; }
    private iTextSharp.text.Font FontFooter { get; set; }
    public ReportEvent(int totalPages)
    {
        TotalPages = totalPages;
        BaseFontFooter = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, false);
        FontFooter = new iTextSharp.text.Font(BaseFontFooter, 8F,
                     iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
    }

    public override void OnOpenDocument(PdfWriter writer, Document document)
    {
        base.OnOpenDocument(writer, document);
        Wdc = writer.DirectContent;
    }

    public override void OnEndPage(PdfWriter writer, Document document)
    {
        base.OnEndPage(writer, document);
        AddDateTimeMoment(writer, document);
        AddCountPages(writer, document);
    }

    private void AddDateTimeMoment(PdfWriter _, Document document)
    {
        string dateTimeReport = $"Gerado em {DateTime.Now.ToShortDateString()} às {DateTime.Now.ToShortTimeString()}";

        Wdc.BeginText();
        Wdc.SetFontAndSize(FontFooter.BaseFont, FontFooter.Size);
        Wdc.SetTextMatrix(document.LeftMargin, document.BottomMargin * 0.75f);
        Wdc.ShowText(dateTimeReport);
        Wdc.EndText();
    }

    private void AddCountPages(PdfWriter writer, Document document)
    {
        int currentPage = writer.PageNumber;
        string textPage = $"Página {currentPage} de {TotalPages}";
        float widthTextPage = BaseFontFooter.GetWidthPoint(textPage, FontFooter.Size);
        var pageSize = document.PageSize;

        Wdc.BeginText();
        Wdc.SetFontAndSize(FontFooter.BaseFont, FontFooter.Size);
        Wdc.SetTextMatrix(pageSize.Width - document.RightMargin - widthTextPage, document.BottomMargin * 0.75f);
        Wdc.ShowText(textPage);
        Wdc.EndText();

    }
}

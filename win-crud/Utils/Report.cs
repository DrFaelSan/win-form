using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;
using win_crud.Model;

namespace win_crud.Utils;
public class Report
{
    static readonly BaseFont BaseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, false);
    const int DefaultDpi = 72;
    const float MmInPx = 25.2F;

    public static void BuildPersonReport(IEnumerable<Person> persons)
    {

        int totalPages = GetTotalPages(persons);
        float pxInMm = DefaultDpi / MmInPx;

        Document pdf = new(PageSize.A4, 15 * pxInMm /*15mm*/, 15 * pxInMm, 15 * pxInMm, 20 * pxInMm /*20mm*/);
        string fileName = $"persons_report.{DateTime.Now:dd_MM_yyyy_HH_mm_sss}.pdf";
        FileStream file = new(fileName, FileMode.Create);

        PdfWriter writer = PdfWriter.GetInstance(pdf, file);
        writer.PageEvent = new ReportEvent(totalPages);

        Paragraph title = GetTitle();
        PdfPTable table = GetTable(persons);

        pdf.Open();        

        pdf.Add(title);
        pdf.Add(table);

        pdf.Close();

        file.Close();

        OpenFile(fileName);
    }

    private static int GetTotalPages(IEnumerable<Person> persons)
    {
        int totalPages = 1;
        int totalLines = persons.Count();
        if (totalLines > 24)
            totalPages += (int)Math.Ceiling((totalLines - 24) / 29F);
        return totalPages;
    }

    private static Paragraph GetTitle()
    {
        //Title
        iTextSharp.text.Font fontParagraph = new(BaseFont, 32, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
        return new("Relatório de Pessoas \n\n", fontParagraph)
        {
            Alignment = Element.ALIGN_LEFT,
            SpacingAfter = 4
        };
    }

    private static PdfPTable GetTable(IEnumerable<Person> persons)
    {
        //Table
        PdfPTable table = new(6);
        float[] widthCols = { 0.6f, 2f, 1f, 1.5f, 2f, 1.5f };
        table.SetWidths(widthCols);
        table.DefaultCell.BorderWidth = 0;
        table.WidthPercentage = 100;

        //Table Header
        BuildTextCell(table, "ID", Element.ALIGN_CENTER, true);
        BuildTextCell(table, "Nome Completo", Element.ALIGN_LEFT, true);
        BuildTextCell(table, "Idade", Element.ALIGN_CENTER, true);
        BuildTextCell(table, "Telefone", Element.ALIGN_CENTER, true);
        BuildTextCell(table, "Email", Element.ALIGN_LEFT, true);
        BuildTextCell(table, "CPF", Element.ALIGN_CENTER, true);

        //Table Body 
        foreach (Person person in persons)
        {
            BuildTextCell(table, person.Id.ToString(), Element.ALIGN_CENTER);
            BuildTextCell(table, person.FullName);
            BuildTextCell(table, person.Age.ToString(), Element.ALIGN_CENTER);
            BuildTextCell(table, person.Phone ?? "", Element.ALIGN_CENTER);
            BuildTextCell(table, person.Email ?? "", Element.ALIGN_CENTER);
            BuildTextCell(table, person.CPF ?? "", Element.ALIGN_CENTER);
        }

        return table;
    }

    /// <summary>
    /// Abro o arquivo na maquina do usuário apartir do caminha relativo passado ao nome do arquivo.
    /// </summary>
    /// <param name="fileName">caminho relativo+nome do aquivo</param>
    private static void OpenFile(string fileName)
    {
        string pathPdf = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
        try
        {
            if (File.Exists(pathPdf))
            {
                try
                {
                    Process.Start(new ProcessStartInfo()
                    {
                        FileName = pathPdf,
                        UseShellExecute = true
                    });
                }
                catch
                {
                    Process.Start(pathPdf);
                }
            }
        }
        catch
        {
            MessageBox.Show($"Aconteceu um error ao tentar abrir o arquivo, mas ele encontra: {pathPdf}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private static void BuildTextCell(
        PdfPTable table,
        string text,
        int alignX = Element.ALIGN_LEFT,
        bool bold = false,
        bool italic = false,
        int fontSize = 12,
        int heightCell = 25
        )
    {

        int style = iTextSharp.text.Font.NORMAL;
        if(bold && italic)
            style = iTextSharp.text.Font.BOLDITALIC;
        else if (bold)
            style = iTextSharp.text.Font.BOLD;
        else if (italic)
            style = iTextSharp.text.Font.ITALIC;

        iTextSharp.text.Font fontCell = new(BaseFont, fontSize, style, BaseColor.BLACK);

        BaseColor bgColor = table.Rows.Count % 2 == 1 ? new BaseColor(0.95f, 0.95f, 0.95f) : BaseColor.WHITE;

        PdfPCell cell = new(new Phrase(text, fontCell))
        {
            HorizontalAlignment = alignX,
            VerticalAlignment = Element.ALIGN_MIDDLE,
            Border = 0,
            BorderWidthBottom = 1,
            FixedHeight = heightCell,
            PaddingBottom = 5,
            BackgroundColor = bgColor
        };

        table.AddCell(cell);

    }
}

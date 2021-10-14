using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;


namespace Task
{
    public class PDFedit
    {
  
        public static string text;

        public static void EdiiText()
        {

            PdfDocument pd = PdfReader.Open("..\\Doc.pdf", PdfDocumentOpenMode.Modify);

            PdfPage page = pd.Pages[0];

            XGraphics gfx = XGraphics.FromPdfPage(page);

            XFont font = new XFont("Verdana", 11, XFontStyle.BoldItalic);

            AnketaSotrudnik.Get();
            
            
            
            gfx.DrawString(text, font, XBrushes.Black,
                new XRect(35, 210, page.Width, page.Height),
                XStringFormats.TopLeft);

            const string filename = "..\\DocEdit.pdf";
            pd.Save(filename);
        }
  }
}



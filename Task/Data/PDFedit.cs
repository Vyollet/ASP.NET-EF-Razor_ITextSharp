using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System.Text;


namespace Task
{
    public class PDFedit
    {
        public static void EdiiText() 
        { 
            PdfDocument pd = PdfReader. Open("..\\Doc.pdf");
            PdfDocument PDFNewDoc = new PdfDocument();
            
            pd.Info.Title = "Created with PDFsharp";
 
            XGraphics gfx = XGraphics.FromPdfPage(page);
 
            XFont font = new XFont("Verdana", 16, XFontStyle.BoldItalic);
            
            gfx.DrawString("TestPDFSharp", font, XBrushes.Black,
                new XRect(0, 0, page.Width, page.Height),
                XStringFormats.Center);

            
                
        const string filename = "..\\DocEdit.pdf";
        pd.Save(filename);
    }
}


}


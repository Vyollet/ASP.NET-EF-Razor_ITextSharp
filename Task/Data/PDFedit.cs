using System;
using System.Collections.Generic;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System.IO;
using System.Linq;
using iTextSharp.text;

namespace Task
{
    public class PDFedit
    {
      public void ReplaceTextInPDF(string sourceFile, string descFile, string textToBeSearched, string textToBeReplaced)
    {
        ReplaceText(textToBeSearched, textToBeReplaced, descFile, sourceFile);
    }
    private void ReplaceText(string textToBeSearched, string textToAdd, string outputFilePath, string inputFilePath)
    {
        try
        {
            using (Stream inputPdfStream = new FileStream(inputFilePath, FileMode.Open, FileAccess.Read, FileShare.Read))
            using (Stream outputPdfStream = new FileStream(outputFilePath, FileMode.Create, FileAccess.Write, FileShare.ReadWrite))
            using (Stream outputPdfStream2 = new FileStream(outputFilePath, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite))
            {
                PdfReader reader = new PdfReader(inputPdfStream);

                PdfStamper stamper = new PdfStamper(reader, outputPdfStream); 
                for (var i = 1; i <= reader.NumberOfPages; i++)
                {
                    var tt = new MyLocationTextExtractionStrategy(textToBeSearched);
                    var ex = PdfTextExtractor.GetTextFromPage(reader, i, tt); 
                    foreach (var p in tt.myPoints)
                    {
                        PdfContentByte cb = stamper.GetOverContent(i);

                        BaseFont bf = BaseFont.CreateFont("c:/windows/fonts/arial.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                        cb.SetColorFill(BaseColor.BLACK);
                        cb.SetFontAndSize(bf, 8);

                        cb.BeginText();
                        
                        cb.ShowTextAligned(0, textToAdd, p.Rect.Left + 2, p.Rect.Top - 6, 0);
                        cb.EndText();
                    }
                }
                stamper.Close();
            }
        }
        catch (Exception ex)
        {
        }
    }
    public class RectAndText
    {
        public Rectangle Rect;
        public String Text;
        public RectAndText(Rectangle rect, String text)
        {
            this.Rect = rect;
            this.Text = text;
        }
    }
    public class MyLocationTextExtractionStrategy : LocationTextExtractionStrategy
    {
        //Hold each coordinate
        public List<RectAndText> myPoints = new List<RectAndText>();

        //The string that we're searching for
        public String TextToSearchFor { get; set; }

        //How to compare strings
        public System.Globalization.CompareOptions CompareOptions { get; set; }

        public MyLocationTextExtractionStrategy(String textToSearchFor, System.Globalization.CompareOptions compareOptions = System.Globalization.CompareOptions.None)
        {
            this.TextToSearchFor = textToSearchFor;
            this.CompareOptions = compareOptions;
        }

        public override void RenderText(TextRenderInfo renderInfo)
        {

            base.RenderText(renderInfo);
            
            var startPosition = System.Globalization.CultureInfo.CurrentCulture.CompareInfo.IndexOf(renderInfo.GetText(), TextToSearchFor, CompareOptions);

            if (startPosition < 0)
            {
                return;
            }
            var chars = renderInfo.GetCharacterRenderInfos().Skip(startPosition).Take(TextToSearchFor.Length).ToList();

            var firstChar = chars.First();
            var lastChar = chars.Last();

            var bottomLeft = firstChar.GetDescentLine().GetStartPoint();
            var topRight = lastChar.GetAscentLine().GetEndPoint();

            var rect = new iTextSharp.text.Rectangle(bottomLeft[Vector.I1], bottomLeft[Vector.I2], topRight[Vector.I1], topRight[Vector.I2]);

            myPoints.Add(new RectAndText(rect, TextToSearchFor));
        }
    }
  }
}



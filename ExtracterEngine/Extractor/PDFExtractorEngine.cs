using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using TextExtractor.ExtracterEngine.Contracts;

namespace TextExtractor.ExtracterEngine
{
    public class PDFExtractorEngine : IExtractorEngine
    {
        public void ExtractData(string fileName)
        {
            var pdfHeight = 841;

            System.util.RectangleJ rec = new System.util.RectangleJ(62, pdfHeight - 150, 112, 12);
            PdfReader pdfReader = new PdfReader(fileName);
            RenderFilter[] filter = { new RegionTextRenderFilter(rec) };
            ITextExtractionStrategy textExtractionStrategy;
            StringBuilder sb = new StringBuilder();


            for (int page = 1; page <= pdfReader.NumberOfPages; page++)
            {
                textExtractionStrategy = new FilteredTextRenderListener(new LocationTextExtractionStrategy(), filter);
                sb.AppendLine(PdfTextExtractor.GetTextFromPage(pdfReader, page, textExtractionStrategy));
            }
        }
    }
}

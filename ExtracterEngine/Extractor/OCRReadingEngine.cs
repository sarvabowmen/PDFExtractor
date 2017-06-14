using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextExtractor.ExtracterEngine.Contracts;
using Tesseract;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace TextExtractor.ExtracterEngine
{
    public class OCRReaderEngine : IExtractorEngine
    {
        public OCRReaderEngine()
        {

        }

        public void ExtractData(string fileName) {
            var ocrImage = new System.Drawing.Bitmap(fileName);
            var ocrText = string.Empty;
            using (var ocr = new TesseractEngine(@"./tessdata", "eng"))
            {
                using(var img= PixConverter.ToPix(ocrImage)) {

                    using (var page = ocr.Process(img)) {
                        var ocrtext = page.GetText();
                    }
                }
            }
           
        }
    }
}

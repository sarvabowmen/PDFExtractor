using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextExtractor.ExtracterEngine.Contracts;
using TextExtractor.ExtracterEngine;

namespace TextExtractor.ExtracterEngine
{
    public class ExtractorFactory
    {
        public Dictionary<string, IExtractorEngine> Container { get; set; }

        public ExtractorFactory()
        {
            Container.Add("PDF", new PDFExtractorEngine());
            Container.Add("OCR", new OCRReaderEngine());
        }

        public IExtractorEngine GetInstance(string name) {
            return Container[name];
            }


        }
    }

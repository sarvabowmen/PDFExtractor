using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextExtractor.ExtracterEngine.Contracts
{
    public interface IExtractorEngine
    {
        void ExtractData(string fileName);
    }
}

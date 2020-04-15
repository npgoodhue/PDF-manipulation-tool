using iText.Kernel.Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace splitPDFsUI
{
    public class SplitPDFtool
    {
        PdfReader reader;
        PdfDocument doc;
        int numPages;

        public SplitPDFtool(string filename)
        {
            reader = new PdfReader(filename);
            doc = new PdfDocument(reader);
            numPages = doc.GetNumberOfPages();
        }

        public int NumPages
        {
            get
            {
                return numPages;
            }
        }

        public int createPdfFromPages(List<int> pages, string outputFile)
        {
            try
            {
                PdfWriter writer = new PdfWriter(outputFile);
                PdfDocument newDoc = new PdfDocument(writer);

                doc.CopyPagesTo(pages, newDoc);
                newDoc.Close();
                return 0;
            }
            catch
            {
                return -1;
            }
        }
    }
}

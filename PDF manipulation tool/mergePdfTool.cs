using iText.Kernel.Pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace mergePDFsUI
{
    class MergePdfTool
    {
        public static int MergePDF(List<string> listOfFiles, string outputFile)
        {
            try
            {
                PdfWriter writer = new PdfWriter(outputFile);
                PdfDocument newDoc = new PdfDocument(writer);

                PdfReader reader;
                PdfDocument pdfInnerDocument;

                listOfFiles.ForEach(file =>
                {
                    reader = new PdfReader(file);
                    pdfInnerDocument = new PdfDocument(reader);
                    pdfInnerDocument.CopyPagesTo(Enumerable.Range(1, pdfInnerDocument.GetNumberOfPages()).ToList(), newDoc);
                    pdfInnerDocument.Close();
                });

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

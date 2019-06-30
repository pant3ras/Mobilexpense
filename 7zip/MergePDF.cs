using System;
using System.Collections.Generic;
using System.Text;
using Spire.Pdf;
using Spire.Doc;
using Spire.Xls;
using System.IO;
/*
 * Created by Liviu Chile (2019-06-30) 
 * For the technical test from MobileXpense
 * ######################################
 * This will program work with spire API, and get's the documents from the 
 * input folder and saves it into one pdf.
 * 
 */
namespace _7zip
{
    class MergePDF
    {
        public static void pdf()//(string[] args)
        {
            PdfDocument[] documents = new PdfDocument[4];
            using (MemoryStream ms1 = new MemoryStream())
            {
                Document doc = new Document("test.docx", Spire.Doc.FileFormat.Doc);
                doc.SaveToStream(ms1, Spire.Doc.FileFormat.PDF);
                documents[0] = new PdfDocument(ms1);
            }

            using (MemoryStream ms2 = new MemoryStream())
            {
                Document jpg = new Document("test.jpg", Spire.Doc.FileFormat.Auto);
                jpg.SaveToStream(ms2, Spire.Doc.FileFormat.PDF);
                documents[1] = new PdfDocument(ms2);
            }
            using (MemoryStream ms3 = new MemoryStream())
            {
                Workbook workbook = new Workbook();
                workbook.LoadFromFile("test.xlsx", ExcelVersion.Version2007);
                workbook.SaveToStream(ms3, Spire.Xls.FileFormat.PDF);
                documents[2] = new PdfDocument(ms3);
            }
            documents[3] = new PdfDocument("04.pdf");
            for (int i = 2; i > -1; i--)
            {
                documents[3].AppendPage(documents[i]);
            }

            documents[3].SaveToFile("outputproblemstatement2.pdf");
        }



    }
}

using System;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace CrearPDF
{
    class Program
    {
        static void Main(string[] args)
        {
            Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream("archivo.pdf", FileMode.Create));
            doc.Open();
            doc.Add(new Paragraph("Hola mundo desde el código de Jaime"));
            doc.Close();
        }
    }
}

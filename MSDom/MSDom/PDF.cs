using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//pdf
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;
using System.Diagnostics;

namespace MSDom
{
    public class PDF
    {
        public static void IspisNarudzbenice(int idNalaza, List<StavkeNarudzbenice> popisLijekova)
        {
            try
            {
                if (popisLijekova == null)
                    return;

                
                Document doc = new Document(PageSize.A4, 30, 30, 30, 30);
                
                PdfWriter pdf = PdfWriter.GetInstance(doc, new FileStream("Narudzbenica.pdf", FileMode.Create)); 
                
                doc.Open();

                iTextSharp.text.Font naslovFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 32);
                Paragraph paragraph = new Paragraph($"ID narudzbenice {idNalaza}", naslovFont);
                paragraph.Alignment = Element.ALIGN_CENTER;
                doc.Add(paragraph);

                
                doc.Add(new Paragraph("\n"));
                doc.Add(new Paragraph("\n"));
                

                
                
                PdfPTable table = new PdfPTable(2); 

                
                iTextSharp.text.Font tablica = FontFactory.GetFont(FontFactory.HELVETICA, 14);
                
                PdfPCell pdfPCell = new PdfPCell(new Phrase("Stavke narudzbenice", tablica));
                
                pdfPCell.Colspan = 2;
                
                pdfPCell.BackgroundColor = CMYKColor.GRAY;
                pdfPCell.HorizontalAlignment = Element.ALIGN_CENTER;
                pdfPCell.VerticalAlignment = Element.ALIGN_CENTER;
                
                table.AddCell(pdfPCell);

                
                table.HeaderRows = 1;

                
                for (int i = 0; i < popisLijekova.Count; i++)
                { 
                    table.AddCell(new Phrase(popisLijekova[i].ID.ToString(), tablica)); 
                    
                    table.AddCell(new Phrase(popisLijekova[i].Naziv, tablica));
                    
                    
                }
                
                doc.Add(table);

            
                doc.Close();

                Process.Start("Narudzbenica.pdf");
            }
            catch
            {
                MessageBox.Show("PDF dokument je već otvoren");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//pdf
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;
using System.Diagnostics;

namespace IspisPdf
{
    public class Ispis
    {
        public static bool IspisNarudzbenice(int idNalaza, List<StavkeNarudzbenice> popisLijekova)
        {
            try
            {
                if (popisLijekova == null)
                    return false;


                Document doc = new Document(PageSize.A4, 65, 65, 30, 30);

                PdfWriter pdf = PdfWriter.GetInstance(doc, new FileStream("Narudzbenica.pdf", FileMode.Create));

                doc.Open();

                PdfPTable tableOsnovniPodaci = new PdfPTable(3);
                tableOsnovniPodaci.WidthPercentage = 100;

                Image logo = Image.GetInstance(@"F:\PI projekt\r18073\MSDom\MSDom\bin\Debug\logo.png");
                logo.ScaleAbsolute(80f, 80f);
                PdfPCell slika = new PdfPCell(logo);

                iTextSharp.text.Font fontDesnaStrana = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 13);


                PdfPCell celijaLijevaStrana = new PdfPCell(new Phrase($"MSDOM \nAdresa:\nPavlisnka 2, Varaždin\ne-mail:\nMSDOM@gmail.com", fontDesnaStrana));
                PdfPCell celijaDesnaStrana = new PdfPCell(new Phrase($"Narudzbenica br. {idNalaza} \nDatum: {DateTime.Now.ToShortDateString()}", fontDesnaStrana));

                celijaLijevaStrana.BorderWidth = 0;
                celijaDesnaStrana.BorderWidth = 0;
                slika.BorderWidth = 0;

                tableOsnovniPodaci.AddCell(slika);

                tableOsnovniPodaci.AddCell(celijaLijevaStrana);
                tableOsnovniPodaci.AddCell(celijaDesnaStrana);

                doc.Add(tableOsnovniPodaci);

                doc.Add(new Paragraph("\n"));
                doc.Add(new Paragraph("\n"));




                PdfPTable table = new PdfPTable(3);
                table.WidthPercentage = 100;

                iTextSharp.text.Font tablica = FontFactory.GetFont(FontFactory.HELVETICA, 14);

                PdfPCell naslovTablice = new PdfPCell(new Phrase("Stavke narudzbenice", tablica));
                naslovTablice.Padding = 5;
                naslovTablice.Colspan = 3;

                naslovTablice.BackgroundColor = CMYKColor.GRAY;
                naslovTablice.HorizontalAlignment = Element.ALIGN_CENTER;
                naslovTablice.VerticalAlignment = Element.ALIGN_CENTER;

                table.AddCell(naslovTablice);


                table.HeaderRows = 1;

                table.AddCell(new Phrase("Rbr.", tablica));
                table.AddCell(new Phrase("Naziv lijeka", tablica));
                table.AddCell(new Phrase("Količina", tablica));

                for (int i = 0; i < popisLijekova.Count; i++)
                {
                    table.AddCell(new Phrase((i + 1).ToString(), tablica));
                    table.AddCell(new Phrase(popisLijekova[i].Naziv, tablica));
                    table.AddCell(new Phrase(popisLijekova[i].Kolicina.ToString(), tablica));
                }

                doc.Add(table);

                //PRAZNI REDOVI
                doc.Add(new Paragraph("\n"));
                doc.Add(new Paragraph("\n"));

                //TABLICA S 2 STUPCA
                PdfPTable zigPotpis = new PdfPTable(2);
                zigPotpis.WidthPercentage = 100;

                //Zig
                iTextSharp.text.Font zigFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 17);
                PdfPCell zigTekst = new PdfPCell(new Phrase("M.P.", zigFont));
                zigTekst.BorderWidth = 0;
                zigTekst.HorizontalAlignment = Element.ALIGN_CENTER;
                zigTekst.VerticalAlignment = Element.ALIGN_MIDDLE;

                //POTPIS
                iTextSharp.text.Font potpisFont = FontFactory.GetFont(FontFactory.HELVETICA, 13);
                PdfPCell potpisTekst = new PdfPCell(new Phrase("Potpis\n\n\n_______________________________", potpisFont));
                potpisTekst.BorderWidth = 0;
                potpisTekst.HorizontalAlignment = Element.ALIGN_CENTER;

                //DODAJ CELIJE U TABLICU
                zigPotpis.AddCell(zigTekst);
                zigPotpis.AddCell(potpisTekst);

                //DODAJ TABLICU U DOKUMENT
                doc.Add(zigPotpis);

                doc.Close();

                Process.Start("Narudzbenica.pdf");
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

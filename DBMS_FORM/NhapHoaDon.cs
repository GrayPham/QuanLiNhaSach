using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBMS_FORM.Object;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace DBMS_FORM
{
    public partial class NhapHoaDon : Form
    {
        public NhapHoaDon()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            PdfPTable billHeader = new PdfPTable(1);
            PdfPTable printBill = new PdfPTable(2);
            PdfPTable billFooter = new PdfPTable(1);

            //design billHeader
            billHeader.WidthPercentage = 80;
            billHeader.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
            billHeader.DefaultCell.VerticalAlignment = Element.ALIGN_CENTER;
            //pdfTable1.DefaultCell.BackgroundColor = new iTextSharp.text.BaseColor(64, 134, 170);
            billHeader.DefaultCell.BorderWidth = 0;
            billFooter.DefaultCell.PaddingBottom = 10;
            //design Bill table
            printBill.DefaultCell.Padding = 5;
            printBill.WidthPercentage = 50;
            printBill.DefaultCell.BorderWidth = 0.5f;

            //design bill Footer 
            billHeader.WidthPercentage = 80;
            billFooter.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
            billFooter.DefaultCell.VerticalAlignment = Element.ALIGN_CENTER;
            billFooter.DefaultCell.BorderWidth = 0;
            billFooter.DefaultCell.PaddingTop = 10;
            //set up bill
            string bill = "";
            if (radiosell.Checked)
            {
                bill = "BILL OF SELL";
            }
            else if (radiorent.Checked)
            {
                bill = "BILL OF RENT";
            }


            string member = "";
            if (btnstill.Checked)
            {
                member = "STILL";
            }
            else if (btnno.Checked)
            {
                member = "NO";
            }
            //BILL HEADER

            Chunk c1 = new Chunk(bill, FontFactory.GetFont("Times New Roman"));
            c1.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
            c1.Font.SetStyle(0);
            c1.Font.Size = 14;
            Phrase p1 = new Phrase();
            p1.Add(c1);
            billHeader.AddCell(p1);
            //BILL TABLE
            printBill.AddCell(new Phrase("Customer Name:"));
            printBill.AddCell(new Phrase(customertxt.Text));
            printBill.AddCell(new Phrase("Input Date:"));
            printBill.AddCell(new Phrase(inputdatetxt.Text));
            printBill.AddCell(new Phrase("Member:"));
            printBill.AddCell(new Phrase(member));
            printBill.AddCell(new Phrase("Member ID:"));
            printBill.AddCell(new Phrase(memidtxt.Text));
            printBill.AddCell(new Phrase("Sale Off: "));
            printBill.AddCell(new Phrase(discounttxt.Text));
            printBill.AddCell(new Phrase("Quantity:"));
            printBill.AddCell(new Phrase(quantxt.Text));
            printBill.AddCell(new Phrase("Book Name:"));
            printBill.AddCell(new Phrase(booknametxt.Text));
            printBill.AddCell(new Phrase("Total Money:"));
            printBill.AddCell(new Phrase(totaltxt.Text));


            //BILL FOOTER
            billFooter.AddCell(new Phrase("Thank you and see you again!"));

            //PDF generation 
            string folderPath = "C:\\Users\\Admin\\Winform\\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            //File Name
            int fileCount = Directory.GetFiles(@"C:\\Users\\Admin\\Winform").Length;
            string strFileName = "Bill" + (fileCount + 1) + ".pdf";
            using (FileStream stream = new FileStream(folderPath + strFileName, FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(billHeader);
                pdfDoc.Add(printBill);
                pdfDoc.Add(billFooter);
                pdfDoc.NewPage();
                pdfDoc.Close();
                stream.Close();
            }
            System.Diagnostics.Process.Start(folderPath + "\\" + strFileName);
        }

        private void NhapHoaDon_Load(object sender, EventArgs e)
        {
            label_name.Text = BaseData.Name;
            labelRole.Text = BaseData.role;
        }

        private void memidtxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

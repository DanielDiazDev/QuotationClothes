using QuotationClothes.Data;
using System.Drawing.Printing;

namespace QuotationClothes.HistorialView
{
    public partial class HistorialForm : Form
    {
        public HistorialForm()
        {
            InitializeComponent();
            ShowQuotations();
        }
        private void ShowQuotations()
        {
            using (var context = new ApplicationDbContext())
            {
                var quotations = context.Quotations.ToList();


                foreach (var quotation in quotations)
                {
                    int n = dataGW.Rows.Add();

                    // Asignar los valores de las propiedades de la cotización a las celdas correspondientes
                    dataGW.Rows[n].Cells[0].Value = quotation.Id;
                    dataGW.Rows[n].Cells[1].Value = quotation.Date;
                    dataGW.Rows[n].Cells[2].Value = quotation.GarmentId;
                    dataGW.Rows[n].Cells[3].Value = quotation.QuantityUnitsQuoted;
                    dataGW.Rows[n].Cells[4].Value = quotation.SellerId;
                    dataGW.Rows[n].Cells[5].Value = quotation.ResultCalculateQuotation;

                }
            }
        }

        private void backMainFormBtn_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private void printerBtn_Click(object sender, EventArgs e)
        {
            // Configurar el PrintDocument
            printDocument1.PrintPage += new PrintPageEventHandler(this.printDocument1_PrintPage);
            // Mostrar el cuadro de diálogo de vista previa de impresión
            printDialog1.Document = printDocument1;
            printDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Configurar los márgenes
            Margins margins = new Margins(50, 50, 50, 50);
            // Configurar los márgenes
            RectangleF printerArea = new RectangleF(e.MarginBounds.Left, e.MarginBounds.Top, e.MarginBounds.Width - margins.Right,e.MarginBounds.Height - margins.Bottom);
            // Dibujar el DataGridView en el área de impresión
            dataGW.DrawToBitmap(new Bitmap(dataGW.Width, dataGW.Height), new Rectangle(0, 0, dataGW.Width, dataGW.Height));
            // Dibujar el contenido del DataGridView en la página de impresión dentro de los márgenes
            e.Graphics.DrawImage(new Bitmap(dataGW.Width, dataGW.Height), printerArea);
        }
    }
}
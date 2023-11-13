using QuotationClothes.HistorialView;
using QuotationClothes.Presenter;

namespace QuotationClothes.View
{
    public partial class MainForm : Form, IView
    {
        private QuotationPresenter _presenter;

        public event EventHandler<bool> onShortSelected;
        public event EventHandler<bool> onLongSelected;
        public event EventHandler onContize;
        public event EventHandler<bool> onStandartSelected;
        public event EventHandler<bool> onMaoSelected;
        public event EventHandler<bool> onCommomShirtSelected;
        public event EventHandler<bool> onCommomSelected;
        public event EventHandler<bool> onChupinSelected;
        public event EventHandler<bool> onPremiumSelected;
        public event EventHandler onUnitsStock;

        public MainForm()
        {
            InitializeComponent();
            _presenter = new QuotationPresenter();
            _presenter.Initialize(this);
            sleeveShortCB.Checked = true;
            standartRB.Checked = true;
            this.DoubleBuffered = true;
        }


        private void shirtRB_CheckedChanged(object sender, EventArgs e)
        {

            if (shirtRB.Checked)
            {
                sleeveShortCB.Enabled = true;
                maoCB.Enabled = true;
                pantChupinCB.Enabled = false;
                pantChupinCB.Checked = false;
                onChupinSelected?.Invoke(this, false);
                onCommomSelected?.Invoke(this, false);
            }
        }
        private void pantRB_CheckedChanged(object sender, EventArgs e)
        {
            if (pantRB.Checked)
            {
                sleeveShortCB.Checked = false;
                sleeveShortCB.Enabled = false;
                maoCB.Enabled = false;
                maoCB.Checked = false;
                onLongSelected?.Invoke(this, false);
                onShortSelected?.Invoke(this, false);
                onMaoSelected?.Invoke(this, false);
                onCommomSelected?.Invoke(this, false);
                pantChupinCB.Enabled = true;

            }

        }
        private void sleeveShortCB_CheckedChanged(object? sender, EventArgs e)
        {
            if (sleeveShortCB.Checked)
            {
                onShortSelected?.Invoke(this, true);
                onLongSelected?.Invoke(this, false);

            }
            else
            {
                onShortSelected?.Invoke(this, false);
                onLongSelected?.Invoke(this, true);

            }

        }
        private void maoCB_CheckedChanged(object sender, EventArgs e)
        {
            if (maoCB.Checked)
            {
                onMaoSelected?.Invoke(this, true);
                onCommomSelected?.Invoke(this, false);
            }
            else
            {
                onMaoSelected?.Invoke(this, false);
                onCommomShirtSelected?.Invoke(this, true);
            }
        }
        private void pantChupinCB_CheckedChanged(object sender, EventArgs e)
        {
            if (pantChupinCB.Checked)
            {
                onChupinSelected?.Invoke(this, true);
                onCommomSelected?.Invoke(this, false);
            }
            else
            {
                onChupinSelected?.Invoke(this, false);
                onCommomSelected?.Invoke(this, true);
            }
        }
        private void standartRB_CheckedChanged(object sender, EventArgs e)
        {
            if (standartRB.Checked)
            {
                onStandartSelected?.Invoke(this, true);
            }
            else
            {
                onStandartSelected?.Invoke(this, false);
            }
        }

        private void premiumRB_CheckedChanged(object sender, EventArgs e)
        {
            if (premiumRB.Checked)
            {
                onPremiumSelected?.Invoke(this, true);
            }
            else
            {
                onPremiumSelected?.Invoke(this, false);
            }
        }
        public int QuantityToQuotize()
        {
            int result;
            if (int.TryParse(quantityText.Text, out result))
            {
                return result; // El parseo fue exitoso, devuelve el valor parseado.
            }
            else
            {
                return 0; // El parseo falló, devuelve 0.
            }
        }
        public void ShowPrice(string v)
        {
            finalPriceLbl.Text = v;
        }
        public void ShowUnitsStocks(string v)
        {
            unitsStockLbl.Text = v;
        }

        private void quotationBtn_Click(object sender, EventArgs e)
        {
            finalPriceLbl.Text = "";

            onContize?.Invoke(this, EventArgs.Empty);

        }

        public void ShowName(string v)
        {
            sellerNameLbl.Text = v;
        }

        public void ShowStoreName(string v)
        {
            storeNameLbl.Text = v;
        }

        public void ShowDirection(string v)
        {
            directionLbl.Text = v;
        }

        public void ShowSellerId(string v)
        {
            sellerIdLbl.Text = v;
        }

        public void ShowUnitsPrice(string v)
        {
            unitPriceLbl.Text = v;
        }
        public void ShowNoStockMessage(string v)
        {
            MessageBox.Show(v, "Error" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void ShowQuantityExceedsMaxMessage(string v)
        {
            MessageBox.Show(v, "Error" ,MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        public void ShowArgumentNullMessage(string v)
        {
            MessageBox.Show(v, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void ShowNoQuantityMessage(string v)
        {
            MessageBox.Show(v, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void historialLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HistorialForm historialForm = new HistorialForm();
            historialForm.Show();
            this.Hide();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

            DrawLine(e);

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            DrawLine(e);

        }
        private void DrawLine(PaintEventArgs e)
        {
            // Obtiene el objeto Graphics del formulario
            Graphics g = e.Graphics;

            // Define los puntos de inicio y finalización de la línea
            Point startPoint = new Point(0, 10);
            Point endPoint = new Point(800, 10);

            // Crea un objeto Pen para definir el color y el grosor de la línea
            Pen pen = new Pen(Color.Black, 3);

            // Dibuja la línea en el formulario
            g.DrawLine(pen, startPoint, endPoint);

            pen.Dispose();
        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            PaintGroupBox(sender, e);
        }

        private static void PaintGroupBox(object sender, PaintEventArgs e)
        {
            GroupBox groupBox = (GroupBox)sender;

            // Crear una región con esquinas redondeadas
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int arcRadius = 20; // Radio de las esquinas redondeadas (ajusta según tus preferencias)
            int width = groupBox.Width;
            int height = groupBox.Height;

            path.AddArc(0, 0, arcRadius, arcRadius, 180, 90); // Esquina superior izquierda
            path.AddArc(width - arcRadius, 0, arcRadius, arcRadius, 270, 90); // Esquina superior derecha
            path.AddArc(width - arcRadius, height - arcRadius, arcRadius, arcRadius, 0, 90); // Esquina inferior derecha
            path.AddArc(0, height - arcRadius, arcRadius, arcRadius, 90, 90); // Esquina inferior izquierda
            path.CloseAllFigures();

            // Dibujar el GroupBox con esquinas redondeadas
            using (Pen pen = new Pen(groupBox.ForeColor, 2))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }

        private void groupBox2_Paint(object sender, PaintEventArgs e)
        {
            PaintGroupBox(sender, e);

        }

        private void groupBox3_Paint(object sender, PaintEventArgs e)
        {
            PaintGroupBox(sender, e);

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            DrawLine(e);

        }

        
    }
}
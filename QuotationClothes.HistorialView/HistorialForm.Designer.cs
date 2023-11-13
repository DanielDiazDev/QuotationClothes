namespace QuotationClothes.HistorialView
{
    partial class HistorialForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGW = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            date = new DataGridViewTextBoxColumn();
            garmentId = new DataGridViewTextBoxColumn();
            quantityQuoted = new DataGridViewTextBoxColumn();
            sellerId = new DataGridViewTextBoxColumn();
            priceTotal = new DataGridViewTextBoxColumn();
            backMainFormBtn = new Button();
            printerBtn = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printDialog1 = new PrintDialog();
            ((System.ComponentModel.ISupportInitialize)dataGW).BeginInit();
            SuspendLayout();
            // 
            // dataGW
            // 
            dataGW.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGW.Columns.AddRange(new DataGridViewColumn[] { id, date, garmentId, quantityQuoted, sellerId, priceTotal });
            dataGW.Location = new Point(12, 53);
            dataGW.Name = "dataGW";
            dataGW.RowHeadersWidth = 51;
            dataGW.RowTemplate.Height = 29;
            dataGW.Size = new Size(1024, 385);
            dataGW.TabIndex = 0;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.Width = 125;
            // 
            // date
            // 
            date.HeaderText = "Fecha";
            date.MinimumWidth = 6;
            date.Name = "date";
            date.Width = 125;
            // 
            // garmentId
            // 
            garmentId.HeaderText = "Prenda";
            garmentId.MinimumWidth = 6;
            garmentId.Name = "garmentId";
            garmentId.Width = 125;
            // 
            // quantityQuoted
            // 
            quantityQuoted.HeaderText = "Cantidad Cotizada";
            quantityQuoted.MinimumWidth = 6;
            quantityQuoted.Name = "quantityQuoted";
            quantityQuoted.Width = 125;
            // 
            // sellerId
            // 
            sellerId.HeaderText = "Id Vendedor";
            sellerId.MinimumWidth = 6;
            sellerId.Name = "sellerId";
            sellerId.Width = 125;
            // 
            // priceTotal
            // 
            priceTotal.HeaderText = "Precio Total";
            priceTotal.MinimumWidth = 6;
            priceTotal.Name = "priceTotal";
            priceTotal.Width = 125;
            // 
            // backMainFormBtn
            // 
            backMainFormBtn.BackColor = Color.DarkOrchid;
            backMainFormBtn.ForeColor = SystemColors.ButtonFace;
            backMainFormBtn.Location = new Point(814, 458);
            backMainFormBtn.Name = "backMainFormBtn";
            backMainFormBtn.Size = new Size(118, 47);
            backMainFormBtn.TabIndex = 1;
            backMainFormBtn.Text = "Back";
            backMainFormBtn.UseVisualStyleBackColor = false;
            backMainFormBtn.Click += backMainFormBtn_Click;
            // 
            // printerBtn
            // 
            printerBtn.BackColor = Color.DarkOrchid;
            printerBtn.ForeColor = SystemColors.ButtonFace;
            printerBtn.Location = new Point(854, 13);
            printerBtn.Name = "printerBtn";
            printerBtn.Size = new Size(93, 34);
            printerBtn.TabIndex = 2;
            printerBtn.Text = "Imprimir";
            printerBtn.UseVisualStyleBackColor = false;
            printerBtn.Click += printerBtn_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // HistorialForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1065, 528);
            Controls.Add(printerBtn);
            Controls.Add(backMainFormBtn);
            Controls.Add(dataGW);
            Name = "HistorialForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGW).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGW;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn garmentId;
        private DataGridViewTextBoxColumn quantityQuoted;
        private DataGridViewTextBoxColumn sellerId;
        private DataGridViewTextBoxColumn priceTotal;
        private Button backMainFormBtn;
        private Button printerBtn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintDialog printDialog1;
    }
}
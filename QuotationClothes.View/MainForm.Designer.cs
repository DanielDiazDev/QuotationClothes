namespace QuotationClothes.View
{
    partial class MainForm
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
            groupBox1 = new GroupBox();
            maoCB = new CheckBox();
            pantChupinCB = new CheckBox();
            sleeveShortCB = new CheckBox();
            pantRB = new RadioButton();
            shirtRB = new RadioButton();
            panel1 = new Panel();
            unitsStockLbl = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            premiumRB = new RadioButton();
            standartRB = new RadioButton();
            groupBox3 = new GroupBox();
            quantityText = new TextBox();
            label3 = new Label();
            unitPriceLbl = new Label();
            label2 = new Label();
            quotationBtn = new Button();
            label4 = new Label();
            finalPriceLbl = new Label();
            panel2 = new Panel();
            storeNameLbl = new Label();
            directionLbl = new Label();
            sellerNameLbl = new Label();
            sellerIdLbl = new Label();
            historialLink = new LinkLabel();
            panel3 = new Panel();
            label5 = new Label();
            panel4 = new Panel();
            label6 = new Label();
            panel5 = new Panel();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(maoCB);
            groupBox1.Controls.Add(pantChupinCB);
            groupBox1.Controls.Add(sleeveShortCB);
            groupBox1.Controls.Add(pantRB);
            groupBox1.Controls.Add(shirtRB);
            groupBox1.Location = new Point(14, 189);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(579, 155);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Prenda";
            groupBox1.Paint += groupBox1_Paint;
            // 
            // maoCB
            // 
            maoCB.AutoSize = true;
            maoCB.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            maoCB.Location = new Point(389, 39);
            maoCB.Name = "maoCB";
            maoCB.Size = new Size(82, 35);
            maoCB.TabIndex = 5;
            maoCB.Text = "Mao";
            maoCB.UseVisualStyleBackColor = true;
            maoCB.CheckedChanged += maoCB_CheckedChanged;
            // 
            // pantChupinCB
            // 
            pantChupinCB.AutoSize = true;
            pantChupinCB.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            pantChupinCB.Location = new Point(176, 95);
            pantChupinCB.Name = "pantChupinCB";
            pantChupinCB.Size = new Size(109, 35);
            pantChupinCB.TabIndex = 4;
            pantChupinCB.Text = "Chupin";
            pantChupinCB.UseVisualStyleBackColor = true;
            pantChupinCB.CheckedChanged += pantChupinCB_CheckedChanged;
            // 
            // sleeveShortCB
            // 
            sleeveShortCB.AutoSize = true;
            sleeveShortCB.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            sleeveShortCB.Location = new Point(176, 39);
            sleeveShortCB.Name = "sleeveShortCB";
            sleeveShortCB.Size = new Size(166, 35);
            sleeveShortCB.TabIndex = 2;
            sleeveShortCB.Text = "Manga corta";
            sleeveShortCB.UseVisualStyleBackColor = true;
            sleeveShortCB.CheckedChanged += sleeveShortCB_CheckedChanged;
            // 
            // pantRB
            // 
            pantRB.AutoSize = true;
            pantRB.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            pantRB.Location = new Point(14, 85);
            pantRB.Name = "pantRB";
            pantRB.Size = new Size(124, 35);
            pantRB.TabIndex = 1;
            pantRB.TabStop = true;
            pantRB.Text = "Pantalon";
            pantRB.UseVisualStyleBackColor = true;
            pantRB.CheckedChanged += pantRB_CheckedChanged;
            // 
            // shirtRB
            // 
            shirtRB.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            shirtRB.ForeColor = SystemColors.ActiveCaptionText;
            shirtRB.Location = new Point(14, 32);
            shirtRB.Name = "shirtRB";
            shirtRB.Size = new Size(118, 45);
            shirtRB.TabIndex = 0;
            shirtRB.TabStop = true;
            shirtRB.Text = "Camisa";
            shirtRB.UseVisualStyleBackColor = true;
            shirtRB.CheckedChanged += shirtRB_CheckedChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(unitsStockLbl);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(14, 359);
            panel1.Name = "panel1";
            panel1.Size = new Size(304, 43);
            panel1.TabIndex = 1;
            // 
            // unitsStockLbl
            // 
            unitsStockLbl.AutoSize = true;
            unitsStockLbl.Location = new Point(231, 12);
            unitsStockLbl.Name = "unitsStockLbl";
            unitsStockLbl.Size = new Size(0, 20);
            unitsStockLbl.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 9);
            label1.Name = "label1";
            label1.Size = new Size(204, 20);
            label1.TabIndex = 0;
            label1.Text = "Unidades de stock disponible";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(premiumRB);
            groupBox2.Controls.Add(standartRB);
            groupBox2.Location = new Point(14, 411);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 104);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Calidad de Prenda";
            groupBox2.Paint += groupBox2_Paint;
            // 
            // premiumRB
            // 
            premiumRB.AutoSize = true;
            premiumRB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            premiumRB.Location = new Point(138, 45);
            premiumRB.Name = "premiumRB";
            premiumRB.Size = new Size(111, 32);
            premiumRB.TabIndex = 1;
            premiumRB.TabStop = true;
            premiumRB.Text = "Premium";
            premiumRB.UseVisualStyleBackColor = true;
            premiumRB.CheckedChanged += premiumRB_CheckedChanged;
            // 
            // standartRB
            // 
            standartRB.AutoSize = true;
            standartRB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            standartRB.Location = new Point(16, 44);
            standartRB.Name = "standartRB";
            standartRB.Size = new Size(107, 32);
            standartRB.TabIndex = 0;
            standartRB.TabStop = true;
            standartRB.Text = "Standart";
            standartRB.UseVisualStyleBackColor = true;
            standartRB.CheckedChanged += standartRB_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(quantityText);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(unitPriceLbl);
            groupBox3.Controls.Add(label2);
            groupBox3.Location = new Point(333, 411);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(261, 104);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Precio unitario y Cantidad";
            groupBox3.Paint += groupBox3_Paint;
            // 
            // quantityText
            // 
            quantityText.Location = new Point(173, 53);
            quantityText.Name = "quantityText";
            quantityText.Size = new Size(74, 27);
            quantityText.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(83, 53);
            label3.Name = "label3";
            label3.Size = new Size(91, 28);
            label3.TabIndex = 2;
            label3.Text = "Cantidad";
            // 
            // unitPriceLbl
            // 
            unitPriceLbl.AutoSize = true;
            unitPriceLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            unitPriceLbl.Location = new Point(24, 53);
            unitPriceLbl.Name = "unitPriceLbl";
            unitPriceLbl.Size = new Size(0, 28);
            unitPriceLbl.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(7, 51);
            label2.Name = "label2";
            label2.Size = new Size(23, 28);
            label2.TabIndex = 0;
            label2.Text = "$";
            // 
            // quotationBtn
            // 
            quotationBtn.BackColor = Color.DarkOrchid;
            quotationBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            quotationBtn.ForeColor = SystemColors.ButtonFace;
            quotationBtn.Location = new Point(27, 576);
            quotationBtn.Name = "quotationBtn";
            quotationBtn.Size = new Size(144, 69);
            quotationBtn.TabIndex = 4;
            quotationBtn.Text = "Cotizar";
            quotationBtn.UseVisualStyleBackColor = false;
            quotationBtn.Click += quotationBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(313, 597);
            label4.Name = "label4";
            label4.Size = new Size(23, 28);
            label4.TabIndex = 5;
            label4.Text = "$";
            // 
            // finalPriceLbl
            // 
            finalPriceLbl.AutoSize = true;
            finalPriceLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            finalPriceLbl.Location = new Point(343, 597);
            finalPriceLbl.Name = "finalPriceLbl";
            finalPriceLbl.Size = new Size(0, 28);
            finalPriceLbl.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.Location = new Point(2, 520);
            panel2.Name = "panel2";
            panel2.Size = new Size(605, 17);
            panel2.TabIndex = 7;
            panel2.Paint += panel2_Paint;
            // 
            // storeNameLbl
            // 
            storeNameLbl.AutoSize = true;
            storeNameLbl.Location = new Point(0, 101);
            storeNameLbl.Name = "storeNameLbl";
            storeNameLbl.Size = new Size(113, 20);
            storeNameLbl.TabIndex = 8;
            storeNameLbl.Text = "Nombre Tienda";
            // 
            // directionLbl
            // 
            directionLbl.AutoSize = true;
            directionLbl.Location = new Point(454, 101);
            directionLbl.Name = "directionLbl";
            directionLbl.Size = new Size(121, 20);
            directionLbl.TabIndex = 9;
            directionLbl.Text = "Direccion Tienda";
            // 
            // sellerNameLbl
            // 
            sellerNameLbl.AutoSize = true;
            sellerNameLbl.Location = new Point(0, 144);
            sellerNameLbl.Name = "sellerNameLbl";
            sellerNameLbl.Size = new Size(193, 20);
            sellerNameLbl.TabIndex = 10;
            sellerNameLbl.Text = "Nombre Apellido Vendedor";
            // 
            // sellerIdLbl
            // 
            sellerIdLbl.AutoSize = true;
            sellerIdLbl.Location = new Point(153, 144);
            sellerIdLbl.Name = "sellerIdLbl";
            sellerIdLbl.Size = new Size(149, 20);
            sellerIdLbl.TabIndex = 11;
            sellerIdLbl.Text = "Codigo De Vendedor";
            // 
            // historialLink
            // 
            historialLink.AutoSize = true;
            historialLink.Location = new Point(434, 144);
            historialLink.Name = "historialLink";
            historialLink.Size = new Size(153, 20);
            historialLink.TabIndex = 12;
            historialLink.TabStop = true;
            historialLink.Text = "Historial Cotizaciones";
            historialLink.LinkClicked += historialLink_LinkClicked;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkOrchid;
            panel3.Controls.Add(label5);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(670, 99);
            panel3.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(136, 27);
            label5.Name = "label5";
            label5.Size = new Size(314, 50);
            label5.TabIndex = 0;
            label5.Text = "Cotizador Express";
            // 
            // panel4
            // 
            panel4.Location = new Point(2, 125);
            panel4.Name = "panel4";
            panel4.Size = new Size(605, 16);
            panel4.TabIndex = 14;
            panel4.Paint += panel4_Paint;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(117, 144);
            label6.Name = "label6";
            label6.Size = new Size(13, 20);
            label6.TabIndex = 15;
            label6.Text = "|";
            // 
            // panel5
            // 
            panel5.Location = new Point(2, 167);
            panel5.Name = "panel5";
            panel5.Size = new Size(605, 16);
            panel5.TabIndex = 16;
            panel5.Paint += panel5_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 669);
            Controls.Add(panel5);
            Controls.Add(label6);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(groupBox1);
            Controls.Add(panel3);
            Controls.Add(historialLink);
            Controls.Add(sellerIdLbl);
            Controls.Add(sellerNameLbl);
            Controls.Add(directionLbl);
            Controls.Add(storeNameLbl);
            Controls.Add(panel2);
            Controls.Add(finalPriceLbl);
            Controls.Add(label4);
            Controls.Add(quotationBtn);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton pantRB;
        private RadioButton shirtRB;
        private CheckBox sleeveShortCB;
        private CheckBox pantChupinCB;
        private Panel panel1;
        private Label unitsStockLbl;
        private Label label1;
        private GroupBox groupBox2;
        private RadioButton premiumRB;
        private RadioButton standartRB;
        private GroupBox groupBox3;
        private TextBox quantityText;
        private Label label3;
        private Label unitPriceLbl;
        private Label label2;
        private Button quotationBtn;
        private Label label4;
        private Label finalPriceLbl;
        private CheckBox maoCB;
        private Panel panel2;
        private Label storeNameLbl;
        private Label directionLbl;
        private Label sellerNameLbl;
        private Label sellerIdLbl;
        private LinkLabel historialLink;
        private Panel panel3;
        private Label label5;
        private Panel panel4;
        private Label label6;
        private Panel panel5;
    }
}
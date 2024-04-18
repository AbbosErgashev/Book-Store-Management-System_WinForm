namespace BookStoreManagmentSystem
{
    partial class Billing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billing));
            panel1 = new Panel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            TotalLbl = new Label();
            RefreshBtn = new Button();
            label2 = new Label();
            BooksBillDGV = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            panel8 = new Panel();
            pictureBox9 = new PictureBox();
            label14 = new Label();
            BooksListDGV = new DataGridView();
            label5 = new Label();
            ResetBtn = new Button();
            AddToBillBtn = new Button();
            Price = new TextBox();
            Qty = new TextBox();
            CNameTb = new TextBox();
            BNameTb = new TextBox();
            label10 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BooksBillDGV).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BooksListDGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(-5, 38);
            panel1.Name = "panel1";
            panel1.Size = new Size(373, 661);
            panel1.TabIndex = 23;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(18, 23);
            panel3.Name = "panel3";
            panel3.Size = new Size(230, 45);
            panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.address;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 3);
            label1.Name = "label1";
            label1.Size = new Size(100, 25);
            label1.TabIndex = 0;
            label1.Text = "Book Shop";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Controls.Add(TotalLbl);
            panel2.Controls.Add(RefreshBtn);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(BooksBillDGV);
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(BooksListDGV);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(ResetBtn);
            panel2.Controls.Add(AddToBillBtn);
            panel2.Controls.Add(Price);
            panel2.Controls.Add(Qty);
            panel2.Controls.Add(CNameTb);
            panel2.Controls.Add(BNameTb);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(377, 38);
            panel2.Name = "panel2";
            panel2.Size = new Size(798, 661);
            panel2.TabIndex = 22;
            // 
            // TotalLbl
            // 
            TotalLbl.AutoSize = true;
            TotalLbl.Location = new Point(698, 579);
            TotalLbl.Name = "TotalLbl";
            TotalLbl.Size = new Size(49, 25);
            TotalLbl.TabIndex = 26;
            TotalLbl.Text = "Total";
            // 
            // RefreshBtn
            // 
            RefreshBtn.Location = new Point(663, 607);
            RefreshBtn.Name = "RefreshBtn";
            RefreshBtn.Size = new Size(119, 47);
            RefreshBtn.TabIndex = 25;
            RefreshBtn.Text = "Print";
            RefreshBtn.UseVisualStyleBackColor = true;
            RefreshBtn.Click += RefreshBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 501);
            label2.Name = "label2";
            label2.Size = new Size(92, 25);
            label2.TabIndex = 22;
            label2.Text = "Books List";
            // 
            // BooksBillDGV
            // 
            BooksBillDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BooksBillDGV.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column4, Column3, Column5 });
            BooksBillDGV.Location = new Point(16, 329);
            BooksBillDGV.Name = "BooksBillDGV";
            BooksBillDGV.RowHeadersWidth = 51;
            BooksBillDGV.Size = new Size(677, 143);
            BooksBillDGV.TabIndex = 21;
            // 
            // Column1
            // 
            Column1.HeaderText = "Id";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Books";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Quantity";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Price";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Total";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // panel8
            // 
            panel8.Controls.Add(pictureBox9);
            panel8.Controls.Add(label14);
            panel8.Location = new Point(295, 6);
            panel8.Name = "panel8";
            panel8.Size = new Size(230, 45);
            panel8.TabIndex = 4;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.address;
            pictureBox9.Location = new Point(3, 3);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(45, 45);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 1;
            pictureBox9.TabStop = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(54, 3);
            label14.Name = "label14";
            label14.Size = new Size(100, 25);
            label14.TabIndex = 0;
            label14.Text = "Book Shop";
            // 
            // BooksListDGV
            // 
            BooksListDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BooksListDGV.Location = new Point(0, 541);
            BooksListDGV.Name = "BooksListDGV";
            BooksListDGV.RowHeadersWidth = 51;
            BooksListDGV.Size = new Size(626, 117);
            BooksListDGV.TabIndex = 20;
            BooksListDGV.CellContentClick += BooksListDGV_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(605, 291);
            label5.Name = "label5";
            label5.Size = new Size(88, 25);
            label5.TabIndex = 18;
            label5.Text = "Books Bill";
            // 
            // ResetBtn
            // 
            ResetBtn.Location = new Point(203, 248);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(119, 47);
            ResetBtn.TabIndex = 17;
            ResetBtn.Text = "Reset";
            ResetBtn.UseVisualStyleBackColor = true;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // AddToBillBtn
            // 
            AddToBillBtn.Location = new Point(41, 248);
            AddToBillBtn.Name = "AddToBillBtn";
            AddToBillBtn.Size = new Size(156, 47);
            AddToBillBtn.TabIndex = 13;
            AddToBillBtn.Text = "Add To Bill";
            AddToBillBtn.UseVisualStyleBackColor = true;
            AddToBillBtn.Click += AddToBillBtn_Click;
            // 
            // Price
            // 
            Price.Enabled = false;
            Price.Location = new Point(145, 205);
            Price.Name = "Price";
            Price.Size = new Size(177, 31);
            Price.TabIndex = 11;
            // 
            // Qty
            // 
            Qty.Location = new Point(145, 158);
            Qty.Name = "Qty";
            Qty.Size = new Size(177, 31);
            Qty.TabIndex = 10;
            // 
            // CNameTb
            // 
            CNameTb.Location = new Point(145, 117);
            CNameTb.Name = "CNameTb";
            CNameTb.Size = new Size(177, 31);
            CNameTb.TabIndex = 9;
            // 
            // BNameTb
            // 
            BNameTb.Enabled = false;
            BNameTb.Location = new Point(145, 69);
            BNameTb.Name = "BNameTb";
            BNameTb.Size = new Size(177, 31);
            BNameTb.TabIndex = 8;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(21, 117);
            label10.Name = "label10";
            label10.Size = new Size(108, 25);
            label10.TabIndex = 7;
            label10.Text = "Client Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 158);
            label8.Name = "label8";
            label8.Size = new Size(80, 25);
            label8.TabIndex = 5;
            label8.Text = "Quantity";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 208);
            label7.Name = "label7";
            label7.Size = new Size(49, 25);
            label7.TabIndex = 4;
            label7.Text = "Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 75);
            label6.Name = "label6";
            label6.Size = new Size(105, 25);
            label6.TabIndex = 2;
            label6.Text = "Book Name";
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // Billing
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1171, 737);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Billing";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Billing";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BooksBillDGV).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)BooksListDGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private Panel panel8;
        private PictureBox pictureBox9;
        private Label label14;
        private DataGridView BooksListDGV;
        private Label label5;
        private Button ResetBtn;
        private Button AddToBillBtn;
        private TextBox Price;
        private TextBox Qty;
        private TextBox CNameTb;
        private TextBox BNameTb;
        private Label label10;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label2;
        private DataGridView BooksBillDGV;
        private Button RefreshBtn;
        private Label TotalLbl;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column5;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}
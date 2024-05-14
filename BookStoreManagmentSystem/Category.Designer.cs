namespace BookStoreManagmentSystem
{
    partial class Category
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Category));
            AllSearchTbl = new TextBox();
            pictureBox6 = new PictureBox();
            label12 = new Label();
            panel8 = new Panel();
            CategoryDGV = new DataGridView();
            label5 = new Label();
            UpdateBtn = new Button();
            DeleteBtn = new Button();
            ResetBtn = new Button();
            RefreshBtn = new Button();
            SaveBtn = new Button();
            ctbl = new TextBox();
            label6 = new Label();
            panel1 = new Panel();
            panel9 = new Panel();
            pictureBox7 = new PictureBox();
            clbl = new Label();
            panel7 = new Panel();
            pictureBox5 = new PictureBox();
            llbl = new Label();
            panel6 = new Panel();
            pictureBox4 = new PictureBox();
            dlbl = new Label();
            panel5 = new Panel();
            pictureBox3 = new PictureBox();
            ulbl = new Label();
            panel4 = new Panel();
            pictureBox2 = new PictureBox();
            blbl = new Label();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CategoryDGV).BeginInit();
            panel1.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // AllSearchTbl
            // 
            AllSearchTbl.Location = new Point(224, 338);
            AllSearchTbl.Name = "AllSearchTbl";
            AllSearchTbl.Size = new Size(288, 31);
            AllSearchTbl.TabIndex = 21;
            AllSearchTbl.TextChanged += AllSearchTbl_TextChanged;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(3, 3);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(45, 45);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 1;
            pictureBox6.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label12.Location = new Point(54, 13);
            label12.Name = "label12";
            label12.Size = new Size(272, 25);
            label12.TabIndex = 0;
            label12.Text = "Book Shop Managment System";
            // 
            // panel8
            // 
            panel8.Controls.Add(pictureBox6);
            panel8.Controls.Add(label12);
            panel8.Location = new Point(264, 10);
            panel8.Name = "panel8";
            panel8.Size = new Size(339, 51);
            panel8.TabIndex = 3;
            // 
            // CategoryDGV
            // 
            CategoryDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CategoryDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            CategoryDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CategoryDGV.Location = new Point(0, 377);
            CategoryDGV.Name = "CategoryDGV";
            CategoryDGV.RowHeadersWidth = 51;
            CategoryDGV.Size = new Size(831, 300);
            CategoryDGV.TabIndex = 20;
            CategoryDGV.CellContentClick += CategoryDGV_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 342);
            label5.Name = "label5";
            label5.Size = new Size(127, 25);
            label5.TabIndex = 18;
            label5.Text = "Categories List";
            // 
            // UpdateBtn
            // 
            UpdateBtn.Location = new Point(537, 137);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(145, 46);
            UpdateBtn.TabIndex = 6;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Location = new Point(537, 189);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(145, 44);
            DeleteBtn.TabIndex = 7;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // ResetBtn
            // 
            ResetBtn.Location = new Point(537, 239);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(145, 47);
            ResetBtn.TabIndex = 8;
            ResetBtn.Text = "Reset";
            ResetBtn.UseVisualStyleBackColor = true;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // RefreshBtn
            // 
            RefreshBtn.Location = new Point(537, 337);
            RefreshBtn.Name = "RefreshBtn";
            RefreshBtn.Size = new Size(145, 34);
            RefreshBtn.TabIndex = 10;
            RefreshBtn.Text = "Refresh Filter";
            RefreshBtn.UseVisualStyleBackColor = true;
            RefreshBtn.Click += RefreshBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(537, 81);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(145, 50);
            SaveBtn.TabIndex = 5;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click_1;
            // 
            // ctbl
            // 
            ctbl.Location = new Point(137, 179);
            ctbl.Name = "ctbl";
            ctbl.Size = new Size(375, 31);
            ctbl.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(267, 150);
            label6.Name = "label6";
            label6.Size = new Size(136, 25);
            label6.TabIndex = 2;
            label6.Text = "Category Name";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(357, 677);
            panel1.TabIndex = 2;
            // 
            // panel9
            // 
            panel9.BackColor = Color.Gray;
            panel9.Controls.Add(pictureBox7);
            panel9.Controls.Add(clbl);
            panel9.Location = new Point(0, 326);
            panel9.Name = "panel9";
            panel9.Size = new Size(356, 54);
            panel9.TabIndex = 14;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(1, 0);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(42, 54);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 1;
            pictureBox7.TabStop = false;
            // 
            // clbl
            // 
            clbl.AutoSize = true;
            clbl.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            clbl.ForeColor = Color.White;
            clbl.Location = new Point(49, 15);
            clbl.Name = "clbl";
            clbl.Size = new Size(101, 25);
            clbl.TabIndex = 13;
            clbl.Text = "Categories";
            // 
            // panel7
            // 
            panel7.Controls.Add(pictureBox5);
            panel7.Controls.Add(llbl);
            panel7.Location = new Point(0, 380);
            panel7.Name = "panel7";
            panel7.Size = new Size(357, 54);
            panel7.TabIndex = 6;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(0, 0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(37, 51);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 1;
            pictureBox5.TabStop = false;
            // 
            // llbl
            // 
            llbl.AutoSize = true;
            llbl.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            llbl.Location = new Point(50, 14);
            llbl.Name = "llbl";
            llbl.Size = new Size(72, 25);
            llbl.TabIndex = 14;
            llbl.Text = "Logout";
            llbl.Click += llbl_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(pictureBox4);
            panel6.Controls.Add(dlbl);
            panel6.Location = new Point(0, 271);
            panel6.Name = "panel6";
            panel6.Size = new Size(356, 54);
            panel6.TabIndex = 4;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(1, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(42, 54);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // dlbl
            // 
            dlbl.AutoSize = true;
            dlbl.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            dlbl.Location = new Point(49, 15);
            dlbl.Name = "dlbl";
            dlbl.Size = new Size(101, 25);
            dlbl.TabIndex = 13;
            dlbl.Text = "Dashboard";
            dlbl.Click += dlbl_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(pictureBox3);
            panel5.Controls.Add(ulbl);
            panel5.Location = new Point(0, 217);
            panel5.Name = "panel5";
            panel5.Size = new Size(356, 54);
            panel5.TabIndex = 4;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(45, 48);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // ulbl
            // 
            ulbl.AutoSize = true;
            ulbl.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            ulbl.Location = new Point(51, 14);
            ulbl.Name = "ulbl";
            ulbl.Size = new Size(58, 25);
            ulbl.TabIndex = 12;
            ulbl.Text = "Users";
            ulbl.Click += ulbl_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Silver;
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(blbl);
            panel4.Location = new Point(0, 163);
            panel4.Name = "panel4";
            panel4.Size = new Size(357, 54);
            panel4.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(47, 53);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // blbl
            // 
            blbl.AutoSize = true;
            blbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            blbl.ForeColor = Color.Black;
            blbl.Location = new Point(54, 12);
            blbl.Name = "blbl";
            blbl.Size = new Size(68, 28);
            blbl.TabIndex = 11;
            blbl.Text = "Books";
            blbl.Click += blbl_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(0, 23);
            panel3.Name = "panel3";
            panel3.Size = new Size(357, 51);
            panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
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
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(54, 13);
            label1.Name = "label1";
            label1.Size = new Size(272, 25);
            label1.TabIndex = 0;
            label1.Text = "Book Shop Managment System";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(AllSearchTbl);
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(CategoryDGV);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(UpdateBtn);
            panel2.Controls.Add(DeleteBtn);
            panel2.Controls.Add(ResetBtn);
            panel2.Controls.Add(RefreshBtn);
            panel2.Controls.Add(SaveBtn);
            panel2.Controls.Add(ctbl);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(358, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(831, 677);
            panel2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(154, 340);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 22;
            label2.Text = "Search";
            // 
            // Category
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Blue;
            ClientSize = new Size(1193, 684);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Category";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Category";
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CategoryDGV).EndInit();
            panel1.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox AllSearchTbl;
        private PictureBox pictureBox6;
        private Label label12;
        private Panel panel8;
        private DataGridView CategoryDGV;
        private Label label5;
        private Button UpdateBtn;
        private Button DeleteBtn;
        private Button ResetBtn;
        private Button RefreshBtn;
        private Button SaveBtn;
        private TextBox ctbl;
        private Label label6;
        private Panel panel1;
        private Panel panel9;
        private PictureBox pictureBox7;
        private Label clbl;
        private Panel panel7;
        private PictureBox pictureBox5;
        private Label llbl;
        private Panel panel6;
        private PictureBox pictureBox4;
        private Label dlbl;
        private Panel panel5;
        private PictureBox pictureBox3;
        private Label ulbl;
        private Panel panel4;
        private PictureBox pictureBox2;
        private Label blbl;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private Label label2;
    }
}
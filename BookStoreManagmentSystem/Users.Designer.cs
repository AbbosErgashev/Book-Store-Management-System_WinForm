namespace BookStoreManagmentSystem
{
    partial class Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            panel2 = new Panel();
            button1 = new Button();
            label11 = new Label();
            SearchAllTbl = new TextBox();
            panel8 = new Panel();
            pictureBox6 = new PictureBox();
            label12 = new Label();
            UsersDGV = new DataGridView();
            label5 = new Label();
            UpdateBtn = new Button();
            DeleteBtn = new Button();
            ResetBtn = new Button();
            SaveBtn = new Button();
            UPassword = new TextBox();
            UAddress = new TextBox();
            UPhone = new TextBox();
            UName = new TextBox();
            label10 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel7 = new Panel();
            pictureBox5 = new PictureBox();
            label9 = new Label();
            panel6 = new Panel();
            pictureBox4 = new PictureBox();
            label4 = new Label();
            panel5 = new Panel();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            panel4 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            panel2.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UsersDGV).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(SearchAllTbl);
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(UsersDGV);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(UpdateBtn);
            panel2.Controls.Add(DeleteBtn);
            panel2.Controls.Add(ResetBtn);
            panel2.Controls.Add(SaveBtn);
            panel2.Controls.Add(UPassword);
            panel2.Controls.Add(UAddress);
            panel2.Controls.Add(UPhone);
            panel2.Controls.Add(UName);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(369, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(820, 675);
            panel2.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(592, 359);
            button1.Name = "button1";
            button1.Size = new Size(167, 37);
            button1.TabIndex = 24;
            button1.Text = "Reset Filter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(3, 365);
            label11.Name = "label11";
            label11.Size = new Size(194, 25);
            label11.TabIndex = 23;
            label11.Text = "Search by All Members";
            // 
            // SearchAllTbl
            // 
            SearchAllTbl.Location = new Point(196, 362);
            SearchAllTbl.Name = "SearchAllTbl";
            SearchAllTbl.Size = new Size(390, 31);
            SearchAllTbl.TabIndex = 22;
            SearchAllTbl.TextChanged += SearchAllTbl_TextChanged;
            // 
            // panel8
            // 
            panel8.Controls.Add(pictureBox6);
            panel8.Controls.Add(label12);
            panel8.Location = new Point(247, 23);
            panel8.Name = "panel8";
            panel8.Size = new Size(339, 51);
            panel8.TabIndex = 21;
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
            // UsersDGV
            // 
            UsersDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            UsersDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            UsersDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UsersDGV.Location = new Point(0, 399);
            UsersDGV.Name = "UsersDGV";
            UsersDGV.RowHeadersWidth = 51;
            UsersDGV.Size = new Size(820, 276);
            UsersDGV.TabIndex = 20;
            UsersDGV.CellContentClick += UsersDGV_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(339, 331);
            label5.Name = "label5";
            label5.Size = new Size(93, 28);
            label5.TabIndex = 18;
            label5.Text = "Users List";
            // 
            // UpdateBtn
            // 
            UpdateBtn.Location = new Point(648, 157);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(111, 43);
            UpdateBtn.TabIndex = 6;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Location = new Point(648, 216);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(111, 44);
            DeleteBtn.TabIndex = 7;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // ResetBtn
            // 
            ResetBtn.Location = new Point(648, 267);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(111, 44);
            ResetBtn.TabIndex = 8;
            ResetBtn.Text = "Reset";
            ResetBtn.UseVisualStyleBackColor = true;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(648, 97);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(111, 44);
            SaveBtn.TabIndex = 5;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // UPassword
            // 
            UPassword.Location = new Point(196, 275);
            UPassword.Name = "UPassword";
            UPassword.Size = new Size(390, 31);
            UPassword.TabIndex = 3;
            // 
            // UAddress
            // 
            UAddress.Location = new Point(196, 216);
            UAddress.Name = "UAddress";
            UAddress.Size = new Size(390, 31);
            UAddress.TabIndex = 2;
            // 
            // UPhone
            // 
            UPhone.Location = new Point(196, 153);
            UPhone.Name = "UPhone";
            UPhone.Size = new Size(390, 31);
            UPhone.TabIndex = 1;
            // 
            // UName
            // 
            UName.Location = new Point(196, 100);
            UName.Name = "UName";
            UName.Size = new Size(390, 31);
            UName.TabIndex = 0;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(92, 157);
            label10.Name = "label10";
            label10.Size = new Size(62, 25);
            label10.TabIndex = 7;
            label10.Text = "Phone";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(92, 219);
            label8.Name = "label8";
            label8.Size = new Size(77, 25);
            label8.TabIndex = 5;
            label8.Text = "Address";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(92, 281);
            label7.Name = "label7";
            label7.Size = new Size(87, 25);
            label7.TabIndex = 4;
            label7.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(92, 103);
            label6.Name = "label6";
            label6.Size = new Size(99, 25);
            label6.TabIndex = 2;
            label6.Text = "User Name";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Location = new Point(5, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(368, 676);
            panel1.TabIndex = 21;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(0, 27);
            panel3.Name = "panel3";
            panel3.Size = new Size(346, 51);
            panel3.TabIndex = 3;
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
            // panel7
            // 
            panel7.Controls.Add(pictureBox5);
            panel7.Controls.Add(label9);
            panel7.Location = new Point(0, 307);
            panel7.Name = "panel7";
            panel7.Size = new Size(368, 54);
            panel7.TabIndex = 5;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(10, 0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(37, 51);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 23;
            pictureBox5.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label9.Location = new Point(57, 15);
            label9.Name = "label9";
            label9.Size = new Size(72, 25);
            label9.TabIndex = 0;
            label9.Text = "Logout";
            label9.Click += label9_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(pictureBox4);
            panel6.Controls.Add(label4);
            panel6.Location = new Point(0, 253);
            panel6.Name = "panel6";
            panel6.Size = new Size(368, 54);
            panel6.TabIndex = 4;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(7, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(42, 54);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 24;
            pictureBox4.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label4.Location = new Point(55, 16);
            label4.Name = "label4";
            label4.Size = new Size(101, 25);
            label4.TabIndex = 0;
            label4.Text = "Dashboard";
            label4.Click += label4_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Gray;
            panel5.Controls.Add(label3);
            panel5.Controls.Add(pictureBox3);
            panel5.Location = new Point(0, 199);
            panel5.Name = "panel5";
            panel5.Size = new Size(368, 54);
            panel5.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(57, 14);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 0;
            label3.Text = "Users";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(45, 48);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 25;
            pictureBox3.TabStop = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(0, 145);
            panel4.Name = "panel4";
            panel4.Size = new Size(368, 54);
            panel4.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(47, 53);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label2.Location = new Point(57, 15);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 0;
            label2.Text = "Books";
            label2.Click += label2_Click;
            // 
            // Users
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Blue;
            ClientSize = new Size(1193, 684);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Users";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Users";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)UsersDGV).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private DataGridView UsersDGV;
        private Label label5;
        private Button UpdateBtn;
        private Button DeleteBtn;
        private Button ResetBtn;
        private Button SaveBtn;
        private TextBox UPassword;
        private TextBox UAddress;
        private TextBox UPhone;
        private TextBox UName;
        private Label label10;
        private Label label8;
        private Label label7;
        private Label label6;
        private Panel panel1;
        private Panel panel6;
        private Label label4;
        private Panel panel5;
        private Label label3;
        private Panel panel4;
        private Label label2;
        private Panel panel7;
        private Label label9;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel8;
        private PictureBox pictureBox6;
        private Label label12;
        private PictureBox pictureBox2;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Label label11;
        private TextBox SearchAllTbl;
        private Button button1;
    }
}
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
            panel2 = new Panel();
            panel8 = new Panel();
            pictureBox9 = new PictureBox();
            label14 = new Label();
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
            panel7 = new Panel();
            pictureBox5 = new PictureBox();
            label9 = new Label();
            panel6 = new Panel();
            pictureBox4 = new PictureBox();
            label4 = new Label();
            panel5 = new Panel();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            panel4 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UsersDGV).BeginInit();
            panel1.SuspendLayout();
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
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
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
            panel2.Location = new Point(394, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(798, 661);
            panel2.TabIndex = 2;
            // 
            // panel8
            // 
            panel8.Controls.Add(pictureBox9);
            panel8.Controls.Add(label14);
            panel8.Location = new Point(292, 23);
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
            // UsersDGV
            // 
            UsersDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UsersDGV.Location = new Point(0, 403);
            UsersDGV.Name = "UsersDGV";
            UsersDGV.RowHeadersWidth = 51;
            UsersDGV.Size = new Size(801, 255);
            UsersDGV.TabIndex = 20;
            UsersDGV.CellContentClick += UsersDGV_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(316, 350);
            label5.Name = "label5";
            label5.Size = new Size(86, 25);
            label5.TabIndex = 18;
            label5.Text = "Users List";
            // 
            // UpdateBtn
            // 
            UpdateBtn.Location = new Point(466, 150);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(94, 33);
            UpdateBtn.TabIndex = 17;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Location = new Point(466, 204);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(94, 29);
            DeleteBtn.TabIndex = 16;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // ResetBtn
            // 
            ResetBtn.Location = new Point(466, 265);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(94, 29);
            ResetBtn.TabIndex = 15;
            ResetBtn.Text = "Reset";
            ResetBtn.UseVisualStyleBackColor = true;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(466, 94);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(94, 29);
            SaveBtn.TabIndex = 13;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // UPassword
            // 
            UPassword.Location = new Point(215, 274);
            UPassword.Name = "UPassword";
            UPassword.Size = new Size(177, 31);
            UPassword.TabIndex = 11;
            // 
            // UAddress
            // 
            UAddress.Location = new Point(215, 217);
            UAddress.Name = "UAddress";
            UAddress.Size = new Size(177, 31);
            UAddress.TabIndex = 10;
            // 
            // UPhone
            // 
            UPhone.Location = new Point(215, 152);
            UPhone.Name = "UPhone";
            UPhone.Size = new Size(177, 31);
            UPhone.TabIndex = 9;
            // 
            // UName
            // 
            UName.Location = new Point(215, 91);
            UName.Name = "UName";
            UName.Size = new Size(177, 31);
            UName.TabIndex = 8;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(70, 158);
            label10.Name = "label10";
            label10.Size = new Size(62, 25);
            label10.TabIndex = 7;
            label10.Text = "Phone";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(70, 217);
            label8.Name = "label8";
            label8.Size = new Size(77, 25);
            label8.TabIndex = 5;
            label8.Text = "Address";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(70, 280);
            label7.Name = "label7";
            label7.Size = new Size(87, 25);
            label7.TabIndex = 4;
            label7.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(70, 94);
            label6.Name = "label6";
            label6.Size = new Size(99, 25);
            label6.TabIndex = 2;
            label6.Text = "User Name";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(373, 661);
            panel1.TabIndex = 21;
            // 
            // panel7
            // 
            panel7.Controls.Add(pictureBox5);
            panel7.Controls.Add(label9);
            panel7.Location = new Point(21, 340);
            panel7.Name = "panel7";
            panel7.Size = new Size(303, 54);
            panel7.TabIndex = 5;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.address1;
            pictureBox5.Location = new Point(3, 10);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(44, 41);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 1;
            pictureBox5.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(74, 10);
            label9.Name = "label9";
            label9.Size = new Size(69, 25);
            label9.TabIndex = 0;
            label9.Text = "Logout";
            // 
            // panel6
            // 
            panel6.Controls.Add(pictureBox4);
            panel6.Controls.Add(label4);
            panel6.Location = new Point(24, 265);
            panel6.Name = "panel6";
            panel6.Size = new Size(303, 54);
            panel6.TabIndex = 4;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.address1;
            pictureBox4.Location = new Point(3, 10);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(44, 41);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(74, 10);
            label4.Name = "label4";
            label4.Size = new Size(100, 25);
            label4.TabIndex = 0;
            label4.Text = "Dashboard";
            // 
            // panel5
            // 
            panel5.Controls.Add(pictureBox3);
            panel5.Controls.Add(label3);
            panel5.Location = new Point(21, 180);
            panel5.Name = "panel5";
            panel5.Size = new Size(303, 54);
            panel5.TabIndex = 4;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.address1;
            pictureBox3.Location = new Point(3, 10);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(44, 41);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(74, 10);
            label3.Name = "label3";
            label3.Size = new Size(55, 25);
            label3.TabIndex = 0;
            label3.Text = "Users";
            // 
            // panel4
            // 
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(18, 107);
            panel4.Name = "panel4";
            panel4.Size = new Size(303, 54);
            panel4.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.address1;
            pictureBox2.Location = new Point(3, 10);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(44, 41);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 10);
            label2.Name = "label2";
            label2.Size = new Size(61, 25);
            label2.TabIndex = 0;
            label2.Text = "Books";
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
            // Users
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1189, 703);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)UsersDGV).EndInit();
            panel1.ResumeLayout(false);
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
        private PictureBox pictureBox4;
        private Label label4;
        private Panel panel5;
        private PictureBox pictureBox3;
        private Label label3;
        private Panel panel4;
        private PictureBox pictureBox2;
        private Label label2;
        private Panel panel3;
        private Label label1;
        private Panel panel7;
        private PictureBox pictureBox5;
        private Label label9;
        private Panel panel8;
        private PictureBox pictureBox9;
        private Label label14;
        private PictureBox pictureBox1;
    }
}
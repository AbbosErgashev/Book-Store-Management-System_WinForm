namespace BookStoreManagmentSystem
{
    partial class AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            panel2 = new Panel();
            AdminLink = new Label();
            LoginBtn = new Button();
            UPasswordTb = new TextBox();
            label4 = new Label();
            panel8 = new Panel();
            pictureBox9 = new PictureBox();
            label14 = new Label();
            panel2.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Controls.Add(AdminLink);
            panel2.Controls.Add(LoginBtn);
            panel2.Controls.Add(UPasswordTb);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(panel8);
            panel2.Location = new Point(5, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(628, 322);
            panel2.TabIndex = 2;
            // 
            // AdminLink
            // 
            AdminLink.AutoSize = true;
            AdminLink.BackColor = Color.Transparent;
            AdminLink.Cursor = Cursors.Hand;
            AdminLink.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            AdminLink.Location = new Point(209, 259);
            AdminLink.Name = "AdminLink";
            AdminLink.Size = new Size(204, 28);
            AdminLink.TabIndex = 2;
            AdminLink.Text = "Return as Login Page";
            AdminLink.Click += AdminLink_Click;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.Transparent;
            LoginBtn.Cursor = Cursors.Hand;
            LoginBtn.Location = new Point(259, 175);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(109, 47);
            LoginBtn.TabIndex = 1;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // UPasswordTb
            // 
            UPasswordTb.Location = new Point(192, 105);
            UPasswordTb.Name = "UPasswordTb";
            UPasswordTb.PasswordChar = '*';
            UPasswordTb.Size = new Size(300, 31);
            UPasswordTb.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(103, 108);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 2;
            label4.Text = "Password";
            // 
            // panel8
            // 
            panel8.Controls.Add(pictureBox9);
            panel8.Controls.Add(label14);
            panel8.Location = new Point(137, 16);
            panel8.Name = "panel8";
            panel8.Size = new Size(372, 50);
            panel8.TabIndex = 5;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(3, 0);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(45, 42);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 1;
            pictureBox9.TabStop = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label14.Location = new Point(55, 9);
            label14.Name = "label14";
            label14.Size = new Size(300, 28);
            label14.TabIndex = 0;
            label14.Text = "Book Shop Managment System";
            // 
            // AdminLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Blue;
            ClientSize = new Size(637, 332);
            Controls.Add(panel2);
            MaximizeBox = false;
            Name = "AdminLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminLogin";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label AdminLink;
        private Button LoginBtn;
        private TextBox UPasswordTb;
        private Label label4;
        private Panel panel8;
        private PictureBox pictureBox9;
        private Label label14;
    }
}
namespace BookStoreManagmentSystem
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            panel1 = new Panel();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(273, 37);
            label1.Name = "label1";
            label1.Size = new Size(263, 25);
            label1.TabIndex = 0;
            label1.Text = "67. Kitoblarni Ombordan Sotish";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(307, 105);
            label2.Name = "label2";
            label2.Size = new Size(147, 25);
            label2.TabIndex = 1;
            label2.Text = "Berilganlar Bazasi";
            // 
            // button1
            // 
            button1.Location = new Point(625, 317);
            button1.Name = "button1";
            button1.Size = new Size(137, 64);
            button1.TabIndex = 2;
            button1.Text = "Next";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 413);
            panel1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(100, 369);
            label3.Name = "label3";
            label3.Size = new Size(84, 25);
            label3.TabIndex = 3;
            label3.Text = "Tekshirdi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(100, 317);
            label4.Name = "label4";
            label4.Size = new Size(203, 25);
            label4.TabIndex = 4;
            label4.Text = "Bajardi: Ergashev Abbos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "Kirish";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Panel panel1;
        private Label label4;
        private Label label3;
    }
}

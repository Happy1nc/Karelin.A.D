
namespace WinFormsApp.Pizza
{
    partial class FormStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStart));
            this.backgroudStart = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panRightBorder = new System.Windows.Forms.Panel();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panTopBorder = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.backgroudStart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panTopBorder.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroudStart
            // 
            this.backgroudStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(224)))));
            this.backgroudStart.Controls.Add(this.pictureBox1);
            this.backgroudStart.Controls.Add(this.panel3);
            this.backgroudStart.Controls.Add(this.panRightBorder);
            this.backgroudStart.Controls.Add(this.buttonNext);
            this.backgroudStart.Controls.Add(this.buttonHelp);
            this.backgroudStart.Controls.Add(this.buttonExit);
            this.backgroudStart.Location = new System.Drawing.Point(-1, 26);
            this.backgroudStart.Name = "backgroudStart";
            this.backgroudStart.Size = new System.Drawing.Size(674, 290);
            this.backgroudStart.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinFormsApp.Pizza.Properties.Resources.Logo4Pizza;
            this.pictureBox1.Location = new System.Drawing.Point(172, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(321, 242);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gold;
            this.panel3.Location = new System.Drawing.Point(-2, -18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 333);
            this.panel3.TabIndex = 32;
            // 
            // panRightBorder
            // 
            this.panRightBorder.BackColor = System.Drawing.Color.Gold;
            this.panRightBorder.Location = new System.Drawing.Point(637, -26);
            this.panRightBorder.Name = "panRightBorder";
            this.panRightBorder.Size = new System.Drawing.Size(10, 333);
            this.panRightBorder.TabIndex = 31;
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.Salmon;
            this.buttonNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNext.FlatAppearance.BorderSize = 0;
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext.Font = new System.Drawing.Font("Segoe Script", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonNext.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonNext.Location = new System.Drawing.Point(499, 224);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(119, 41);
            this.buttonNext.TabIndex = 3;
            this.buttonNext.Text = "Далее";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.Color.Salmon;
            this.buttonHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHelp.FlatAppearance.BorderSize = 0;
            this.buttonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonHelp.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonHelp.Location = new System.Drawing.Point(521, 13);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(97, 30);
            this.buttonHelp.TabIndex = 2;
            this.buttonHelp.Text = "Справка";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Salmon;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Segoe Script", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonExit.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonExit.Location = new System.Drawing.Point(13, 224);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(119, 41);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // panTopBorder
            // 
            this.panTopBorder.BackColor = System.Drawing.Color.Gold;
            this.panTopBorder.Controls.Add(this.btnExit);
            this.panTopBorder.Controls.Add(this.btnHide);
            this.panTopBorder.Controls.Add(this.panel9);
            this.panTopBorder.Location = new System.Drawing.Point(-8, 0);
            this.panTopBorder.Name = "panTopBorder";
            this.panTopBorder.Size = new System.Drawing.Size(674, 28);
            this.panTopBorder.TabIndex = 32;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Tomato;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(617, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(28, 24);
            this.btnExit.TabIndex = 34;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHide
            // 
            this.btnHide.BackColor = System.Drawing.Color.Tomato;
            this.btnHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHide.Location = new System.Drawing.Point(1111, 2);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(28, 24);
            this.btnHide.TabIndex = 32;
            this.btnHide.Text = "—";
            this.btnHide.UseVisualStyleBackColor = false;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Gold;
            this.panel9.Location = new System.Drawing.Point(-23, 625);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1228, 30);
            this.panel9.TabIndex = 31;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-1, 313);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(674, 20);
            this.panel1.TabIndex = 33;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tomato;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1111, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 24);
            this.button1.TabIndex = 32;
            this.button1.Text = "—";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Tomato;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(1145, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 24);
            this.button2.TabIndex = 30;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.Location = new System.Drawing.Point(-23, 625);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1228, 30);
            this.panel2.TabIndex = 31;
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 322);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panTopBorder);
            this.Controls.Add(this.backgroudStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пиццерия \"Pizza\"";
            this.backgroudStart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panTopBorder.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel backgroudStart;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Panel panTopBorder;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panRightBorder;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


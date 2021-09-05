namespace Toy_store
{
    partial class FormMain
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
            this.buttonCount = new System.Windows.Forms.Button();
            this.checkBoxBear = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxCar = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxTrain = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxDuck = new System.Windows.Forms.CheckBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxCheque = new System.Windows.Forms.TextBox();
            this.buttonPay = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCount
            // 
            this.buttonCount.Location = new System.Drawing.Point(12, 443);
            this.buttonCount.Name = "buttonCount";
            this.buttonCount.Size = new System.Drawing.Size(328, 52);
            this.buttonCount.TabIndex = 0;
            this.buttonCount.Text = "Подсчитать стоимость покупок";
            this.buttonCount.UseVisualStyleBackColor = true;
            this.buttonCount.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // checkBoxBear
            // 
            this.checkBoxBear.AutoSize = true;
            this.checkBoxBear.Location = new System.Drawing.Point(33, 32);
            this.checkBoxBear.Name = "checkBoxBear";
            this.checkBoxBear.Size = new System.Drawing.Size(18, 17);
            this.checkBoxBear.TabIndex = 1;
            this.checkBoxBear.UseVisualStyleBackColor = true;
            this.checkBoxBear.CheckedChanged += new System.EventHandler(this.checkBoxBear_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "Медведь плюшевый  \r\n299 руб\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(721, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 34);
            this.label2.TabIndex = 7;
            this.label2.Text = "Грузовик пластмассовый\r\n499 руб\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBoxCar
            // 
            this.checkBoxCar.AutoSize = true;
            this.checkBoxCar.Location = new System.Drawing.Point(540, 32);
            this.checkBoxCar.Name = "checkBoxCar";
            this.checkBoxCar.Size = new System.Drawing.Size(18, 17);
            this.checkBoxCar.TabIndex = 5;
            this.checkBoxCar.UseVisualStyleBackColor = true;
            this.checkBoxCar.CheckedChanged += new System.EventHandler(this.checkBoxCar_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(721, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 51);
            this.label3.TabIndex = 10;
            this.label3.Text = "Конструктор детский\r\n \"Паровоз\"\r\n  449 руб\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBoxTrain
            // 
            this.checkBoxTrain.AutoSize = true;
            this.checkBoxTrain.Location = new System.Drawing.Point(540, 248);
            this.checkBoxTrain.Name = "checkBoxTrain";
            this.checkBoxTrain.Size = new System.Drawing.Size(18, 17);
            this.checkBoxTrain.TabIndex = 8;
            this.checkBoxTrain.UseVisualStyleBackColor = true;
            this.checkBoxTrain.CheckedChanged += new System.EventHandler(this.checkBoxTrain_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 34);
            this.label4.TabIndex = 13;
            this.label4.Text = "Каталка деревянная \"Утка\"\r\n159 руб\r\n";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBoxDuck
            // 
            this.checkBoxDuck.AutoSize = true;
            this.checkBoxDuck.Location = new System.Drawing.Point(33, 248);
            this.checkBoxDuck.Name = "checkBoxDuck";
            this.checkBoxDuck.Size = new System.Drawing.Size(18, 17);
            this.checkBoxDuck.TabIndex = 11;
            this.checkBoxDuck.UseVisualStyleBackColor = true;
            this.checkBoxDuck.CheckedChanged += new System.EventHandler(this.checkBoxDuck_CheckedChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Toy_store.Properties.Resources.f77c16b2c32c48011ca863f8312e2b7a;
            this.pictureBox4.Location = new System.Drawing.Point(57, 248);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(151, 151);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Toy_store.Properties.Resources.LH_e_0JGPlA;
            this.pictureBox3.Location = new System.Drawing.Point(564, 248);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(151, 151);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Toy_store.Properties.Resources.Mashina_Tyulypan_sredniy_156395_00;
            this.pictureBox2.Location = new System.Drawing.Point(564, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(151, 170);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Toy_store.Properties.Resources._40_15_4136_3;
            this.pictureBox1.Location = new System.Drawing.Point(57, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxCheque
            // 
            this.textBoxCheque.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCheque.Location = new System.Drawing.Point(539, 438);
            this.textBoxCheque.Multiline = true;
            this.textBoxCheque.Name = "textBoxCheque";
            this.textBoxCheque.Size = new System.Drawing.Size(233, 57);
            this.textBoxCheque.TabIndex = 14;
            this.textBoxCheque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxCheque.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // buttonPay
            // 
            this.buttonPay.Location = new System.Drawing.Point(791, 443);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(147, 52);
            this.buttonPay.TabIndex = 15;
            this.buttonPay.Text = "Оплатить";
            this.buttonPay.UseVisualStyleBackColor = true;
            this.buttonPay.Click += new System.EventHandler(this.buttonPay_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(539, 426);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Стоимость вашей корзины равна:";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(435, 443);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(98, 52);
            this.buttonSave.TabIndex = 17;
            this.buttonSave.Text = "Сохранить чек";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(950, 507);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonPay);
            this.Controls.Add(this.textBoxCheque);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.checkBoxDuck);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.checkBoxTrain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.checkBoxCar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkBoxBear);
            this.Controls.Add(this.buttonCount);
            this.Name = "FormMain";
            this.Text = "Магазин игрушек";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCount;
        private System.Windows.Forms.CheckBox checkBoxBear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox checkBoxCar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.CheckBox checkBoxTrain;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.CheckBox checkBoxDuck;
        private System.Windows.Forms.TextBox textBoxCheque;
        private System.Windows.Forms.Button buttonPay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSave;
    }
}
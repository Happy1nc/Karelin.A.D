namespace CafeStore
{
    partial class FirstWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstWindow));
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.cbJuiceOrange = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbJuiceApple = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.cbJuiceCarrot = new System.Windows.Forms.CheckBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.cbSandwichChicken = new System.Windows.Forms.CheckBox();
            this.cbSaladSummer = new System.Windows.Forms.CheckBox();
            this.cbFruits = new System.Windows.Forms.CheckBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.rbNoDiscount = new System.Windows.Forms.RadioButton();
            this.rbDiscount = new System.Windows.Forms.RadioButton();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.pbSaveCheck = new System.Windows.Forms.PictureBox();
            this.pbInfo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSaveCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(1, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(130, 95);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            this.pbLogo.UseWaitCursor = true;
            // 
            // cbJuiceOrange
            // 
            this.cbJuiceOrange.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbJuiceOrange.AutoSize = true;
            this.cbJuiceOrange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbJuiceOrange.Location = new System.Drawing.Point(12, 255);
            this.cbJuiceOrange.Name = "cbJuiceOrange";
            this.cbJuiceOrange.Size = new System.Drawing.Size(218, 19);
            this.cbJuiceOrange.TabIndex = 1;
            this.cbJuiceOrange.Text = "Апельсиновый Сок 200руб/400мл";
            this.cbJuiceOrange.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // cbJuiceApple
            // 
            this.cbJuiceApple.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbJuiceApple.AutoSize = true;
            this.cbJuiceApple.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbJuiceApple.Location = new System.Drawing.Point(236, 255);
            this.cbJuiceApple.Name = "cbJuiceApple";
            this.cbJuiceApple.Size = new System.Drawing.Size(192, 19);
            this.cbJuiceApple.TabIndex = 3;
            this.cbJuiceApple.Text = "Яблочный Сок 150руб/400мл";
            this.cbJuiceApple.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(236, 110);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(174, 139);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(463, 110);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(174, 139);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // cbJuiceCarrot
            // 
            this.cbJuiceCarrot.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbJuiceCarrot.AutoSize = true;
            this.cbJuiceCarrot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbJuiceCarrot.Location = new System.Drawing.Point(444, 255);
            this.cbJuiceCarrot.Name = "cbJuiceCarrot";
            this.cbJuiceCarrot.Size = new System.Drawing.Size(201, 19);
            this.cbJuiceCarrot.TabIndex = 6;
            this.cbJuiceCarrot.Text = "Морковный Сок 170руб/400мл";
            this.cbJuiceCarrot.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(12, 310);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(174, 139);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(236, 310);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(174, 139);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(463, 310);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(174, 139);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 9;
            this.pictureBox6.TabStop = false;
            // 
            // cbSandwichChicken
            // 
            this.cbSandwichChicken.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbSandwichChicken.AutoSize = true;
            this.cbSandwichChicken.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbSandwichChicken.Location = new System.Drawing.Point(13, 456);
            this.cbSandwichChicken.Name = "cbSandwichChicken";
            this.cbSandwichChicken.Size = new System.Drawing.Size(202, 19);
            this.cbSandwichChicken.TabIndex = 10;
            this.cbSandwichChicken.Text = "Сендвич с курицей 150руб/1шт";
            this.cbSandwichChicken.UseVisualStyleBackColor = true;
            // 
            // cbSaladSummer
            // 
            this.cbSaladSummer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbSaladSummer.AutoSize = true;
            this.cbSaladSummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbSaladSummer.Location = new System.Drawing.Point(236, 456);
            this.cbSaladSummer.Name = "cbSaladSummer";
            this.cbSaladSummer.Size = new System.Drawing.Size(187, 19);
            this.cbSaladSummer.TabIndex = 11;
            this.cbSaladSummer.Text = "Салат Летний 200руб/250гр";
            this.cbSaladSummer.UseVisualStyleBackColor = true;
            // 
            // cbFruits
            // 
            this.cbFruits.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbFruits.AutoSize = true;
            this.cbFruits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbFruits.Location = new System.Drawing.Point(442, 456);
            this.cbFruits.Name = "cbFruits";
            this.cbFruits.Size = new System.Drawing.Size(220, 19);
            this.cbFruits.TabIndex = 12;
            this.cbFruits.Text = "Фруктовая тарелка 350руб/400гр";
            this.cbFruits.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCalculate.Location = new System.Drawing.Point(12, 497);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(119, 48);
            this.btnCalculate.TabIndex = 13;
            this.btnCalculate.Text = "Посчитать";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // rbNoDiscount
            // 
            this.rbNoDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbNoDiscount.AutoSize = true;
            this.rbNoDiscount.Checked = true;
            this.rbNoDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbNoDiscount.Location = new System.Drawing.Point(147, 495);
            this.rbNoDiscount.Name = "rbNoDiscount";
            this.rbNoDiscount.Size = new System.Drawing.Size(98, 19);
            this.rbNoDiscount.TabIndex = 14;
            this.rbNoDiscount.TabStop = true;
            this.rbNoDiscount.Text = "Без скидки";
            this.rbNoDiscount.UseVisualStyleBackColor = true;
            // 
            // rbDiscount
            // 
            this.rbDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbDiscount.AutoSize = true;
            this.rbDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbDiscount.Location = new System.Drawing.Point(147, 519);
            this.rbDiscount.Name = "rbDiscount";
            this.rbDiscount.Size = new System.Drawing.Size(104, 19);
            this.rbDiscount.TabIndex = 15;
            this.rbDiscount.Text = "Скидка 10%";
            this.rbDiscount.UseVisualStyleBackColor = true;
            // 
            // tbResult
            // 
            this.tbResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbResult.Location = new System.Drawing.Point(291, 508);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(119, 29);
            this.tbResult.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 492);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Сумма заказа:";
            // 
            // btnPay
            // 
            this.btnPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPay.Location = new System.Drawing.Point(518, 493);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(119, 48);
            this.btnPay.TabIndex = 18;
            this.btnPay.Text = "Оплатить";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // pbSaveCheck
            // 
            this.pbSaveCheck.Image = ((System.Drawing.Image)(resources.GetObject("pbSaveCheck.Image")));
            this.pbSaveCheck.Location = new System.Drawing.Point(416, 508);
            this.pbSaveCheck.Name = "pbSaveCheck";
            this.pbSaveCheck.Size = new System.Drawing.Size(29, 30);
            this.pbSaveCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSaveCheck.TabIndex = 19;
            this.pbSaveCheck.TabStop = false;
            this.pbSaveCheck.Click += new System.EventHandler(this.pbSaveCheck_Click);
            // 
            // pbInfo
            // 
            this.pbInfo.Image = ((System.Drawing.Image)(resources.GetObject("pbInfo.Image")));
            this.pbInfo.Location = new System.Drawing.Point(592, 12);
            this.pbInfo.Name = "pbInfo";
            this.pbInfo.Size = new System.Drawing.Size(45, 48);
            this.pbInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbInfo.TabIndex = 20;
            this.pbInfo.TabStop = false;
            this.pbInfo.Click += new System.EventHandler(this.pbInfo_Click);
            // 
            // FirstWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(699, 556);
            this.Controls.Add(this.pbInfo);
            this.Controls.Add(this.pbSaveCheck);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.rbDiscount);
            this.Controls.Add(this.rbNoDiscount);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.cbFruits);
            this.Controls.Add(this.cbSaladSummer);
            this.Controls.Add(this.cbSandwichChicken);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.cbJuiceCarrot);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.cbJuiceApple);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbJuiceOrange);
            this.Controls.Add(this.pbLogo);
            this.Name = "FirstWindow";
            this.Text = "Juice Bar";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSaveCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.CheckBox cbJuiceOrange;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox cbJuiceApple;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.CheckBox cbJuiceCarrot;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.CheckBox cbSandwichChicken;
        private System.Windows.Forms.CheckBox cbSaladSummer;
        private System.Windows.Forms.CheckBox cbFruits;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.RadioButton rbNoDiscount;
        private System.Windows.Forms.RadioButton rbDiscount;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.PictureBox pbSaveCheck;
        private System.Windows.Forms.PictureBox pbInfo;
    }
}


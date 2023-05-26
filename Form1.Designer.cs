namespace Temperature_Converter_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            FtoCin = new TextBox();
            FtoCout = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            FtoKout = new TextBox();
            FtoKin = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            CtoKout = new TextBox();
            CtoKin = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            CtoFout = new TextBox();
            CtoFin = new TextBox();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            KtoFout = new TextBox();
            KtoFin = new TextBox();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            KtoCout = new TextBox();
            KtoCin = new TextBox();
            SuspendLayout();
            // 
            // FtoCin
            // 
            FtoCin.Location = new Point(108, 74);
            FtoCin.Name = "FtoCin";
            FtoCin.Size = new Size(125, 27);
            FtoCin.TabIndex = 1;
            FtoCin.TextChanged += FtoCin_TextChanged;
            // 
            // FtoCout
            // 
            FtoCout.Location = new Point(254, 74);
            FtoCout.Name = "FtoCout";
            FtoCout.ReadOnly = true;
            FtoCout.Size = new Size(125, 27);
            FtoCout.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(108, 32);
            label2.Name = "label2";
            label2.Size = new Size(171, 20);
            label2.TabIndex = 10;
            label2.Text = "FARENHEIT to CELSIUS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(407, 77);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 11;
            label1.Text = "RESULT";
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(27, 55);
            label3.Name = "label3";
            label3.Size = new Size(75, 46);
            label3.TabIndex = 12;
            label3.Text = "INPUT °F HERE";
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(27, 131);
            label4.Name = "label4";
            label4.Size = new Size(75, 46);
            label4.TabIndex = 17;
            label4.Text = "INPUT °F HERE";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(407, 153);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 16;
            label5.Text = "RESULT";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(108, 117);
            label6.Name = "label6";
            label6.Size = new Size(167, 20);
            label6.TabIndex = 15;
            label6.Text = "FARENHEIT to KELVIN";
            // 
            // FtoKout
            // 
            FtoKout.Location = new Point(254, 150);
            FtoKout.Name = "FtoKout";
            FtoKout.ReadOnly = true;
            FtoKout.Size = new Size(125, 27);
            FtoKout.TabIndex = 14;
            // 
            // FtoKin
            // 
            FtoKin.Location = new Point(108, 150);
            FtoKin.Name = "FtoKin";
            FtoKin.Size = new Size(125, 27);
            FtoKin.TabIndex = 13;
            FtoKin.TextChanged += FtoKin_TextChanged;
            // 
            // label7
            // 
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(26, 286);
            label7.Name = "label7";
            label7.Size = new Size(75, 46);
            label7.TabIndex = 27;
            label7.Text = "INPUT °C HERE";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(406, 308);
            label8.Name = "label8";
            label8.Size = new Size(63, 20);
            label8.TabIndex = 26;
            label8.Text = "RESULT";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(107, 272);
            label9.Name = "label9";
            label9.Size = new Size(142, 20);
            label9.TabIndex = 25;
            label9.Text = "CELSIUS to KELVIN";
            // 
            // CtoKout
            // 
            CtoKout.Location = new Point(253, 305);
            CtoKout.Name = "CtoKout";
            CtoKout.ReadOnly = true;
            CtoKout.Size = new Size(125, 27);
            CtoKout.TabIndex = 24;
            // 
            // CtoKin
            // 
            CtoKin.Location = new Point(107, 305);
            CtoKin.Name = "CtoKin";
            CtoKin.Size = new Size(125, 27);
            CtoKin.TabIndex = 23;
            CtoKin.TextChanged += CtoKin_TextChanged;
            // 
            // label10
            // 
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(26, 210);
            label10.Name = "label10";
            label10.Size = new Size(75, 46);
            label10.TabIndex = 22;
            label10.Text = "INPUT °C HERE";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(406, 232);
            label11.Name = "label11";
            label11.Size = new Size(63, 20);
            label11.TabIndex = 21;
            label11.Text = "RESULT";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(107, 194);
            label12.Name = "label12";
            label12.Size = new Size(171, 20);
            label12.TabIndex = 20;
            label12.Text = "CELSIUS to FARENHEIT";
            // 
            // CtoFout
            // 
            CtoFout.Location = new Point(253, 229);
            CtoFout.Name = "CtoFout";
            CtoFout.ReadOnly = true;
            CtoFout.Size = new Size(125, 27);
            CtoFout.TabIndex = 19;
            // 
            // CtoFin
            // 
            CtoFin.Location = new Point(107, 229);
            CtoFin.Name = "CtoFin";
            CtoFin.Size = new Size(125, 27);
            CtoFin.TabIndex = 18;
            CtoFin.TextChanged += CtoFin_TextChanged;
            // 
            // label13
            // 
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(27, 434);
            label13.Name = "label13";
            label13.Size = new Size(75, 46);
            label13.TabIndex = 37;
            label13.Text = "INPUT °K HERE";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(407, 456);
            label14.Name = "label14";
            label14.Size = new Size(63, 20);
            label14.TabIndex = 36;
            label14.Text = "RESULT";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.Black;
            label15.Location = new Point(108, 420);
            label15.Name = "label15";
            label15.Size = new Size(172, 20);
            label15.TabIndex = 35;
            label15.Text = "KELVIN TO FARENHEIT";
            // 
            // KtoFout
            // 
            KtoFout.Location = new Point(254, 453);
            KtoFout.Name = "KtoFout";
            KtoFout.ReadOnly = true;
            KtoFout.Size = new Size(125, 27);
            KtoFout.TabIndex = 34;
            // 
            // KtoFin
            // 
            KtoFin.Location = new Point(108, 453);
            KtoFin.Name = "KtoFin";
            KtoFin.Size = new Size(125, 27);
            KtoFin.TabIndex = 33;
            KtoFin.TextChanged += KtoFin_TextChanged;
            // 
            // label16
            // 
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(27, 358);
            label16.Name = "label16";
            label16.Size = new Size(75, 46);
            label16.TabIndex = 32;
            label16.Text = "INPUT °K HERE";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(407, 380);
            label17.Name = "label17";
            label17.Size = new Size(63, 20);
            label17.TabIndex = 31;
            label17.Text = "RESULT";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.Transparent;
            label18.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ForeColor = Color.Black;
            label18.Location = new Point(108, 344);
            label18.Name = "label18";
            label18.Size = new Size(142, 20);
            label18.TabIndex = 30;
            label18.Text = "KELVIN to CELSIUS";
            // 
            // KtoCout
            // 
            KtoCout.Location = new Point(254, 377);
            KtoCout.Name = "KtoCout";
            KtoCout.ReadOnly = true;
            KtoCout.Size = new Size(125, 27);
            KtoCout.TabIndex = 29;
            // 
            // KtoCin
            // 
            KtoCin.Location = new Point(108, 377);
            KtoCin.Name = "KtoCin";
            KtoCin.Size = new Size(125, 27);
            KtoCin.TabIndex = 28;
            KtoCin.TextChanged += KtoCin_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(490, 518);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(KtoFout);
            Controls.Add(KtoFin);
            Controls.Add(label16);
            Controls.Add(label17);
            Controls.Add(label18);
            Controls.Add(KtoCout);
            Controls.Add(KtoCin);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(CtoKout);
            Controls.Add(CtoKin);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(CtoFout);
            Controls.Add(CtoFin);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(FtoKout);
            Controls.Add(FtoKin);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(FtoCout);
            Controls.Add(FtoCin);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Temperature Converter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox FtoCin;
        private TextBox FtoCout;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox FtoKout;
        private TextBox FtoKin;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox CtoKout;
        private TextBox CtoKin;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox CtoFout;
        private TextBox CtoFin;
        private Label label13;
        private Label label14;
        private Label label15;
        private TextBox KtoFout;
        private TextBox KtoFin;
        private Label label16;
        private Label label17;
        private Label label18;
        private TextBox KtoCout;
        private TextBox KtoCin;
    }
}
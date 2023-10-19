namespace nyp_hafta_2
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
            label3 = new Label();
            adTxt = new TextBox();
            adresTxt = new TextBox();
            yasTxt = new TextBox();
            button1 = new Button();
            label4 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(294, 67);
            label1.Name = "label1";
            label1.Size = new Size(28, 20);
            label1.TabIndex = 0;
            label1.Text = "Ad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(291, 97);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 1;
            label2.Text = "Adres";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(294, 137);
            label3.Name = "label3";
            label3.Size = new Size(30, 20);
            label3.TabIndex = 2;
            label3.Text = "Yaş";
            // 
            // adTxt
            // 
            adTxt.Location = new Point(363, 64);
            adTxt.Name = "adTxt";
            adTxt.Size = new Size(125, 27);
            adTxt.TabIndex = 3;
            adTxt.Text = "zülal";
            // 
            // adresTxt
            // 
            adresTxt.Location = new Point(363, 97);
            adresTxt.Name = "adresTxt";
            adresTxt.Size = new Size(125, 27);
            adresTxt.TabIndex = 4;
            adresTxt.Text = "İnegöl";
            adresTxt.TextChanged += textBox2_TextChanged;
            // 
            // yasTxt
            // 
            yasTxt.Location = new Point(362, 130);
            yasTxt.Name = "yasTxt";
            yasTxt.Size = new Size(125, 27);
            yasTxt.TabIndex = 5;
            yasTxt.Text = "20";
            // 
            // button1
            // 
            button1.Location = new Point(362, 286);
            button1.Name = "button1";
            button1.Size = new Size(124, 56);
            button1.TabIndex = 6;
            button1.Text = "Personel Oluştur ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(294, 166);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 7;
            label4.Text = "label4";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(362, 163);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Mühendis ", "İşçi" });
            comboBox1.Location = new Point(362, 196);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 9;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(yasTxt);
            Controls.Add(adresTxt);
            Controls.Add(adTxt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Click += button1_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox adTxt;
        private TextBox adresTxt;
        private TextBox yasTxt;
        private Button button1;
        private Label label4;
        private TextBox textBox1;
        private ComboBox comboBox1;
    }
}
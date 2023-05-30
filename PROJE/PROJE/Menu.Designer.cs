namespace PROJE
{
    partial class Menu
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
            comboBox1 = new ComboBox();
            carpısmaButon = new Button();
            label1 = new Label();
            label2 = new Label();
            cizimButon = new Button();
            comboBox2 = new ComboBox();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.LightCyan;
            comboBox1.Cursor = Cursors.Hand;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(505, 185);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(299, 34);
            comboBox1.TabIndex = 0;
            // 
            // carpısmaButon
            // 
            carpısmaButon.BackColor = Color.LightSkyBlue;
            carpısmaButon.Cursor = Cursors.Hand;
            carpısmaButon.Font = new Font("Segoe Print", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            carpısmaButon.Location = new Point(577, 272);
            carpısmaButon.Name = "carpısmaButon";
            carpısmaButon.Size = new Size(116, 39);
            carpısmaButon.TabIndex = 3;
            carpısmaButon.Text = "Göster";
            carpısmaButon.UseVisualStyleBackColor = false;
            carpısmaButon.Click += carpısmaButon_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(505, 90);
            label1.Name = "label1";
            label1.Size = new Size(198, 26);
            label1.TabIndex = 6;
            label1.Text = "Çarpışma seçimi yapınız.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 90);
            label2.Name = "label2";
            label2.Size = new Size(269, 26);
            label2.TabIndex = 7;
            label2.Text = "Çizdirmek istediğiniz cismi seçiniz.";
            // 
            // cizimButon
            // 
            cizimButon.BackColor = Color.LightSkyBlue;
            cizimButon.Font = new Font("Segoe Print", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            cizimButon.Location = new Point(89, 272);
            cizimButon.Name = "cizimButon";
            cizimButon.Size = new Size(110, 39);
            cizimButon.TabIndex = 8;
            cizimButon.Text = "Çiz";
            cizimButon.UseVisualStyleBackColor = false;
            cizimButon.Click += cizimbuton_Click;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.LightCyan;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(31, 185);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(249, 34);
            comboBox2.TabIndex = 9;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.MistyRose;
            ClientSize = new Size(898, 546);
            Controls.Add(label2);
            Controls.Add(carpısmaButon);
            Controls.Add(comboBox2);
            Controls.Add(cizimButon);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Font = new Font("Segoe Print", 9F, FontStyle.Italic, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 5, 3, 5);
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MENU";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Button carpısmaButon;
        private Label label1;
        private Label label2;
        private Button cizimButon;
        private ComboBox comboBox2;
    }
}
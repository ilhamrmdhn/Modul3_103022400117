namespace Modul3_103022400117
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
            comboBoxSatuanAwal = new ComboBox();
            textBoxNilaiAwal = new TextBox();
            label1 = new Label();
            label2 = new Label();
            comboBoxSatuanAkhir = new ComboBox();
            label3 = new Label();
            textBoxNilaiAkhir = new TextBox();
            label4 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // comboBoxSatuanAwal
            // 
            comboBoxSatuanAwal.FormattingEnabled = true;
            comboBoxSatuanAwal.Items.AddRange(new object[] { "Celcius", "Fahrenheit", "Kelvin", "Reamur" });
            comboBoxSatuanAwal.Location = new Point(183, 119);
            comboBoxSatuanAwal.Name = "comboBoxSatuanAwal";
            comboBoxSatuanAwal.Size = new Size(242, 40);
            comboBoxSatuanAwal.TabIndex = 0;
            // 
            // textBoxNilaiAwal
            // 
            textBoxNilaiAwal.Location = new Point(477, 119);
            textBoxNilaiAwal.Name = "textBoxNilaiAwal";
            textBoxNilaiAwal.Size = new Size(442, 39);
            textBoxNilaiAwal.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(477, 75);
            label1.Name = "label1";
            label1.Size = new Size(119, 32);
            label1.TabIndex = 2;
            label1.Text = "Nilai Awal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(183, 76);
            label2.Name = "label2";
            label2.Size = new Size(144, 32);
            label2.TabIndex = 3;
            label2.Text = "Satuan Awal";
            // 
            // comboBoxSatuanAkhir
            // 
            comboBoxSatuanAkhir.FormattingEnabled = true;
            comboBoxSatuanAkhir.Items.AddRange(new object[] { "Celcius", "Fahrenheit", "Kelvin", "Reamur" });
            comboBoxSatuanAkhir.Location = new Point(183, 256);
            comboBoxSatuanAkhir.Name = "comboBoxSatuanAkhir";
            comboBoxSatuanAkhir.Size = new Size(242, 40);
            comboBoxSatuanAkhir.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(183, 212);
            label3.Name = "label3";
            label3.Size = new Size(149, 32);
            label3.TabIndex = 5;
            label3.Text = "Satuan Akhir";
            // 
            // textBoxNilaiAkhir
            // 
            textBoxNilaiAkhir.Location = new Point(477, 256);
            textBoxNilaiAkhir.Name = "textBoxNilaiAkhir";
            textBoxNilaiAkhir.ReadOnly = true;
            textBoxNilaiAkhir.Size = new Size(442, 39);
            textBoxNilaiAkhir.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(477, 211);
            label4.Name = "label4";
            label4.Size = new Size(124, 32);
            label4.TabIndex = 7;
            label4.Text = "Nilai Akhir";
            // 
            // button1
            // 
            button1.Location = new Point(975, 119);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 8;
            button1.Text = "Convert";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1297, 668);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(textBoxNilaiAkhir);
            Controls.Add(label3);
            Controls.Add(comboBoxSatuanAkhir);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxNilaiAwal);
            Controls.Add(comboBoxSatuanAwal);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxSatuanAwal;
        private TextBox textBoxNilaiAwal;
        private Label label1;
        private Label label2;
        private ComboBox comboBoxSatuanAkhir;
        private Label label3;
        private TextBox textBoxNilaiAkhir;
        private Label label4;
        private Button button1;
    }
}

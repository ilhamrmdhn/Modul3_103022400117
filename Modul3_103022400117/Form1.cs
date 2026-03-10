namespace Modul3_103022400117
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxSatuanAwal.SelectedItem == null || comboBoxSatuanAkhir.SelectedItem == null)
            {
                MessageBox.Show("Pilih satuan terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double nilaiAwal;
            if (!double.TryParse(textBoxNilaiAwal.Text, out nilaiAwal))
            {
                MessageBox.Show("Masukkan angka yang valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string awal = comboBoxSatuanAwal.SelectedItem.ToString();
            string akhir = comboBoxSatuanAkhir.SelectedItem.ToString();
            double hasil = 0;

            if (awal == akhir)
            {
                hasil = nilaiAwal;
            } else if (awal == "Celcius")
            {
                if (akhir == "Reamur") hasil = (4.0 / 5.0) * nilaiAwal;
                else if (akhir == "Kelvin") hasil = nilaiAwal + 273;
                else if (akhir == "Fahrenheit") hasil = (9.0 / 5.0) * nilaiAwal + 32;
            } else if (awal == "Reamur")
            {
                if (akhir == "Celcius") hasil = (5.0 / 4.0) * nilaiAwal;
                else if (akhir == "Kelvin") hasil = (5.0 / 4.0) * nilaiAwal + 273;
                else if (akhir == "Fahrenheit") hasil = (9.0 / 4.0) * nilaiAwal + 32;
            } else if (awal == "Fahrenheit")
            {
                if (akhir == "Celcius") hasil = 5.0 / 9.0 * (nilaiAwal - 32);
                else if (akhir == "Reamur") hasil = 4.0 / 9.0 * (nilaiAwal - 32);
                else if (akhir == "Kelvin") hasil = 5.0 / 9.0 * (nilaiAwal - 32) + 273;
            } else if (awal == "Kelvin")
            {
                if (akhir == "Celcius") hasil = nilaiAwal - 273;
                else if (akhir == "Reamur") hasil = 4.0 / 5.0 * (nilaiAwal - 273);
                else if (akhir == "Fahrenheit") hasil = 9.0 / 5.0 * (nilaiAwal - 273) + 32;
            }

            textBoxNilaiAkhir.Text = hasil.ToString();
        }
    }
}

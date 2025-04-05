namespace DoğuşTeknoloji_ödev_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("KrediKarti");
            comboBox1.Items.Add("Nakit");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen bir ödeme tipi seçin.");
                    return;
                }

                string odemeTipi = comboBox1.SelectedItem.ToString();
                string girilenTutar = maskedTextBox1.Text.Trim();

               
                if (string.IsNullOrWhiteSpace(girilenTutar))
                {
                    MessageBox.Show("Lütfen geçerli bir tutar girin.");
                    return;
                }

                if (!decimal.TryParse(girilenTutar, out decimal tutar))
                {
                    MessageBox.Show("Tutar sayısal bir değer olmalıdır.");
                    return;
                }

               
                Iodeme odeme = OdemeFactory.CreateOdeme(odemeTipi);
                string sonuc = odeme.OdemeYap(tutar);

               
                maskedTextBox2.Text = ""; 
                maskedTextBox2.Text = sonuc; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}

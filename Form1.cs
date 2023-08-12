namespace Vergi_Hesaplayıcı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double fiyat, vergi;
            double son_fiyat;
            fiyat = Convert.ToDouble(textBox1.Text);
            vergi = Convert.ToDouble(textBox2.Text);
            son_fiyat = fiyat + (fiyat * (vergi / 100));
            listBox1.Items.Add("Vergili fiyat : " + son_fiyat.ToString("0.00") + " ₺");
        }

    }
}
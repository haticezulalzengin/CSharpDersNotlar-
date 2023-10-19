namespace nyp_hafta_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personel pers = new Personel(adTxt.Text, adresTxt.Text, Convert.ToInt32(yasTxt.Text), Convert.ToInt32(mesaiTxt));
            MessageBox.Show(pers.ucretHesapla().ToString());

            //Personel prs2 = new Personel(adTxt.Text);
            //label1.Text = prs2.Ad;
            //Personel prs1 = new Personel(adTxt.Text, adresTxt.Text, Convert.ToInt32(yasTxt.Text));


            /*Personel prs1 = new Personel();
            prs1.Ad = adTxt.Text;
            prs1.Adres = adresTxt.Text;
            prs1.Yas = Convert.ToInt32(yasTxt.Text);
            */
            /* MessageBox.Show("Ad=" + prs1.Ad + 
                "\nAdres=" + prs1.Adres + 
                "\nYaþ=" + prs1.Yas);*/

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
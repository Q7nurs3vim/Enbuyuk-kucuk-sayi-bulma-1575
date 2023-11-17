namespace büyük_küçük_sayı_1575
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sayi3, enBuyuk, enKucuk;
            sayi1 = Convert.ToInt32(txtSayi1.Text);

            sayi2 = Convert.ToInt32(txtSayi2.Text);

            sayi3 = Convert.ToInt32(txtSayi3.Text);


            if (sayi1 > sayi2 && sayi1 > sayi3)
                enBuyuk = sayi1;
            else if (sayi2 > sayi3 && sayi2 > sayi1)
                enBuyuk = sayi2;
            else
                enBuyuk = sayi3;



            if (sayi1 < sayi2 && sayi1 < sayi3)
                enKucuk = sayi1;
            else if (sayi2 < sayi3 && sayi2 < sayi1)
                enKucuk = sayi2;
            else
                enKucuk = sayi3;


            lblEnbüyük.Text = enBuyuk.ToString();
            lblEnkücük.Text = enKucuk.ToString();


        }
    }
}
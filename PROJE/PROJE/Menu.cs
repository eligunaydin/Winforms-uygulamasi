/****************************************************************************
**                           SAKARYA ÜNÝVERSÝTESÝ
**                  BÝLGÝSAYAR VE BÝLÝÞÝM BÝLÝMLERÝ FAKÜLTESÝ
**                         BÝLGÝSAYAR MÜHENDÝSLÝÐÝ BÖLÜMÜ
**                        NESNEYE DAYALI PROGRAMLAMA DERSÝ
**
**                               ÖDEV NUMARASI: 1
**                            ÖÐRENCÝ ADI: ELÝF GÜNAYDIN
**                           ÖÐRENCÝ NUMARASI: G221210073
**                                  DERS GRUBU: 2A
                                 YOUTUBE LÝNKÝ: https://youtu.be/Nu5OgGSH29w
*****************************************************************************/
namespace PROJE
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Seçilecek olan çarpýþma denetimi için comboBox1 ögelerine ekleme
            comboBox1.Items.Add("Nokta-Dikdörtgen");
            comboBox1.Items.Add("Nokta-Çember");
            comboBox1.Items.Add("Dikdörtgen-Dikdörtgen");
            comboBox1.Items.Add("Dikdörtgen-Çember");
            comboBox1.Items.Add("Çember-Çember");
            comboBox1.Items.Add("Nokta-Küre");
            comboBox1.Items.Add("Nokta-Dikdörtgen prizma");
            comboBox1.Items.Add("Nokta-Silindir");
            comboBox1.Items.Add("Silindir-Silindir");
            comboBox1.Items.Add("Küre-Küre");
            comboBox1.Items.Add("Küre-Silindir");
            comboBox1.Items.Add("Yüzey-Küre");
            comboBox1.Items.Add("Yüzey-Dikdörtgen prizma");
            comboBox1.Items.Add("Yüzey-Silindir");
            comboBox1.Items.Add("Küre-Dikdörtgen prizma");
            comboBox1.Items.Add("Dikdörtgen prizma-Dikdörtgen prizma");

            //Çizimi yapýlacak olan nesne seçimi için comboBox2 ögelerine ekleme
            comboBox2.Items.Add("Nokta");
            comboBox2.Items.Add("Çember");
            comboBox2.Items.Add("Dörtgen");
            comboBox2.Items.Add("Dikdörtgen");
            comboBox2.Items.Add("Silindir");
            comboBox2.Items.Add("Küre");
            comboBox2.Items.Add("Yüzey");
            comboBox2.Items.Add("Dikdörtgen prizma");
        }
        private void cizimbuton_Click(object sender, EventArgs e)
        {
            // Seçilen nesne çizimi için buton yardýmýyla ilgili formu açma
            if (comboBox2.SelectedIndex == 0)
            {
                Form2 form2 = new Form2();
                form2.ShowDialog();
            }

            if(comboBox2.SelectedIndex == 1)
            {
                Form1 form1 = new Form1();
                form1.ShowDialog();
            }

            if (comboBox2.SelectedIndex == 2)
            {
                Form7 form7 = new Form7();
                form7.ShowDialog();
            }
            if (comboBox2.SelectedIndex == 3)
            {
                Form8 form8 = new Form8();
                form8.ShowDialog();
            }
            if (comboBox2.SelectedIndex == 4)
            {
                Form10 form10 = new Form10();
                form10.ShowDialog();;
            }
            if (comboBox2.SelectedIndex == 5)
            {
                Form9 form9 = new Form9();
                form9.ShowDialog();
            }
            if (comboBox2.SelectedIndex == 6)
            {
                Form11 form11 = new Form11();
                form11.ShowDialog();
            }
            if (comboBox2.SelectedIndex == 7)
            {
                Form12 form12 = new Form12();
                form12.ShowDialog();
            }
        }   

        private void carpýsmaButon_Click_1(object sender, EventArgs e)
        {
            // Seçilen çarpýþma denetimi için buton yardýmýyla ilgili formu açma
            if (comboBox1.SelectedIndex == 0)
            {
                Form13 form13= new Form13(); 
                form13.ShowDialog();
            }

            if (comboBox1.SelectedIndex == 1)
            {
                Form4 form4= new Form4();
                form4.ShowDialog();
            }

            if(comboBox1.SelectedIndex==2)
            {
                Form5 form5= new Form5();
                form5.ShowDialog();
            }
            if (comboBox1.SelectedIndex == 3)
            {
                Form14 form14 = new Form14();
                form14.ShowDialog();
            }
            if (comboBox1.SelectedIndex == 4)
            {
                Form3 form3 = new Form3();
                form3.ShowDialog();
            }
            if (comboBox1.SelectedIndex == 5)
            {
                Form15 form15 = new Form15();
                form15.ShowDialog();
            }
            if (comboBox1.SelectedIndex == 6)
            {
                Form18 form18 = new Form18();
                form18.ShowDialog();
            }
            if (comboBox1.SelectedIndex == 8)
            {
                Form6 form6 = new Form6();
                form6.ShowDialog();
            }
            if (comboBox1.SelectedIndex == 9)
            {
                Form16 form16 = new Form16();
                form16.ShowDialog();
            }
            if (comboBox1.SelectedIndex == 10)
            {
                Form17 form17 = new Form17();
                form17.ShowDialog();
            }

        }
    }
}
/****************************************************************************
**                           SAKARYA �N�VERS�TES�
**                  B�LG�SAYAR VE B�L���M B�L�MLER� FAK�LTES�
**                         B�LG�SAYAR M�HEND�SL��� B�L�M�
**                        NESNEYE DAYALI PROGRAMLAMA DERS�
**
**                               �DEV NUMARASI: 1
**                            ��RENC� ADI: EL�F G�NAYDIN
**                           ��RENC� NUMARASI: G221210073
**                                  DERS GRUBU: 2A
                                 YOUTUBE L�NK�: https://youtu.be/Nu5OgGSH29w
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
            // Se�ilecek olan �arp��ma denetimi i�in comboBox1 �gelerine ekleme
            comboBox1.Items.Add("Nokta-Dikd�rtgen");
            comboBox1.Items.Add("Nokta-�ember");
            comboBox1.Items.Add("Dikd�rtgen-Dikd�rtgen");
            comboBox1.Items.Add("Dikd�rtgen-�ember");
            comboBox1.Items.Add("�ember-�ember");
            comboBox1.Items.Add("Nokta-K�re");
            comboBox1.Items.Add("Nokta-Dikd�rtgen prizma");
            comboBox1.Items.Add("Nokta-Silindir");
            comboBox1.Items.Add("Silindir-Silindir");
            comboBox1.Items.Add("K�re-K�re");
            comboBox1.Items.Add("K�re-Silindir");
            comboBox1.Items.Add("Y�zey-K�re");
            comboBox1.Items.Add("Y�zey-Dikd�rtgen prizma");
            comboBox1.Items.Add("Y�zey-Silindir");
            comboBox1.Items.Add("K�re-Dikd�rtgen prizma");
            comboBox1.Items.Add("Dikd�rtgen prizma-Dikd�rtgen prizma");

            //�izimi yap�lacak olan nesne se�imi i�in comboBox2 �gelerine ekleme
            comboBox2.Items.Add("Nokta");
            comboBox2.Items.Add("�ember");
            comboBox2.Items.Add("D�rtgen");
            comboBox2.Items.Add("Dikd�rtgen");
            comboBox2.Items.Add("Silindir");
            comboBox2.Items.Add("K�re");
            comboBox2.Items.Add("Y�zey");
            comboBox2.Items.Add("Dikd�rtgen prizma");
        }
        private void cizimbuton_Click(object sender, EventArgs e)
        {
            // Se�ilen nesne �izimi i�in buton yard�m�yla ilgili formu a�ma
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

        private void carp�smaButon_Click_1(object sender, EventArgs e)
        {
            // Se�ilen �arp��ma denetimi i�in buton yard�m�yla ilgili formu a�ma
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
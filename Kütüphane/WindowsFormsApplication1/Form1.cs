using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Giriş : Form
    {
        public Giriş()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "G")
            {
                textBox2.PasswordChar = '\0';
                button3.Text = "K";
            }
            else if (button3.Text == "K")
            {
                textBox2.PasswordChar = '*';
                button3.Text = "G";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
                DialogResult kutuphane = new DialogResult();
            kutuphane = MessageBox.Show("Giriş yapılsın mı?", "GİRİŞ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kutuphane == DialogResult.Yes)
            {

                if (textBox1.Text != "" && textBox2.Text != "")
                {
                    string kuladi = Convert.ToString(textBox1.Text);
                    double sifre =Convert.ToDouble(textBox2.Text);

                    if (kuladi == "Kütüphane" && sifre == 123)
                    {
                        Form2 form1 = new Form2();
                        form1.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı Adınızı Veya Şifrenizi Kontrol Ediniz...");
                    }
                }

                else
                {
                    MessageBox.Show("Lütfen Boş Yer Bırakmayınız..");
                }

            }
            else if (kutuphane == DialogResult.No)
            {
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult asd = new DialogResult();
            asd = MessageBox.Show("Çıkış yapılsın mı?", "ÇIKIŞ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (asd == DialogResult.Yes)
            {

                Application.Exit();

            }
            else if (asd == DialogResult.No)
            {
            }

        }

        private void Giriş_MouseClick(object sender, MouseEventArgs e)
        {
        
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace WindowsFormsApplication1
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source =Database2.mdb");
        OleDbCommand cmd;
        OleDbDataAdapter da;
        DataSet ds;

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form11_Load(object sender, EventArgs e)
        {
            griddoldur();

        }
        void griddoldur()
        {

            da = new OleDbDataAdapter("Select*from Tablo1", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Tablo1");
            dataGridView1.DataSource = ds.Tables["Tablo1"];
            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
              DialogResult nesne = new DialogResult();
            nesne = MessageBox.Show("Eklensin mi?", "EKLEME", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (nesne == DialogResult.Yes)
            {

                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" &&comboBox1.Text!=""&&listBox1.Text!=""&& textBox4.Text != "")
                {
                    MessageBox.Show("Başarıyla Eklendi...");
                    cmd = new OleDbCommand();
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = "Insert into Tablo1 (Kullanici_no,Kullanici_adi,Kullanici_soyadi,Kitap_Turu,Kitap_Adi,Secilen_Kitap) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "','"+listBox1.Text+"','"+textBox4.Text+"')";
                    cmd.ExecuteNonQuery();
                }


                else
                {
                    MessageBox.Show("Boş Yer Bırakmayınız...");
                    con.Close();
                    griddoldur();

                }
            

            }
            else if(nesne==DialogResult.No)
            {
              

            
            }






        }


        private void button2_Click(object sender, EventArgs e)
        {
            Form2 nesne2 = new Form2();
            nesne2.Show();
            this.Hide();
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.Text = "";
        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            textBox3.Text = "";
        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            comboBox1.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
           comboBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            listBox1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox1.Enabled = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult guncelle = new DialogResult();
            guncelle = MessageBox.Show("Güncellensin Mi?", "GÜNCELLEME", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (guncelle == DialogResult.Yes)
            {
                cmd = new OleDbCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "update Tablo1 set Kullanici_adi='" + textBox2.Text + "',Kullanici_soyadi='" + textBox3.Text + "',Kitap_Turu='" + comboBox1.Text+ "',Kitap_Adi='" + listBox1.Text +"',Secilen_Kitap='"+textBox4.Text+ "' where Kullanici_no=" + textBox1.Text + "";
                cmd.ExecuteNonQuery();
                con.Close();
                griddoldur();
                textBox1.Enabled = true;
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }

            else if (guncelle == DialogResult.No)
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult silme = new DialogResult();
            silme = MessageBox.Show("Silinsin mi?", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (silme == DialogResult.Yes)
            {
                cmd = new OleDbCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "delete from Tablo1 where Kullanici_no=" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "";
                cmd.ExecuteNonQuery();
                con.Close();
                griddoldur();
            }

            else if (silme == DialogResult.No)
            {

            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
            listBox1.Text = "";
            textBox4.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("KÜRK MANTOLU MADONNA");
                listBox1.Items.Add("İÇİMİZDEKİ ŞEYTAN");
                listBox1.Items.Add("OLAĞANÜSTÜ BİR GECE");
                listBox1.Items.Add("SON");
                listBox1.Items.Add("SİMYACI");

            }


            else if (comboBox1.SelectedIndex == 1)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("BAŞLANGIÇ");
                listBox1.Items.Add("AÇLIK OYUNLARI");
                listBox1.Items.Add("MAHŞER");
                listBox1.Items.Add("SİL BAŞTAN");
                listBox1.Items.Add("AV MEVSİMİ");
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("MUHALİFLER");
                listBox1.Items.Add("CESUR YENİ DÜNYA");
                listBox1.Items.Add("SAVAŞ FIRTINASI");
                listBox1.Items.Add("ZAMANI DURDURMANIN YOLLARI");
              
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("KAFES");
                listBox1.Items.Add("CEHENNEM");
                listBox1.Items.Add("KIZIL NEHİRLER");
                listBox1.Items.Add("KLON");

            }
            else if (comboBox1.SelectedIndex == 4)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("ALEX DE SOUZA");
                listBox1.Items.Add("KRALIN DÖNÜŞÜ");
                listBox1.Items.Add("BİZE HER YER TRABZON");
                

            }
            else if (comboBox1.SelectedIndex == 5)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("SEVDA SÖZLERİ");
                listBox1.Items.Add("ISSIZ DAMLA");
                listBox1.Items.Add("PERVANE");
                listBox1.Items.Add("İNCELİKLER YÜZÜNDEN");

            }
            else if (comboBox1.SelectedIndex == 6)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("SIZMA SANATI");
                listBox1.Items.Add("TÜRK'ÜN SİBER ORDUSU");
                listBox1.Items.Add("SİBER KIRILMA");


            }
            else if (comboBox1.SelectedIndex == 7)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("SUFİSÖZLÜK");
                listBox1.Items.Add("ANTİK YUNAN VE ROMA HİKAYELERİ");
                listBox1.Items.Add("SÜMER MİTOLOJİSİ");
                listBox1.Items.Add("TOPRAK");


            }




        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox4.Text = listBox1.SelectedItem.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    
    

﻿using System;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 nesnee2 = new Form2();
            nesnee2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
             tabControl1.SelectedTab = tabPage4;
        }
        

        private void button7_Click(object sender, EventArgs e)
        {
     tabControl1.SelectedTab = tabPage3;
        }
        

        private void button8_Click(object sender, EventArgs e)
        {
 tabControl1.SelectedTab = tabPage5;
        }
        

        private void button10_Click(object sender, EventArgs e)
        {
 tabControl1.SelectedTab = tabPage4;
        }
        

        private void button9_Click(object sender, EventArgs e)
        {
 tabControl1.SelectedTab = tabPage1;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 emre = new Form2();
            emre.Show();
            this.Hide();
        }


       
    }
}

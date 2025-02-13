﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text);

            label4.Text = comboBox1.Items.Count.ToString();

            textBox1.Clear();

            textBox1.Select();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Sorted = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex != -1)
            {
                comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);

                label4.Text = comboBox1.Items.Count.ToString();

                comboBox1.ResetText();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
            textBox3.Text = comboBox1.SelectedItem.ToString();

            textBox2.Text = comboBox1.SelectedIndex.ToString();
            }
           }
    }
}

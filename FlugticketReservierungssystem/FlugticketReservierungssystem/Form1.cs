﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlugticketReservierungssystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Route: " + comboBox1.Text+ " - " +  comboBox2.Text + " Datum: " + dateTimePicker1.Text
                + " Zeit: " + maskedTextBox1.Text + " Name und Vorname: " + textBox1.Text + " Pass Nummer: "
                + maskedTextBox2.Text + " Telefonnummer: " + maskedTextBox3.Text
                + maskedTextBox2.Text + " Telefonnummer: " + maskedTextBox3.Text);
            MessageBox.Show("Der Flug wurde erfolgreich gebucht");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Text = comboBox2.Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1.Text = label9.Text;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace PrjTestePortasCOM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();

            foreach (string port in ports)
            {
                lbPortas.Items.Add(port);

            }
        }

        private void lbPortas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbPortas.Items.Clear();
            string[] ports = SerialPort.GetPortNames();

            foreach (string port in ports)
            {

                lbPortas.Items.Add(port);

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AysnAwaitDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Task<int> t = new Task<int>(CountCharacters);
            t.Start();
            label1.Text = "Processing... Please wait";
            int total =  await t;
            label1.Text = total.ToString();
        }

        public int CountCharacters()
        {
            StreamReader sr = new StreamReader(@"E:\Temus-Training-Demo-Files\ipl.csv");
            string data = sr.ReadToEnd();
            Thread.Sleep(10000);
            return data.Length;
        }
    }
}

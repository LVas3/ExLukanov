using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExLukanov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        Random random = new Random();
        void RandNum()
        {
           
                int x = random.Next();
                label1.Text = x.ToString();
              
        }
       
        private void button1_Click(object sender, EventArgs e)
        {


            RandNum();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Label1";
        }
    }
}

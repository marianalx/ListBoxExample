using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            //zmiana opcji
            if (lbOptions.SelectedIndex > -1)
            {
                MessageBox.Show(String.Format("Wybrany index opcji - {0}, treść: {1}",
                    lbOptions.SelectedIndex, lbOptions.Items[lbOptions.SelectedIndex]));
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbOptions.SelectedIndex = -1;
        }
    }
}

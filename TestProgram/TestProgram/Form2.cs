using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProgram
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void testButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is the original text");
        }

        private void form1Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

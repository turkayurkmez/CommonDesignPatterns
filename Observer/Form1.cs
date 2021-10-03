using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Observer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonNewForm_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(colorSubscription);
            form2.Show();
        }
        ColorSubscription colorSubscription = new ColorSubscription();
        private void buttonChangeColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                colorSubscription.NewColor = colorDialog.Color;
            }
            colorSubscription.Notify();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

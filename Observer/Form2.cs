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
    public partial class Form2 : Form, IObserver
    {
        private ColorSubscription colorSubscription;

        public Form2(ColorSubscription colorSubscription)
        {
            this.colorSubscription = colorSubscription;
            InitializeComponent();
        }

        public void ChangeBackgroundColor(Color color)
        {
            this.BackColor = color;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorSubscription.Subscribe(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            colorSubscription.UnSubscribe(this);
        }
    }
}

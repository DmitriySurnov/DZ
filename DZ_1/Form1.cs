using System;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;

namespace DZ_1
{
    public partial class Form1 : Form
    {
        private int maxwidth;
        public Form1()
        {
            InitializeComponent();
        }

        private void Formatir()
        {
            maxwidth = (int)(Width * 0.66);
            int leftMargin = 1;
            int topMargin = 1;
            foreach (var tb in Controls.OfType<Button>())
            {
                if (leftMargin+ tb.Width > maxwidth && leftMargin != 1)
                {
                    leftMargin = 1;
                    topMargin += tb.Height + 2;
                }
                tb.Location = new Point(leftMargin, topMargin);
                leftMargin += tb.Width + 2;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Formatir();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            Formatir();
        }
    }
}

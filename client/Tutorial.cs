using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client
{
    public partial class Tutorial : Form
    {
        public Tutorial()
        {
            InitializeComponent();
            OrigTime = 0;
            Timer_AboutUS.Start();
        }
        int OrigTime = 0;
        Random rnd = new Random();

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Timer_AboutUS_Tick(object sender, EventArgs e)
        {
            Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));

            iconButton1.IconColor = randomColor;
            iconButton2.IconColor = randomColor;
            iconButton3.IconColor = randomColor;


        }
    }
}

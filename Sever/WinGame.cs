using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sever
{
    public partial class WinGame : Form
    {
        public WinGame()
        {
            InitializeComponent();
        }
        public WinGame(List<string> ListWin)
        {
            List<Label> label = new List<Label> { lblTop1, lblTop2, lblTop3 };
            InitializeComponent();
            for (int i = 0; i < ListWin.Count; i++)
            {
                if (i == 0)
                    lblTop1.Text = ListWin[i];
                else if( i==1)
                    lblTop2.Text = ListWin[i];
                else if (i == 2)
                    lblTop3.Text = ListWin[i];
               

            }
        }
        private void btnClosed_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Winner_SizeChanged(object sender, EventArgs e)
        {
            pnlRank.Location = new Point((this.Width - pnlRank.Width) / 2, (this.Height - pnlRank.Height) / 2);
        }
        Random rnd = new Random();

        private void timer1_Tick(object sender, EventArgs e)
        {
            Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));

            lblTitle.ForeColor = randomColor;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client
{
    public partial class UCAnswerBox : UserControl
    {
        public UCAnswerBox()
        {
            InitializeComponent();

        }
        public string Data
        {
            get => BtnA.Text;
            set { BtnA.Text = value.ToString(); }
        }
        public Color Fillcolor
        {


            get => txtAnswer.FillColor;

            set
            {
                txtAnswer.FillColor = value;
            }
        }
        public string Content_Ans
        {
            get
            {
                return txtAnswer.Text;
            }
            set
            {
                txtAnswer.Text = value;
            }
        }

        public bool isAnswerCorrect
        {
            get
            {
                return chkAnwerCorrect.Checked;
            }
            set
            {
                chkAnwerCorrect.Checked = value;
            }
        }

        private void Ans_Click(object sender, EventArgs e)
        {
            if (chkAnwerCorrect.Checked == true)
            {
                txtAnswer.FillColor = Color.Turquoise;
                chkAnwerCorrect.Checked = false;
            }
            else
            {
                chkAnwerCorrect.Checked = true;
                txtAnswer.FillColor = Color.Gold;
            }
        }
        
        private void btnAnswerA_Click(object sender, EventArgs e)
        {

            if (chkAnwerCorrect.Checked == true)
            {
                txtAnswer.FillColor = Color.Turquoise;
                chkAnwerCorrect.Checked = false;
            }
            else
            {
                chkAnwerCorrect.Checked = true;
                txtAnswer.FillColor = Color.Gold;
            }


        }

        private void txtAnswer_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAnswer_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}

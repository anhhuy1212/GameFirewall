using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sever
{
    public partial class UCAnswerBox : UserControl
    {
        public UCAnswerBox()
        {
            InitializeComponent();
        }

        public string Content
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
    }
}

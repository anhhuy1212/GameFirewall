using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTOProject
{
    public partial class numberPeopleWacthing : UserControl
    {
        public numberPeopleWacthing()
        {
            InitializeComponent();
        }
        public int Number
        {
            get => int.Parse(lblNumber.Text);
            set { lblNumber.Text = value.ToString(); }
        }
    }
}

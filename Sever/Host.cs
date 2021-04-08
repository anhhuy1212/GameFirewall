using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOProject.DTO;
using MyLib;
using System.Runtime.CompilerServices;

namespace Sever
{
    public partial class Host : Form
    {
        public IconButton currentBtn;
        public Panel leftBorderBtn;
        public Color activeColor = Color.LightCoral;
        //public Color activeColor = Color.FromArgb(199, 0, 57);
        List<GameShow> listGameShow = new List<GameShow>();
        string path = "../../../Schedule_Game.txt";
        List<Question> listQuestion = new List<Question>();
        string filePath = "../../question.txt";
        public Host()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 76);
            pnlBtnGroup.Controls.Add(leftBorderBtn);


        }

        private void setInforNearestGame()
        {
            GameShow nearestGame = Utils.findNearestGame(listGameShow);
            if (nearestGame == null)
            {
                txtID.Text = "0";
                dtmStart.Value = DateTime.Now;
                dtmEnd.Value = DateTime.Now.AddMinutes(30);
                txtName.Text = "Hiện không có game nào phát sóng trong thời gian tới";
            }
            else
            {
                txtID.Text = nearestGame.ID;
                dtmStart.Value = nearestGame.StartTime;
                dtmEnd.Value = nearestGame.EndTime;
                txtName.Text = nearestGame.Name;
                nudNumberPlayer.Value = nearestGame.NumberPlayer;
            }
        }

        public void activateButton(object sender, Color color)
        {
            if (sender != null)
            {
                disableButton();

                currentBtn = (IconButton)sender;
                currentBtn.BackColor = Color.FromArgb(28, 28, 28);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = color;
                currentBtn.Padding = new Padding(20, 0, 0, 0);
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;

                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.BringToFront();
            }
        }

        public void disableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.LightCoral;
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleRight;
                currentBtn.IconColor = Color.White;
                currentBtn.Padding = new Padding(10, 0, 0, 0);
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
                pnlLeft.Hide();
                pnlAboutUs.Hide();
                grvSchedule.DataSource = null;
                listGameShow.Clear();
                listQuestion.Clear();

            }
        }



        private void btnHome_Click(object sender, EventArgs e)
        {
            activateButton(sender, activeColor);
            Utils.getScheduleFromFile(path, listGameShow);
            setInforNearestGame();
            pnlLeft.Show();
        }

        private void btnScheduleMGMT_Click(object sender, EventArgs e)
        {
            QuanLyLichTrinh frmSchedule = new QuanLyLichTrinh();
            activateButton(sender, activeColor);
            frmSchedule.ShowDialog();
            setInforNearestGame();
            this.WindowState = FormWindowState.Normal;
            Utils.getScheduleFromFile(path, listGameShow);
            grvSchedule.DataSource = listGameShow;
        }

        private void btnQuestionMGMT_Click(object sender, EventArgs e)
        {
            QuanLyCauHoi frmQuestion = new QuanLyCauHoi();
            activateButton(sender, activeColor);
            frmQuestion.ShowDialog();
            setInforNearestGame();
            this.WindowState = FormWindowState.Normal;
            Utils.getListQuestionFromFile(filePath, listQuestion);
            grvSchedule.DataSource = listQuestion;
        }

        private void btnTutorial_Click(object sender, EventArgs e)
        {
            activateButton(sender, activeColor);
            setInforNearestGame();
            this.WindowState = FormWindowState.Normal;
            pnlAboutUs.Show();
        }

        private void btnSchduleGo_Click(object sender, EventArgs e)
        {
            btnScheduleMGMT.PerformClick();

        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            btnHome.PerformClick();
            if (txtName.Text == "Hiện không có game nào phát sóng trong thời gian tới")
            {
                MessageBox.Show("Hiện Tại không có game nào để bắt đầu\nBạn nên tạo 1 game mới hoặc thay đổi lịch trình game củ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnScheduleMGMT.PerformClick();
            }
            else
            {
                MC_HL frmMC = new MC_HL();
                if(frmMC==null)
                {
                    frmMC = new MC_HL();
                }    
                frmMC.ShowDialog();
                this.WindowState = FormWindowState.Normal;
            }

        }
        int OrigTime = 1800;
        private void TimerX_Tick(object sender, EventArgs e)
        {
            OrigTime--;
            txtCountDown.Text = OrigTime / 60 + ":" + ((OrigTime % 60) >= 10 ? (OrigTime % 60).ToString() : "0" + OrigTime % 60);
            if (OrigTime <= 0)
            {
                gameTimer.Enabled = false;
                BtnStart.Enabled = true;
            }
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            TimerX_Tick(sender, e);
        }
        Timer gameTimer = new Timer();
        private void Host_Load(object sender, EventArgs e)
        {
            gameTimer.Interval = 1000;
            gameTimer.Tick += GameTimer_Tick;
            OrigTime = (int)Math.Round((DateTime.Now.AddSeconds(1) - DateTime.Now).TotalSeconds, 0);
            gameTimer.Enabled = true;
            setInforNearestGame();
            pnlLeft.Hide();
            pnlAboutUs.Hide();
            //fixCircleProFile(pictureBox1);
            //fixCircleProFile(pictureBox2);
            //fixCircleProFile(pictureBox3);

        }

        private PictureBox fixCircleProFile(PictureBox pictureBox1)
        {
            Rectangle r = new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height);
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();

            gp.AddEllipse(0, 0, pictureBox1.Width - 3, pictureBox1.Height - 3);
            Region rg = new Region(gp);
            pictureBox1.Region = rg;
            return pictureBox1;
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            activateButton(sender, activeColor);
            setInforNearestGame();
            pnlAboutUs.Show();
        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            btnAboutUs.PerformClick();
        }
       
    }
}

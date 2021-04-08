using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTOProject.DTO;
using MyLib;
using WMPLib;

namespace client
{
    public partial class MenuGame : Form
    {
        List<GameShow> listGameShow = new List<GameShow>();
        string path = "../../../Schedule_Game.txt";
        string filePath = "../../TxtPersonal.txt";

        public MenuGame()
        {
            InitializeComponent();
            Utils.getScheduleFromFile(path, listGameShow);
            grvListGame.DataSource = listGameShow;
            setInforNearestGame();
            lblTitle.Height = (int)(this.Height * 0.1);
            grvListGame.Height = (int)(this.Height * 0.5);
            pnlNearestGame.Height = (int)(this.Height * 0.4);
            PlayGameAudio.URL = "FireWallGame.mp3";
            TimeAudioGame.Start();
        }

        public void setInforNearestGame()
        {
            GameShow nearestGame = Utils.findNearestGame(listGameShow);
            if (nearestGame == null)
            {
                lblGameID.Text = "Hiện không có game nào phát sóng trong thời gian tới";
                lblGameTime.Text = "";
                lblWaitingTime.Text = "";
                lblGameName.Text = "";
            }
            else
            {
                lblGameID.Text = nearestGame.ID;
                lblGameTime.Text = nearestGame.StartTime.ToString();
                lblGameName.Text = nearestGame.Name;
               // lblGameTime.Text = DateTime.Now.AddSeconds(10).ToString();
            }
        }

        private void MenuGame_SizeChanged(object sender, EventArgs e)
        {
            lblTitle.Height = (int)(this.Height * 0.1);
            grvListGame.Height = (int)(this.Height * 0.5);
            pnlNearestGame.Height = (int)(this.Height * 0.4);
        }

        private void btnTutorial_Click(object sender, EventArgs e)
        {
            Tutorial frmTutorial = new Tutorial() ;
            frmTutorial.ShowDialog();

        }


        int OrigTime = 1800;
        private void GamerTimer_Tick(object sender, EventArgs e)
        {
            TimerX_Tick(sender, e);
        }

        private void TimerX_Tick(object sender, EventArgs e)
        {
            OrigTime--;
            if (OrigTime <= 0)
            {
                GamerTimer.Enabled = false;
               // if (lblGameID.Text != "Hiện không có game nào phát sóng trong thời gian tới")
                    btnStart.Enabled = true;
                lblTimeEnterGame.Text = "00:00";
            }
            else
            lblTimeEnterGame.Text = OrigTime / 60 + ":" + ((OrigTime % 60) >= 10 ? (OrigTime % 60).ToString() : "0" + OrigTime % 60);
            lblWaitingTime.Text = lblTimeEnterGame.Text;

        }
        Timer gameTimer = new Timer();
        private void MenuGame_Load(object sender, EventArgs e)
        {


            GameShow nearestGame = Utils.findNearestGame(listGameShow);
            //nearestGame.StartTime = DateTime.Now.AddSeconds(30);
            if (nearestGame == null)
                OrigTime = (int)Math.Round((DateTime.Now - DateTime.Now).TotalSeconds, 0);
            else
    
                OrigTime = (int)Math.Round((nearestGame.StartTime - DateTime.Now).TotalSeconds, 0);
                gameTimer.Interval = 1000;
                gameTimer.Tick += GamerTimer_Tick;
                gameTimer.Enabled = true;
            

        }
        // Click bắt đầu mở form Personal
        private void btnStart_Click(object sender, EventArgs e)
        {
            TimeAudioGame.Stop();
            PlayGameAudio.controls.stop();
            Point point = new Point();
            int x = 547;
            int y = 75;
            Personal frmPersonal = new Personal();
            Size sizechanged = new Size();
            sizechanged = this.Size;
            this.Size = frmPersonal.Size;
            this.Location = new Point(x, y);
            frmPersonal.ShowDialog();
            if(new FileInfo(filePath).Length < 2)
            {
                frmPersonal.Show();
                var result = MessageBox.Show("Are you sure with your choice?", "Warning ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    frmPersonal.Close();
                    this.Location = new Point(x - 300, y);
                    this.Size = sizechanged;
                    this.WindowState = FormWindowState.Normal;
                    return;
                }
                return;
            }
            //StreamReader sr = new StreamReader(filePath);
            //string line = null;
            //while ((line = sr.ReadLine()) == null)
            //{
            //    frmPersonal.ShowDialog();
            //}
            this.Close();

        }

        private void lblTimeEnterGame_Click(object sender, EventArgs e)
        {

        }
        WindowsMediaPlayer PlayGameAudio = new WindowsMediaPlayer();

        private void TimeAudioGame_Tick(object sender, EventArgs e)
        {
            PlayGameAudio.controls.play();
        }
    }
}

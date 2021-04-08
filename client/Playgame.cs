using DTOProject;
using DTOProject.DTO;
using Guna.UI2.WinForms;
using MyLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace client
{
    public partial class Playgame : Form
    {
        List<WindowsMediaPlayer> ListAudio = new List<WindowsMediaPlayer>(); 
        string filePath = "../../TxtPersonal.txt";
        CLPersonal personal = new CLPersonal();
        List<UCAnswerBox> buttonAns;
        List<Guna2Button> buttonlevel;
        NetworkStream networkStream;

        TcpClient client;
        Thread listen = null;
        public Playgame()
        {
            InitializeComponent();
          
        }
        int x = 0;
        public Playgame(Personal frm)
        {
            InitializeComponent();
            frm.getNetworkStream += new Personal.GetNetworkStream(SetNetworkStream);
            buttonAns = new List<UCAnswerBox> { ucAnswerA, ucAnswerB, ucAnswerC, ucAnswerD };
            buttonlevel = new List<Guna2Button> { guna2Button1, guna2Button2, guna2Button3, guna2Button4, guna2Button5, guna2Button6, guna2Button7, guna2Button8, guna2Button9, guna2Button10, guna2Button11 };
          //  pnlLeft.Width = this.Width - pnlRight.Width;
            SetPersonal();
            timer = 0;
            tmr_Total.Start();
            ProgressTimeGame.Value = 0;
            lblPoint.Text = "0";
            x = int.Parse(lblPoint.Text);
            ucAnswerC.Hide();
            ucAnswerD.Hide();
            List<string> liststringaudio = new List<string> { "IntroGame.mp3", "AnswerRight.mp3", "AnswerWrong.mp3", "WinGame.mp3", "PlayGame.mp3","FireWallGame.mp3" };
            for (int i=0;i< liststringaudio.Count; i++)
            {
                WindowsMediaPlayer playwindow = new WindowsMediaPlayer();
                ListAudio.Add(playwindow);
                ListAudio[i].URL = liststringaudio[i];
            }
            StopMusic();

        }

        private void SetNetworkStream(NetworkStream networkStream, TcpClient client)
        {
            this.networkStream = networkStream;
            this.client = client;
        }
        List<UCAnswerBox> LstAnswer;
        private void Playgame_Load(object sender, EventArgs e)
        {
            LstAnswer = new List<UCAnswerBox>();
            LstAnswer.Add(ucAnswerA);
            LstAnswer.Add(ucAnswerB);
            LstAnswer.Add(ucAnswerC);
            LstAnswer.Add(ucAnswerD);
            PcbWinner.Hide();
            SetChart(0, 0, 0, 0);
            listen = new Thread(ConnectData);
            listen.Start();
            ListAudio[0].controls.play();
            TimeGameLoad.Start();
        }

        private void ConnectData()
        {
            byte[] bytes = new byte[1024*1024];
            SetGame(levelGame);
            try
            {
                while (true)
                {
                    if (networkStream == null)
                    {
                        MessageBox.Show("ns is null");
                        return;
                    }

                    networkStream.Read(bytes, 0, bytes.Length);
                    object obj = Utils.ByteArrayToObject(bytes);

                    if (obj is Question_Client)
                    {
                        // nhận câu hỏi của server
                        GetQuestion(obj);
                        SetChart(0, 0, 0, 0);
                        //SetText(0, pbThoiGian);
                    }

                    if (obj is bool)
                    {
                        // Kiểm tra kết quả 
                        bool KetQua = (bool)obj;
                        StopMusic();
                        GetResults(KetQua);
                    }

                    if (obj is Cons)
                    {
                        //nhận biểu đồ thống kê kết quả
                        GetChart(obj);
                    }
                    if (obj is string)
                    {
                        // Nhận thông báo chiến thắng nếu có
                        GetNotificationToWin(obj);
                    }
                    if(obj is int)
                    {
                        GetNumberPeople(obj);
                    }    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No longer connected to the server "+ ex.Message);
               Tmr_Gamer_Progress.Enabled = false;
                networkStream.Close();
            }
        }

        private void GetNumberPeople(object obj)
        {
            SetText((int)obj, numberPeopleWacthing1);
        }

        Cons cons = null;
        // Hàm nhận thông báo chiến thắng từ server
        private void GetNotificationToWin(object obj)
        {
            string ThongBao = (string)obj;
            SetText(ThongBao, PcbWinner);
            MessageBox.Show(ThongBao);
        }
        // Hàm nhận biểu đồ thông kê kết quả
        private void GetChart(object obj)
        {
            cons = (Cons)obj;
            SetChart(cons.AnswerA, cons.AnswerB, cons.AnswerC, cons.AnswerD);
        }
        // Hàm nhận kết quả câu hỏi
        private void GetResults(bool result)
        {
            if (result)
            {
                foreach (UCAnswerBox uc in LstAnswer)
                {
                    if (uc.isAnswerCorrect)
                    {
                        uc.Fillcolor = Color.Green;
                        x += 10;
                        ListAudio[1].controls.play();
                        MessageBox.Show("Đáp Án Chính Xác ");
                    }
                }
            }
            else
            {
                foreach (UCAnswerBox uc in LstAnswer)
                {
                    if (uc.isAnswerCorrect)
                    {
                        uc.Fillcolor = Color.Red;
                        ListAudio[2].controls.play();
                        MessageBox.Show("Sai Đáp Án ");
                    }
                }
            }
        }

        Question_Client question = null;
        // hàm nhận câu hỏi
        int levelGame = 1;
        string win = "Bạn là người chiến thắng";
        private void GetQuestion(object obj)
        {
            // tạo câu hỏi client
            question = (Question_Client)obj;
            // set câu hỏi client vào lblQuestion
            SetText(question.Content, lblQuestion);
            int i = 0;
            levelGame = question.id;
            // Set đáp an client vào đáp án.
            foreach (UCAnswerBox item in LstAnswer)
            {
                SetText(question.listAnswer[i], item);
                i++;
                item.Fillcolor = Color.Turquoise;
                SetText(levelGame, item);
                
            }
            
            Setcolor_LevelGame(question.id);
            //ucAnswerC.Show();
            //SetGame(question.id);
            // Check or uncheck đáp án.
            SetText(win, PcbWinner);
            SetText(question.NumberPeople, numberPeopleWacthing1);
            UnCheck(LstAnswer);
        }
        void SetGame(int level)
        {
             if (5<level && level <9)
            {
                ucAnswerC.Show();

            }
            else if (8<level && level <12)
            {
                ucAnswerD.Show();
            }
        }
        // Uncheck đáp án. Set text lại
        private void UnCheck(List<UCAnswerBox> lstAnswer)
        {
            foreach (UCAnswerBox uc in lstAnswer)
            {
                SetText(lstAnswer, uc);
            }
        }
        private void EnabledUcAnswer(bool v)
        {
            foreach (UCAnswerBox uc in LstAnswer)
            {
                SetText(v, uc);
            }
        }
        delegate void SetTextCallback(object obj, Control ctrl);
        // Set text set các text theo vị trí
        private void SetText(object obj, Control ctrl)
        {
            // InvokeRequired required compares the thread ID of the

            // calling thread to the thread ID of the creating thread.

            // If these threads are different, it returns true.

            if (ctrl.InvokeRequired)

            {

                SetTextCallback d = new SetTextCallback(SetText);

                ctrl.Invoke(d, new object[] { obj, ctrl });

            }
            else

            {
                if (ctrl is Label)
                {
                    this.lblQuestion.Text = "";
                    this.lblQuestion.Text = (string)obj;
                    Tmr_Gamer_Progress.Enabled = true;
                    Tmr_Gamer_Progress.Start();
                    ProgressTimeGame.Value = 0;
                    lblPoint.Text = x.ToString();
                    StopMusic();
                    TimerAudio.Start();
                    TimerAudioWin.Stop();
                    TimeGameLoad.Stop();
                }

                else if (ctrl is UCAnswerBox)
                {
                    UCAnswerBox uc = (UCAnswerBox)ctrl;
                    if (obj is string)
                    {
                        uc.Content_Ans = (string)obj;
                    }
                    else if (obj is bool)
                    {
                        uc.Enabled = (bool)obj;
                    }
                    else if (obj is List<UCAnswerBox>)
                    {
                        uc.isAnswerCorrect = false;
                    }
                    else if (obj is int)
                    {
                        if (uc == ucAnswerC)
                        {
                            if (levelGame > 5 && levelGame < 9)
                                uc.Show();
                        }
                        else if (uc == ucAnswerD)
                            if (levelGame > 8 && levelGame < 12)
                                uc.Show();
                    }

                }
                else if (ctrl is PictureBox)
                {
                    if ((string)obj == win)
                        PcbWinner.Hide();
                    else
                    {
                        PcbWinner.Show();
                        StopMusic();
                        TimerAudioWin.Start();
                    }
                }

                else if (ctrl is numberPeopleWacthing)
                {
                    int number = (int)obj;
                    numberPeopleWacthing1.Number = number;
                }
                else if (ctrl is Guna2CircleProgressBar)
                {
                    try
                    {
                        int value = (int)obj;
                        ProgressTimeGame.Value = value;

                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                }


            }
        }
        void StopMusic()
        {
            for (int i = 0; i < ListAudio.Count; i++)
            {
                ListAudio[i].controls.stop();
            }
        }
        delegate void SetChartCallback(int a, int b, int c, int d);

        private void SetChart(int v1, int v2, int v3, int v4)
        {
            if (this.chart1.InvokeRequired)
            {

                SetChartCallback chart = new SetChartCallback(SetChart);

                this.Invoke(chart, new object[] { v1, v2, v3, v4 });

            }

            else
            {
                fillChart(v1, v2, v3, v4);
            }
        }

        private void fillChart(int v1, int v2, int v3, int v4)
        {
            chart1.Series["Number Respondents"].Points.Clear();
            chart1.Series["Number Respondents"].Points.AddXY("A", v1);
            chart1.Series["Number Respondents"].Points.AddXY("B", v2);
            chart1.Series["Number Respondents"].Points.AddXY("C", v3);
            chart1.Series["Number Respondents"].Points.AddXY("D", v4);
        }

        private void SetPersonal()
        {
            StreamReader sr = new StreamReader(filePath);
            string line = null;
            while ((line = sr.ReadLine()) != null)
            {
                if (line.StartsWith("!"))
                {
                    personal.Age = line.Substring(1);
                }
                else if (line.StartsWith("@"))
                {
                    personal.Name = line.Substring(1);
                }

                else if (line.StartsWith("#"))
                {
                    personal.IP = line.Substring(1);
                }
                else if (line.StartsWith("$"))
                {
                    personal.Username = line.Substring(1);
                }
            }
            lblThongTin.Text ="Tên Đăng Nhập: " + personal.Username + "\nHọ Tên : " + personal.Name + "\nTuổi : " + personal.Age   ;
            
            sr.Close();

            File.WriteAllText(filePath, String.Empty);

        }


        private void Playgame_ClientSizeChanged(object sender, EventArgs e)
        {
            pnlLeft.Width = this.Width - pnlRight.Width;
        }
        int timer = 0;
        private void tmr_Total_Tick(object sender, EventArgs e)
        {
            timer++;
            string total = "FIREWALL VIETNAMSES                            ";
            if(timer<total.Length)
                for(int i=timer-1;i<timer;i++)
                {
                    lblTotal.Text += total[i];
                    lblTotal.ForeColor = Color.Coral;
                }
            if (timer == total.Length)
            {
                lblTotal.Text = "";
                timer = 0;
            }
        }
        int Time = 0;
        string Results = null;
        int Xtime = 0;
        void Setcolor_LevelGame(int level)
        {
            for(int i=0;i<level;i++)
            {
                buttonlevel[i].FillColor = Color.Green;
            }
            buttonlevel[level-1].FillColor = Color.Blue;
        }
        private void Tmr_Gamer_Progress_Tick(object sender, EventArgs e)
        {
            if(ProgressTimeGame.Value == ProgressTimeGame.Maximum)
            {
                SendResult();
                Tmr_Gamer_Progress.Enabled = false;
                Time = 0;
                // Kích hoạt đáp án
                EnabledUcAnswer(true);
                Xtime = 0;
                lblTimeProgress.Text = "0%";
                TimerAudio.Stop();
                
                // SetText(0, ProgressTimeGame);
            }
            else
            {
                Results = null;
                foreach (UCAnswerBox uc in LstAnswer)
                {
                    if (uc.isAnswerCorrect)
                    {
                        Results += uc.Content_Ans;
                    }
                }
                if(Results !=null)
                {
                    foreach (UCAnswerBox uc in LstAnswer)
                    {
                        if (!uc.isAnswerCorrect)
                        {
                            uc.Enabled = false; 
                        }
                    }

                }
                if (Results == null)
                {
                    Results = "";
                }
                Time++;
                lblTimeProgress.Text = lblTimeProgress.Text.Substring(0, lblTimeProgress.Text.Length-1);
                Xtime = int.Parse(lblTimeProgress.Text);
                Xtime += 5;
                lblTimeProgress.Text = Xtime.ToString()+"%";
                //int x = int.Parse(lblGame.Text) - 1;
                // SetText(Time, ProgressTimeGame);
                ProgressTimeGame.Increment(1);

            }
        }
        // gửi đáp án
        private void SendResult()
        {
            byte[] byteTime = Utils.ObjectToByteArray(Results);
            Tmr_Gamer_Progress.Stop();
            networkStream.Write(byteTime, 0, byteTime.Length);
        }

        private void Playgame_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(client!=null)
            client.Close();
            networkStream.Close();
        }

        private void TimerAudio_Tick(object sender, EventArgs e)
        {
            ListAudio[4].controls.play();

        }

        private void TimerAudioWin_Tick(object sender, EventArgs e)
        {
            ListAudio[3].controls.play();
        }

        private void TimeGameLoad_Tick(object sender, EventArgs e)
        {
            ListAudio[5].controls.play();
        }
    }
}

using DTOProject.DTO;
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
using DTOProject;
using System.Net.Sockets;
using MyLib;
using System.Threading;
using System.Net;

namespace Sever
{
    public partial class MC_HL : Form
    {

        List<Question> listQuestion = new List<Question>();
        string filePath = "../../question.txt";
        int indexCurrentQuestion = 0;
        int PORT = 9523;

        //IPEndPoint listener;
        TcpListener listener;

        GameShow gameShow = null;

        Thread listen = null;

        NetworkStream netWorkStream;


        public delegate void ConnectPlayer(Player player);
        public event ConnectPlayer connectPlayer;
        public MC_HL()
        {
            InitializeComponent();
            reponsive();
            listQuestion = getListQuestionFromFile();
            setupQuestion(listQuestion[indexCurrentQuestion]);
            Results(listQuestion[indexCurrentQuestion]);
            CheckListQuestion(indexCurrentQuestion);

       

        }
        private void MC_HL_Load(object sender, EventArgs e)
        {
            gameShow = new GameShow();
            
            cons.AnswerA = 0;
            cons.AnswerB = 0;
            cons.AnswerC = 0;
            cons.AnswerD = 0;
            gameShow.LoadListQuestions(listQuestion);
            SetFillChtGame(0, 0, 0, 0);
            question_to_Client.NumberPeople = 0;

        }
        private void CheckListQuestion(int indexCurrentQuestion)
        {
            
            if (indexCurrentQuestion < 6)
            {
                lblAnswerC.Hide();
                labelC.Hide();
                lblAnswerD.Hide();
                labelD.Hide();

            }
            else if (5 < indexCurrentQuestion && indexCurrentQuestion < 9)
            {
                lblAnswerC.Show();
                labelC.Show();
            }
            else if (indexCurrentQuestion > 8)
            {
                lblAnswerC.Show();
                lblAnswerD.Show();
                labelC.Show();
                labelD.Show();

            }

        }

        void Results(Question question)
        {
            lblAnswerD.BackColor = Color.FromArgb(0, 192, 192);
            labelD.BackColor = Color.FromArgb(0, 192, 192);
            lblAnswerC.BackColor = Color.FromArgb(0, 192, 192);
            labelC.BackColor = Color.FromArgb(0, 192, 192);
            lblAnswerB.BackColor = Color.FromArgb(0, 192, 192);
            labelB.BackColor = Color.FromArgb(0, 192, 192);
            lblAnswerA.BackColor = Color.FromArgb(0, 192, 192);
            labelA.BackColor = Color.FromArgb(0, 192, 192);

            if (question.AnswerCorrect == lblAnswerD.Text)
            {
                lblAnswerD.BackColor = Color.FromArgb(128, 255, 128);
                labelD.BackColor = Color.FromArgb(128, 255, 128);
            }    
            else if(question.AnswerCorrect == lblAnswerC.Text)
            {
                lblAnswerC.BackColor = Color.FromArgb(128, 255, 128);
                labelC.BackColor = Color.FromArgb(128, 255, 128);
            }
            else if (question.AnswerCorrect == lblAnswerB.Text)
            {
                lblAnswerB.BackColor = Color.FromArgb(128, 255, 128);
                labelB.BackColor = Color.FromArgb(128, 255, 128);
            }
            else if (question.AnswerCorrect == lblAnswerA.Text)
            {
                lblAnswerA.BackColor = Color.FromArgb(128, 255, 128);
                labelA.BackColor = Color.FromArgb(128, 255, 128);

            }
        }

        //Nhận kết nối từ client
        void Receive_Client()
        {
            LstPlayer = new List<Player>();
            //listener = new IPEndPoint(IPAddress.Any, PORT);
            listener = new TcpListener(IPAddress.Any, PORT);
            listener.Start();


            listen = new Thread(() =>
            {
                try
                {
                    int i = 0;
                    while (true)
                    {
                        i++;
                        Player player = new Player
                        {
                            Id = i,
                            client = listener.AcceptTcpClient()
                        };

                        netWorkStream = player.client.GetStream();
                        // nhận thông tin đăng kí

                        Receive_Register(player);
                        //truyenPlayer(nguoiChoi);
                        //gameShow.ListPlayers.Add(i, nguoiChoi);

                        LstPlayer.Add(player);

                        SetTextNumberPeople(LstPlayer.Count.ToString());
                        question_to_Client.NumberPeople = LstPlayer.Count;
                        Thread th_start = new Thread(Receive_Results);
                        th_start.Start(player);
                        foreach (Player playertemp in LstPlayer)
                        {
                            SendNumberPeople(playertemp);
                        }
                    }
                }
                catch (Exception ex)
                {
                    //listener = new TcpListener(IPAddress.Any, PORT);
                    //listener.Start();
                    //MessageBox.Show(ex.Message);
                }
            });
            listen.Start();
        }

        private void SendNumberPeople(Player player)
        {
            netWorkStream = player.client.GetStream();
            byte[] byteTime = Utils.ObjectToByteArray(LstPlayer.Count);
            netWorkStream.Write(byteTime, 0, byteTime.Length);
        }





        /// <summary>
        /// Get Data question from file question.txt
        /// </summary>
        /// <returns></returns>
        public List<Question> getListQuestionFromFile()
        {
            List<Question> listQuestion = new List<Question>();
            StreamReader sr = new StreamReader(filePath);
            string line = null;
            Question question = null;
            while ((line = sr.ReadLine()) != null)
            {
                if (line.StartsWith("!"))
                {
                    question = new Question();
                    question.Id = line.Substring(1);
                }
                else if (line.StartsWith("@"))
                {
                    question.Content = line.Substring(1);
                }
                else if (line.StartsWith("&"))
                {
                    question.listAnswer.Add(line.Substring(1));
                }
                else if (line.StartsWith("#"))
                {
                    question.AnswerCorrect = line.Substring(1);
                }
                else if (line.StartsWith("$"))
                {
                    question.TopicInfor = line.Substring(1);
                    listQuestion.Add(question);
                }
            }
            
            grvListQuestion.DataSource = listQuestion;
            sr.Close();
            return listQuestion;
        }
        public void reponsive()
        {
            ////panel Parent
            //pnlLeft.Width = (int)(this.Width * 0.3);
            //pnLeftBottom.Width = this.Width - pnlLeft.Width;

            ////panel chirld 1
            //pnlLeftTop.Height = (int)(this.Height * 0.48); //panel list question
            //pnlRightBottom.Height = (int)(this.Height * 0.52);  //panel Rank

            //pnlRightTop.Height = (int)(this.Height * 0.44); //Camera and Topic information of question
            //pnlCamera.Width = (int)(pnlRightTop.Width * 0.5);

            ////Setup localtion of pnlContainsQuestion
            //int newLocalX = pnLeftBottom.Width - pnlContainsQuestion.Width;
            //pnlContainsQuestion.Location = new Point(newLocalX / 2, pnlContainsQuestion.Location.Y);


        }

        public void setupQuestion(Question question)
        {
            int indexAnswer = 0;
            lblQuestion.Text = "Question " + question.Id + ": " + question.Content;
            lblTopicInfor.Text = question.TopicInfor;

            for (int i = 0; i < 4; i++)
            {
                Label lbl = (Label)pnlAnswerGroup.Controls[i + 4];
                lbl.Text = question.listAnswer[indexAnswer++];
            }
            question_to_Client.id = int.Parse(question.Id);
            question_to_Client.Content = question.Content;
            question_to_Client.listAnswer.Clear();
            question_to_Client.listAnswer.AddRange(question.listAnswer);
        }

        private void MC_UI_SizeChanged(object sender, EventArgs e)
        {
            reponsive();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            cons.AnswerA = 0;
            cons.AnswerB = 0;
            cons.AnswerC = 0;
            cons.AnswerD = 0;
            SetChtGame(cons.AnswerA, cons.AnswerB, cons.AnswerC, cons.AnswerD);
            if (indexCurrentQuestion < listQuestion.Count - 1)
            {
                indexCurrentQuestion++;
                setupQuestion(listQuestion[indexCurrentQuestion]);
                Results(listQuestion[indexCurrentQuestion]);
                btnSend.Enabled = true;
            }
            else
                MessageBox.Show("You have run out of questions!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            CheckListQuestion(indexCurrentQuestion);
            gameShow.Statistics_Results();
            foreach (Player player in LstPlayer)
            {
                // thống kê trong danh sách thông kê
                foreach (Statistics_Results statistics in gameShow.listStatistics)
                {
                    // so sánh id người chơi với id thống kê
                    if (player.Id == statistics.ID)
                    {
                        statistics.Name = player.Name;

                    }
                }
            }
            GridRank.DataSource = gameShow.listStatistics;
        }
        Cons cons = new Cons();
        int count = 1;
        List<Player> LstPlayer = null;
        Question_Client question_to_Client = new Question_Client();

        private void btnSend_Click(object sender, EventArgs e)
        {
            // Set biểu đồ
            cons.AnswerA = 0;
            cons.AnswerB = 0;
            cons.AnswerC = 0;
            cons.AnswerD = 0;
            SetChtGame(cons.AnswerA, cons.AnswerB, cons.AnswerC, cons.AnswerD);            
            // kiểm tra danh sách người chơi
            if (LstPlayer != null)
            {
                // kiểm tra số lượng người chơi
                if (LstPlayer.Count > 0)
                {
                    try
                    {
                        //kiểm tra câu hỏi hiện tại
                        if (listQuestion[indexCurrentQuestion] != null) //chỉnh sửa
                        {
                            //gửi câu hỏi cho các player
                            //Lấy item của người chơi từ LstPlayer
                            foreach (Player item in LstPlayer)
                            {
                                netWorkStream = item.client.GetStream();
                                //Gửi câu hỏi
                                try
                                {

                                    SendQuestion();

                                }
                                //Nếu lõi thì xóa item đó
                                catch
                                {
                                    LstPlayer.Remove(item);
                                    item.client.Close();
                                    //Set lại số lượng người chơi
                                    SetTextNumberPeople(LstPlayer.Count.ToString());
                                    question_to_Client.NumberPeople = 0;
                                    foreach (Player playertemp in LstPlayer)
                                    {
                                        SendNumberPeople(playertemp);
                                    }
                                    //question_to_Client.NumberPeople = LstPlayer.Count;
                                }
                            }
                              TimeGamer.Enabled = true; 
                            count = 0;
                            btnNext.Enabled = false;
                            btnSend.Enabled = false;
                            btn_SendChtGame.Enabled = false;
                            
                        }
                        else
                        {
                            //Thôi báo chưa có câu hỏi
                            MessageBox.Show("You not checked to Question", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                    }
                    catch
                    {
                        // Set số lượng người tham gia về 0
                        LstPlayer.Clear();
                        SetTextNumberPeople("0");
                        question_to_Client.NumberPeople = 0;
                       

                    }
                }

                else
                {
                    //Thông báo chưa có client kết nối
                    MessageBox.Show("No client connected\nCan you check it again?", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else
            {
                MessageBox.Show("No client connected\nCan you check it again?", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        // đếm số người có cùng đáp án. Để thống kê kết quả.
        private void CountSameResults(string results)
        {
            for (int i = 0; i < listQuestion[indexCurrentQuestion].listAnswer.Count; i++)
            {
                if (results == listQuestion[indexCurrentQuestion].listAnswer[i])
                {
                    switch (i)
                    {
                        case 0:
                            cons.AnswerA++;
                            break;
                        case 1:
                            cons.AnswerB++;
                            break;
                        case 2:
                            cons.AnswerC++;
                            break;
                        case 3:
                            cons.AnswerD++;
                            break;
                    }

                }
            }
        }
        // Giảm số người có cùng đáp án. Khi client thoát giảm xuống 1
        private void ReductSameResults(string results)
        {

            for (int i = 0; i < listQuestion[indexCurrentQuestion].listAnswer.Count; i++)
            {
                if (results == listQuestion[indexCurrentQuestion].listAnswer[i])
                {

                    switch (i)
                    {
                        case 0:
                            cons.AnswerA--;
                            break;
                        case 1:
                            cons.AnswerB--;
                            break;
                        case 2:
                            cons.AnswerC--;
                            break;
                        case 3:
                            cons.AnswerD--;
                            break;
                    }
                }
            }
        }

        // gửi câu hỏi
        private void SendQuestion()
        {
            byte[] byteTime = Utils.ObjectToByteArray(question_to_Client);
            netWorkStream.Write(byteTime, 0, byteTime.Length);
        }
        // Gửi đáp án cho client
        private void SendResults(bool results, Player player)
        {
            netWorkStream = player.client.GetStream();
            byte[] byteTime = Utils.ObjectToByteArray(results);
            netWorkStream.Write(byteTime, 0, byteTime.Length);
        }

        delegate void SetTextCallback(string text);

        private void SetTextNumberPeople(string TextNumberPeople)
        {
            // set số lượng người đang tham gia trò chơi
            if (this.numberPeopleWacthing1.InvokeRequired)

            {

                SetTextCallback d = new SetTextCallback(SetTextNumberPeople);

                this.Invoke(d, new object[] { TextNumberPeople });

            }

            else

            {
                this.numberPeopleWacthing1.Number = int.Parse(TextNumberPeople);
            }
        }

        delegate void SetChtGameCallBack(int a, int b, int c, int d);
        // Set biểu đồ người chơi
        void SetChtGame(int answerA, int answerB, int answerC, int answerD)
        {


            if (this.ChtGame.InvokeRequired)

            {

                SetChtGameCallBack ChtGame = new SetChtGameCallBack(SetChtGame);

                this.Invoke(ChtGame, new object[] { answerA, answerB, answerC, answerD });

            }

            else
            {
                SetFillChtGame(answerA, answerB, answerC, answerD);
            }
        }
        // set thống kê khi có số người trả lời câu hỏi
        private void SetFillChtGame(int answerA, int answerB, int answerC, int answerD)
        {
            if (ChtGame.Series["NumberRespondents"].Points.Count != 0)
            {
                ChtGame.Series["NumberRespondents"].Points.Clear();
            }
            ChtGame.Series["NumberRespondents"].Points.AddXY("A", answerA);
            ChtGame.Series["NumberRespondents"].Points.AddXY("B", answerB);
            ChtGame.Series["NumberRespondents"].Points.AddXY("C", answerC);
            ChtGame.Series["NumberRespondents"].Points.AddXY("D", answerD);
        }

        void SendChtGame()
        {
            byte[] byteTime = Utils.ObjectToByteArray(cons);
            foreach (Player player in LstPlayer)
            {
                netWorkStream = player.client.GetStream();
                netWorkStream.Write(byteTime, 0, byteTime.Length);
            }
        }
        private void btn_SendChtGame_Click(object sender, EventArgs e)
        {
            byte[] byteTime = Utils.ObjectToByteArray(cons);
            foreach (Player player in LstPlayer)
            {
                netWorkStream = player.client.GetStream();
                netWorkStream.Write(byteTime, 0, byteTime.Length);
            }
            //SendChtGame(LstPlayer, cons);
        }
        // Gửi biểu đồ thống kê 
        private void SendChtGame(List<Player> LstPlayer, Cons cons)
        {
            foreach (Player player in LstPlayer)
            {
                netWorkStream = player.client.GetStream();
                byte[] byteTime = Utils.ObjectToByteArray(cons);
                netWorkStream.Write(byteTime, 0, byteTime.Length);
            }

        }
        // Thống kê kết quả click
        private void btnStatistics_Click(object sender, EventArgs e)
        {
            gameShow.Statistics_Results();
            // người chơi trong danh sách người chơi
            foreach (Player player in LstPlayer)
            {
                // thống kê trong danh sách thông kê
                foreach (Statistics_Results statistics in gameShow.listStatistics)
                {
                    // so sánh id người chơi với id thống kê
                    if (player.Id == statistics.ID)
                    {
                        statistics.Name = player.Name;
                        
                    }
                }
            }
            GridRank.DataSource = gameShow.listStatistics;
            btnWinGame.Enabled = true;
        }
        //thông báo thắng cuộc click
        int WinGame = 0;
        private void btnWinGame_Click(object sender, EventArgs e)
        {
            List<string> ListWinGame = new List<string>();
            // id trong danh sách điểm cao 
            gameShow.ListHighCore.Sort();
            foreach (int id in gameShow.ListHighCore)
            {
                // người choi trong danh sách người chơi
                foreach (Player player in LstPlayer)
                {
                    // nếu id người chơi trùng với id điểm cao thì gửi kết quả chiến thắng
                    if (player.Id == id)
                    {
                        for (int i = 0; i <gameShow.ListHighCore.Count; i++)
                        { if (gameShow.ListHighCore[i] == id)
                            {
                                WinGame = i+1;
                                SendWinGame(player);
                                ListWinGame.Add(player.Name);
                            }
                        }
                    }
                }
            }
            WinGame FrmWin = new WinGame(ListWinGame);
            FrmWin.Show();
        }
        // Gửi thông báo thắng cuộc
        private void SendWinGame(Player player)
        {
            string ThongBao = "Bạn Đã Đạt Giải "+WinGame.ToString()+" ! Victory is yours !!!!";
            netWorkStream = player.client.GetStream();
            byte[] byteTime = Utils.ObjectToByteArray(ThongBao);
            netWorkStream.Write(byteTime, 0, byteTime.Length);
        }

        // Nhận đăng kí của client
        private void Receive_Register(Player player)
        {
            byte[] bytes = new byte[1024];
            netWorkStream.Read(bytes, 0, bytes.Length);
            player.Name = (string)Utils.ByteArrayToObject(bytes);
        }
        // Nhận đáp án của client 
        private void Receive_Results(Object obj)
        {
            byte[] bytes = new byte[1024];

            Player player = (Player)obj;

            try
            {
                while (true)
                {

                    netWorkStream = player.client.GetStream();
                    netWorkStream.Read(bytes, 0, bytes.Length);
                    string Results = (string)Utils.ByteArrayToObject(bytes);

                    //gameShow.CheckAnswer(nguoiChoi.ID, CauHoiHienTai.ID, DapAn);

                    //chỉnh sửa
                    lock (this)
                    {
                        //int.Parse(listQuestion[indexCurrentQuestion].Id)
                        gameShow.CheckAnswer(Results, player.Id, int.Parse(listQuestion[indexCurrentQuestion].Id));
                        foreach (Point_Player point_Player in gameShow.lstPointUser[player.Id])
                        {
                            if (point_Player.Question_Id == int.Parse(listQuestion[indexCurrentQuestion].Id))
                            {
                                if (player.client.Connected)
                                {
                                    bool results = point_Player.Result;
                                    try
                                    {
                                        //Gửi kết quả cho client
                                        SendResults(results, player);
                                        // Số đáp án giống nhau
                                        CountSameResults(Results);
                                        //Set biểu đồ game
                                        SetChtGame(cons.AnswerA, cons.AnswerB, cons.AnswerC, cons.AnswerD);
                                        SendChtGame();
                                    }
                                    catch
                                    {
                                        // đóng client 
                                        player.client.Close();
                                        // Remove client không tham gia nữa
                                        LstPlayer.Remove(player);
                                        //Gọi hàm set lại số người chơi
                                        SetTextNumberPeople(LstPlayer.Count.ToString());
                                        question_to_Client.NumberPeople=LstPlayer.Count;
                                        foreach (Player playertemp in LstPlayer)
                                        {
                                            SendNumberPeople(playertemp);
                                        }
                                        // Giảm đi 1 kết quả vì có 1 client thoát
                                        ReductSameResults(Results);
                                        //Set lại biểu đồ game
                                        SetChtGame(cons.AnswerA, cons.AnswerB, cons.AnswerC, cons.AnswerD);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                player.client.Close();
                LstPlayer.Remove(player);
                SetTextNumberPeople(LstPlayer.Count.ToString());
                question_to_Client.NumberPeople = LstPlayer.Count;
                foreach (Player playertemp in LstPlayer)
                {
                    SendNumberPeople(playertemp);
                }
            }
        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            Receive_Client();
            btnLogo.Enabled = false;
        }
        int Time = 20;
        private void TimeGamer_Tick(object sender, EventArgs e)
        {
            if (count > Time)
            {
                TimeGamer.Enabled = false;
                //chỉnh sửa
                btnNext.Enabled = true;
                btn_SendChtGame.Enabled = true;
            }
            else
            {
                count++;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            btnStatistics.Click += btnStatistics_Click;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            btnWinGame.Click+=btnWinGame_Click;
        }

        private void pnlContainsQuestion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlRight_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
        
    

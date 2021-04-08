using DTOProject.DTO;
using MyLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace client
{
    public partial class Personal : Form
    {
        string filePath = "../../TxtPersonal.txt";
        delegate void SetTextCallback(string text);
        WindowsMediaPlayer PlayGameAudio = new WindowsMediaPlayer();
        int PORT = 9523;

        //TcpListener listener;

        TcpClient client = new TcpClient();

        NetworkStream networkStream;

        Thread thread = null;
        public Personal()
        {
            InitializeComponent();
            PlayGameAudio.URL = "FireWallGame.mp3";
            TimeAudioGame.Start();
        }
        CLPersonal Personal_ = new CLPersonal();
        public delegate void GetNetworkStream(NetworkStream networkStream, TcpClient client);
        public event GetNetworkStream getNetworkStream;
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (txtAge.Text != "" && txtName.Text != "" && txtIP.Text != "" && txtUserName.Text != "")
            {

                Personal_.Age = txtAge.Text;
                Personal_.Name = txtName.Text;
                Personal_.IP = txtIP.Text;
                Personal_.Username = txtUserName.Text;

                SavePersonal(Personal_);
                // Nếu kết nối tới server thành công 

            }
            else if (txtIP.Text.Length < 7)
            {
                MessageBox.Show("Tối Thiểu 8 kí tự. Nếu không biết xin hãy nhập : '127.0.0.1'", "Nhập sai định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (int.Parse(txtAge.Text) > 101 || int.Parse(txtAge.Text) < 10)
            {
                MessageBox.Show("Số tuổi của bạn không đủ chuẩn. Bạn phải ít nhất 10 tuổi và cao nhất là 100 tuổi xin cảm ơn!!! ", "Nhập sai định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Người chơi chưa nhập thành công thông tin
            else
            {
                MessageBox.Show("Thông Tin Thiếu Xin Kiểm Tra Lại", "personal information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // nếu kết nối server thành công
            if (ConnectServer())
            {
                //object obj = new Player();
                //ConnectData(obj);
                try
                {

                    // Gửi thông tin  đăng kí cho serverr 

                    SendRegister(Personal_);
                    Playgame frmPlay = new Playgame(this);

                    getNetworkStream(networkStream, client);
                    TimeAudioGame.Stop();
                    PlayGameAudio.controls.stop();

                    frmPlay.ShowDialog();

                }
                //NẾu lỗi thông báo lỗi
                catch (Exception ex)
                {
                    MessageBox.Show("Error in connect to server" + ex.Message);
                    return;
                }

                //this.Close();
            }
            else return;
            this.Close();

        }

        private void SendRegister(CLPersonal personal_)
        {
            byte[] byteTime = Utils.ObjectToByteArray(personal_.Username);

            networkStream.Write(byteTime, 0, byteTime.Length);
        }
        // Hàm kết nối server
        private bool ConnectServer()
        {
            try
            {
                client.Connect(IPAddress.Parse(Personal_.IP), PORT);
                networkStream = client.GetStream();
                // Nếu networkStrem của client đến server không thành công 
                // Server chưa mở thì thong báo k thể kết nối
                if (networkStream == null)
                {
                    MessageBox.Show("Không thể kết nối Server", "Warring ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                return true;
            }
            // Nếu sảy ra lỗi thì thông báo k thể kết nối.
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message , "Warning ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            return false;
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 170 && e.KeyChar != 8 && e.KeyChar !=46)
            {
                e.Handled = true;
                MessageBox.Show("Xin hãy nhập số", "Nhập sai định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
               
        }
        private void txtNumberIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 170 && e.KeyChar != 8 && e.KeyChar != 46 )
            {
                e.Handled = true;
                MessageBox.Show("Xin hãy nhập số", "Nhập sai định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

          
        }
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLower(e.KeyChar) && e.KeyChar != 32 && e.KeyChar != 8 && e.KeyChar != 14 && e.KeyChar != 15 && !char.IsUpper(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Bạn chỉ có thể nhập chữ!", "Nhập sai định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool SavePersonal(CLPersonal personal)//Save quetion to file question.txt
        {
            StreamWriter sw = new StreamWriter(filePath, true);
            sw.WriteLine("!" + personal.Age);
            sw.WriteLine("@" + personal.Name);
            sw.WriteLine("#" + personal.IP);
            sw.WriteLine("$" + personal.Username);
            sw.Close();
            return true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TimeAudioGame_Tick(object sender, EventArgs e)
        {
            PlayGameAudio.controls.play();
        }
    }
}

using DTOProject.DTO;
using Guna.UI2.WinForms;
using MyLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Sever
{
    public partial class QuanLyLichTrinh : Form
    {
        string fileSchedulePath = "../../../Schedule_Game.txt";
        List<GameShow> listGameShow = new List<GameShow>();
        int numColumSort = 0;
        int currentColum = -1 , currentRow = -1;
        int rowEdit = -1;
       

        #region Check Function
        private bool checkIdNotExists(string id)
        {
            foreach (var game in listGameShow)
            {
                if (String.Equals(id, game.ID)) return false;
            }
            return true;
        }
        #endregion


        public QuanLyLichTrinh()
        {
            InitializeComponent();
            refreshForm();
            btnSave.Hide();
            listGameShow = getScheduleFromFile(fileSchedulePath, numColumSort);
            pnlLeftBottom.Height = this.Height - pnlLeftTop.Height;
            pnlRight.Width = this.Width - pnlLeft.Width;
            txtID.Select();
        }


        /// <summary>
        /// Get information gameshow from form input
        /// </summary>
        /// <returns></returns>
        public GameShow getGameShowFromForm()
        {
            if (checkInputSchedule())
            {
                GameShow game = new GameShow();
                game.ID = txtID.Text;
                game.Name = txtName.Text;
                game.StartTime = dtmStart.Value;
                game.EndTime = dtmEnd.Value;
                game.NumberPlayer = (int)nudNumberPlayer.Value;
                return game;
            }
            return null;
        }
        private bool checkInputSchedule()
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("You forgot to enter the ID for the gameshow!!", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtID.Focus();
                return false;
            }

            //ID already exists
            else if (!checkIdNotExists(txtID.Text))
            {
                MessageBox.Show("ID already exists!!", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtID.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("You forgot to enter the name for the gameshow!!", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtID.Focus();
                return false;
            }

            else if (dtmStart.Value < DateTime.Now)
            {
                MessageBox.Show("Start time is invalid!!", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtmStart.Focus();
                return false;
            }
            else if (dtmEnd.Value < DateTime.Now || dtmEnd.Value < dtmStart.Value)
            {
                MessageBox.Show("End time is invalid!!", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtmEnd.Focus();
                return false;
            }
            else if (nudNumberPlayer.Value <= 0)
            {
                MessageBox.Show("Number player is invalid!!", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nudNumberPlayer.Focus();
                return false;
            }
            return true;
        }

        /// <summary>
        /// Save quetion to file
        /// </summary>
        /// <param name="fileSchedulePath">Path to file save</param>
        /// <param name="game"></param>
        /// <returns></returns>
        private bool SaveGameShow(string fileSchedulePath,GameShow game)
        {
            StreamWriter sw = new StreamWriter(fileSchedulePath, true);
            sw.WriteLine("!" + game.ID);
            sw.WriteLine("@" + game.Name);
           
            sw.WriteLine("#" +game.StartTime);
            sw.WriteLine("$" + game.EndTime);
            sw.WriteLine("%" + game.NumberPlayer);
            sw.Close();
            return true;
        }

        /// <summary>
        /// Reset textboxs in form input question
        /// </summary>
        public void refreshForm()
        {
            txtID.Text = "";
            txtName.Text = "";
            dtmStart.Value = dtmEnd.Value = DateTime.Now;
            nudNumberPlayer.Value = 0;
        }



        /// <summary>
        /// Get Data question from pathFile.
        /// numColumSort : type sort (0:ID, 1:Name, 2:StartTime, 3:EndTime, 4:NumberPlayer)
        /// </summary>
        /// <param name="pathFile"></param>
        /// <param name="numColumSort"></param>
        /// <returns></returns>
        public List<GameShow> getScheduleFromFile(string pathFile,int numColumSort) 
        {
            StreamReader sr = new StreamReader(pathFile);
            List<GameShow> listGameShow = new List<GameShow>();
            string line = null;
            GameShow game = null;
            while ((line = sr.ReadLine()) != null)
            {
                if (line.StartsWith("!"))
                {
                    game = new GameShow();
                    game.ID = line.Substring(1);
                }
                else if (line.StartsWith("@"))
                {
                    game.Name = line.Substring(1);
                }
                else if (line.StartsWith("#"))
                {
                    game.StartTime = DateTime.Parse(line.Substring(1));
                }
                else if (line.StartsWith("$"))
                {
                    game.EndTime = DateTime.Parse(line.Substring(1));
                }
                else if (line.StartsWith("%"))
                {
                    game.NumberPlayer = int.Parse(line.Substring(1));
                    listGameShow.Add(game);
                }
            }
            Utils.sortSchedule(listGameShow, numColumSort);
            grvSchedule.DataSource = listGameShow;
            sr.Close();
            return listGameShow;


        }

        /// <summary>
        /// Set up schedule a gameshow into the form
        /// </summary>
        /// <param name="game"></param>
        public void setDataIntoForm(GameShow game)
        {
            txtID.Text = game.ID;
            txtName.Text = game.Name;
            dtmStart.Value = game.StartTime;
            dtmEnd.Value = game.EndTime;
            nudNumberPlayer.Value = game.NumberPlayer;
        }


        /// <summary>
        /// Save ListGameShow to file, simultaneously update dataGridView Schedule
        /// </summary>
        /// <param name="filePath"></param>
        public void saveListGameShow(string filePath)
        {
            File.WriteAllText(fileSchedulePath, String.Empty);  //Reset data in file
            listGameShow.ForEach(game =>    //Re-Save current listGameShow
            {
                SaveGameShow(fileSchedulePath, game);
            });
            listGameShow = getScheduleFromFile(fileSchedulePath, numColumSort); //update ListGameShow from the file
            grvSchedule.DataSource = listGameShow;
        }



        private void ScheduleManagement_SizeChanged(object sender, EventArgs e)
        {
            pnlLeftBottom.Height = this.Height - pnlLeftTop.Height;
            pnlRight.Width = this.Width - pnlLeft.Width;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            GameShow game = getGameShowFromForm();

            if (game != null)
            {
                bool saveFinish = SaveGameShow(fileSchedulePath,game);
                if (saveFinish)
                {
                    refreshForm();
                    getScheduleFromFile(fileSchedulePath,numColumSort);
                }
            }
        }
        private void grvSchedule_CellClick(object sender, DataGridViewCellEventArgs e) 
        {
            currentColum = e.ColumnIndex;
            currentRow = e.RowIndex;
            // click the first cell of the ID column
            if (currentRow == -1 && currentColum == 0)  
            {
                numColumSort = 0;
                getScheduleFromFile(fileSchedulePath, numColumSort);
            }
            // click the first cell of the Name column
            else if (currentRow == -1 && currentColum == 1)
            {
                numColumSort = 1;
                getScheduleFromFile(fileSchedulePath, numColumSort);
            }
            // click the first cell of the StartTime column
            else if (currentRow == -1 && currentColum == 2)
            {
                numColumSort = 2;
                getScheduleFromFile(fileSchedulePath, numColumSort);
            }
            // click the first cell of the EndTime column
            else if (currentRow == -1 && currentColum == 3)
            {
                numColumSort = 3;
                getScheduleFromFile(fileSchedulePath, numColumSort);
            }
            // click the first cell of the NumberPlayer column
            else if (currentRow == -1 && currentColum == 4)
            {
                numColumSort = 4;
                getScheduleFromFile(fileSchedulePath, numColumSort);
            }
            //Click on the data cells of the table
            if (currentRow > -1)
            {
                btnEdit.Enabled = true;
                setDataIntoForm(listGameShow[currentRow]);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshForm();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
                var result = MessageBox.Show("Edit broadcast schedule", "Do you want edit broadcast schedule??", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                btnAdd.Show();
                btnSave.Hide();
                GameShow game = new GameShow() //Tạo game show mới từ form
                {
                    ID = txtID.Text,
                    Name = txtName.Text,
                    StartTime = dtmStart.Value,
                    EndTime = dtmEnd.Value,
                    NumberPlayer = (int)nudNumberPlayer.Value
                };
                listGameShow[rowEdit] = game;   //Change data gameshow selected in list
                saveListGameShow(fileSchedulePath); //Backup list game show
                grvSchedule.DataSource = listGameShow;
            }
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Remove all", "Do you want remove all question??", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                File.WriteAllText(fileSchedulePath, String.Empty);
                listGameShow = null;
                grvSchedule.DataSource = listGameShow;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnAdd.Hide();//Ẩn
            btnSave.Show();
            rowEdit = currentRow;
        }

        private void ScheduleManagement_Load(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (currentRow != -1 && currentRow < listGameShow.Count)
            {
                listGameShow.RemoveAt(currentRow);
                File.WriteAllText(fileSchedulePath, String.Empty);
                listGameShow.ForEach(game =>
                {
                    SaveGameShow(fileSchedulePath, game);
                });
                listGameShow = getScheduleFromFile(fileSchedulePath, numColumSort);
                grvSchedule.DataSource = listGameShow;
            }
        }
    }
}

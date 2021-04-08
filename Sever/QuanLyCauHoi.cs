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

namespace Sever
{
    public partial class QuanLyCauHoi : Form
    {
        List<Question> listQuestion = new List<Question>();
        string filePath = "../../question.txt";
        int rowEdit = -1;
        int numColumSort = 0;
        int currentRow = -1;
        int currentColum = -1;
        #region Function
        public Question getQuestionFromForm()//Get information question from form input
        {
            if (checkInputQuestion())
            {
                Question question = new Question();
                question.Id = txtId.Text;
                question.Content = txtContent.Text;
                foreach (Control ctl in pnlAnswerGroup.Controls)    //get data answers from 4 UCAnswerBox in pnlAnswerGroup
                {
                    UCAnswerBox uc = (UCAnswerBox)ctl;
                    if (uc.isAnswerCorrect) question.AnswerCorrect = uc.Content;
                    question.listAnswer.Add(uc.Content);
                }
                question.TopicInfor = txtTopicInfor.Text;
                return question;
            }
            return null;
        }
        public Question getQuestionEdit()
        {
            if (checkInputEdit())
            {
                Question question = new Question();
                question.Id = txtId.Text;
                question.Content = txtContent.Text;
                foreach (Control ctl in pnlAnswerGroup.Controls)    //get data answers from 4 UCAnswerBox in pnlAnswerGroup
                {
                    UCAnswerBox uc = (UCAnswerBox)ctl;
                    if (uc.isAnswerCorrect) question.AnswerCorrect = uc.Content;
                    question.listAnswer.Add(uc.Content);
                }
                question.TopicInfor = txtTopicInfor.Text;
                return question;
            }
            return null;
        }
        public List<Question> getListQuestionFromFile() //Get Data question from file question.txt
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

        private List<Question> getListQuestionFromFile(string pathFile, int numColumSort)
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
            Utils.sortQuestion(listQuestion, numColumSort);
            sr.Close();
            return listQuestion;
        }
        private bool SaveQuestion(Question question)//Save quetion to file question.txt
        {
            StreamWriter sw = new StreamWriter(filePath, true);
            sw.WriteLine("!" + question.Id);
            sw.WriteLine("@" + question.Content);
            foreach (string answer in question.listAnswer)
            {
                sw.WriteLine("&" + answer);
            }
            sw.WriteLine("#" + question.AnswerCorrect);
            sw.WriteLine("$" + question.TopicInfor);
            sw.Close();
            return true;
        }
        public void refreshForm()//Reset textboxs in form input question
        {
            txtId.Text = "";
            txtContent.Text = "";
            txtTopicInfor.Text = "";
            ucAnswerBoxA.isAnswerCorrect = false;
            ucAnswerBoxA.Content = "";
            ucAnswerBoxB.isAnswerCorrect = false;
            ucAnswerBoxB.Content = "";
            ucAnswerBoxC.isAnswerCorrect = false;
            ucAnswerBoxC.Content = "";
            ucAnswerBoxD.isAnswerCorrect = false;
            ucAnswerBoxD.Content = "";
            txtTopicInfor.Text = "";
            txtId.Enabled = true;
        }
        public bool checkIdNotExists(string id)
        {
            foreach(var question in listQuestion)
            {
                if (String.Equals(id,question.Id)) return false;
            }
            return true;
        }
        public bool checkHasAnswerCorrect()
        {
            foreach( Control ctl in pnlAnswerGroup.Controls)
            {
                UCAnswerBox uc = (UCAnswerBox)ctl;
                if (uc.isAnswerCorrect) return true;
            }
            return false;
        }
        public bool checkOnlyOneAnswerCorrect()
        {
            int count = 0;
            foreach (Control ctl in pnlAnswerGroup.Controls)
            {
                UCAnswerBox uc = (UCAnswerBox)ctl;
                if (uc.isAnswerCorrect) count++; 
            }
            return count == 1;
        }
        public bool noEmptyAnswer()
        {
            foreach (Control ctl in pnlAnswerGroup.Controls)
            {
                UCAnswerBox uc = (UCAnswerBox)ctl;
                if (string.IsNullOrEmpty(uc.Content)) return false;
            }
            return true;
        }
        public bool checkInputQuestion() //Check whether the question information has been entered sufficiently
        {
            // ID empty
            int i = int.Parse(txtId.Text);
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("You forgot to enter the ID for the question!!", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtId.Focus();
                return false;
            }
            else if(i>11 || i<1)
            {
                MessageBox.Show("ID not bigger 11 and not less than 1 !!", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtId.Focus();
                return false;
            }    
            //ID already exists
            else if (!checkIdNotExists(txtId.Text))
            {
                MessageBox.Show("ID already exists!!", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtId.Focus();
                return false;
            }

            //Content question empty
            else if (string.IsNullOrEmpty(txtContent.Text))
            {
                MessageBox.Show("You forgot to enter content question!!", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContent.Focus();
                return false;
            }

            //Don't have enough 4 answers
            else if (!noEmptyAnswer())
            {
                MessageBox.Show("You don't have enough 4 answers!!", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //Don't have the answer correct
            else if (!checkHasAnswerCorrect())
            {
                MessageBox.Show(" You don't have the answer correct!!", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //Cannot have more than 2 answers
            else if (!checkOnlyOneAnswerCorrect())
            {
                MessageBox.Show("You have more than 2 answers correct!!", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //Don't have topic information for question
            else if (string.IsNullOrEmpty(txtTopicInfor.Text))
            {
                MessageBox.Show("You forgot to enter topic information for question!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTopicInfor.Focus();
                return false;
            }

            return true;
        }
        #endregion
        public bool checkInputEdit()
        {
            // ID empty
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("You forgot to enter the ID for the question!!", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtId.Focus();
                return false;
            }

            //Content question empty
            else if (string.IsNullOrEmpty(txtContent.Text))
            {
                MessageBox.Show("You forgot to enter content question!!", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContent.Focus();
                return false;
            }

            //Don't have enough 4 answers
            else if (!noEmptyAnswer())
            {
                MessageBox.Show("You don't have enough 4 answers!!", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //Don't have the answer correct
            else if (!checkHasAnswerCorrect())
            {
                MessageBox.Show(" You don't have the answer correct!!", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //Cannot have more than 2 answers
            else if (!checkOnlyOneAnswerCorrect())
            {
                MessageBox.Show("You have more than 2 answers correct!!", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //Don't have topic information for question
            else if (string.IsNullOrEmpty(txtTopicInfor.Text))
            {
                MessageBox.Show("You forgot to enter topic information for question!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTopicInfor.Focus();
                return false;
            }

            return true;
        }
        public QuanLyCauHoi()
        {
            InitializeComponent();
            listQuestion = getListQuestionFromFile();
            pnlLeft.Width = this.Width - pnlRight.Width;
            this.WindowState = FormWindowState.Normal;
        }


        #region Event
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshForm();
        }
        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            Question question = getQuestionFromForm();

            if (question != null)
            {
                bool saveFinish = SaveQuestion(question);
                if (saveFinish)
                {
                    refreshForm();
                    listQuestion = getListQuestionFromFile();
                    // listQuestion.Sort();
              
                }
            }
            listQuestion.Sort(delegate (Question x, Question y)
            {
                return x.Id.CompareTo(y.Id);
            });
            saveListQuestion(filePath);
        }
        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you want remove all question??", "Remove all", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                File.WriteAllText(filePath, String.Empty);
                listQuestion = getListQuestionFromFile();
                grvListQuestion.DataSource = listQuestion;
                MessageBox.Show("Remove all successfully!!", "Remove all file", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void QuestionManagement_ClientSizeChanged(object sender, EventArgs e)
        {

            pnlLeft.Width = this.Width - pnlRight.Width;
            //pnlGrv.Height = this.Height - pnlTitle.Height - pnlBtnGroup.Height;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you want Save question??", "Save question", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                btnAddQuestion.Show();
                btnSave.Hide();
                listQuestion[rowEdit] = getQuestionEdit();   //Change data gameshow selected in list
                saveListQuestion(filePath); //Backup list game show
                grvListQuestion.DataSource = listQuestion;
                MessageBox.Show("Save successfully!!", "Save file", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public void setDataToForm(Question question)
        {
            txtId.Text = question.Id.ToString();
            txtContent.Text = question.Content;
            int i = 0;
            foreach (Control ctl in pnlAnswerGroup.Controls)    //get data answers from 4 UCAnswerBox in pnlAnswerGroup
            {
                UCAnswerBox uc = (UCAnswerBox)ctl;
                uc.Content = question.listAnswer[i++];
                if (uc.Content == question.AnswerCorrect) uc.isAnswerCorrect = true;
               
            }
            txtTopicInfor.Text = question.TopicInfor;
        }

        #endregion

        private void grvListQuestion_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            refreshForm();
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0) setDataToForm(listQuestion[rowIndex]);

            //
            currentColum = e.ColumnIndex;
            currentRow = e.RowIndex;
            // click the first cell of the ID column
            if (currentRow == -1 && currentColum == 0)
            {
                numColumSort = 0;
                getListQuestionFromFile(filePath, numColumSort);
            }
            // click the first cell of the Name column
            else if (currentRow == -1 && currentColum == 1)
            {
                numColumSort = 1;
                getListQuestionFromFile(filePath, numColumSort);
            }
            // click the first cell of the StartTime column
            else if (currentRow == -1 && currentColum == 2)
            {
                numColumSort = 2;
                getListQuestionFromFile(filePath, numColumSort);
            }
            // click the first cell of the EndTime column
            else if (currentRow == -1 && currentColum == 3)
            {
                numColumSort = 3;
                getListQuestionFromFile(filePath, numColumSort);
            }
            // click the first cell of the NumberPlayer column
            else if (currentRow == -1 && currentColum == 4)
            {
                numColumSort = 4;
                getListQuestionFromFile(filePath, numColumSort);
            }
            //Click on the data cells of the table
            if (currentRow > -1)
            {
                btnEdit.Enabled = true;
                setDataToForm(listQuestion[currentRow]);
            }
        }


        private void saveListQuestion(string filepath)
        {
            File.WriteAllText(filePath, String.Empty);  //Reset data in file
            listQuestion.ForEach(question =>    //Re-Save current listGameShow
            {
                SaveQuestion(question);
            });
            listQuestion = getListQuestionFromFile(filePath, numColumSort); //update ListGameShow from the file
            grvListQuestion.DataSource = listQuestion;
        }


        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            btnAddQuestion.Hide();//Ẩn
            btnSave.Show();
            rowEdit = currentRow;
        }

        private void QuestionManagement_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnSave.Hide();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you want Remove question??", "Remove question", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (currentRow != -1 && currentRow < listQuestion.Count)
                {
                    listQuestion.RemoveAt(currentRow);
                    File.WriteAllText(filePath, String.Empty);
                    listQuestion.ForEach(game =>
                    {
                        SaveQuestion(game);
                    });
                    listQuestion = getListQuestionFromFile(filePath, numColumSort);
                    grvListQuestion.DataSource = listQuestion;
                }
                MessageBox.Show("Remove successfully!!", "Remove file", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSave.Hide();
                btnAddQuestion.Show();
            }

        }


    }
}

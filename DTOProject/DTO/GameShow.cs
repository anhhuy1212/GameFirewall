using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTOProject.DTO
{
    public class GameShow
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        
        public int NumberPlayer { get; set; }
        // Tạo danh sách người chơi
        public Dictionary<int, List<Player>> listPlayers = new Dictionary<int, List<Player>>();
        // tạo danh sách điểm cho User
        public Dictionary<int, List<Point_Player>> lstPointUser = new Dictionary<int, List<Point_Player>>();
        // Tạo danh sách câu hỏi
        Dictionary<int, Question> listQuestions { get; set; }
        // Tạo danh sách thống kê
        public List<Statistics_Results> listStatistics = new List<Statistics_Results>();
        // Danh sách điểm cao nhất
        public List<int> ListHighCore = new List<int>();
        public void LoadListQuestions(List<Question> lstQuestion)
        {
            // load lại danh sách câu hỏi id
            listQuestions = new Dictionary<int, Question>();
            foreach (Question item in lstQuestion)
            {
                listQuestions.Add(int.Parse(item.Id), item);
            }
        }
        // kiểm tra câu trả lời
        public void CheckAnswer(string answer,int player_Id, int question_Id)
        {
            // tạo danh sách câu trả lời bằng null
            List<Point_Player> listPointPlayer = null;
            var point_Player = new Point_Player()
            {
                // lấy đầu vào Player
                Player_Id = player_Id,
                Question_Id = question_Id,
                Answer = answer,
                //kiểm tra câu trả lời có đúng với đáp án
                Result = (answer == listQuestions[question_Id].AnswerCorrect)
            };
            //Kiểm tra xem có id của player không
            if (lstPointUser.ContainsKey(player_Id))
            {
                
                listPointPlayer = lstPointUser[player_Id];
                listPointPlayer.Add(point_Player);
            }

            else
            {
                try
                {//không có thì thêm vào danh sách.
                    lstPointUser.Add(player_Id, new List<Point_Player>() { point_Player });
                }
                catch (Exception ex)
                {// nếu lỗi thì thông báo lỗi
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        public void Statistics_Results()
        {
            // set id trong danh sách điểm user
            foreach (int id in lstPointUser.Keys)
            {
                // tạo thống kê 
                Statistics_Results Statistics = new Statistics_Results();
                // lấy id
                Statistics.ID = id;
                // lấy số câu trả lời
                Statistics.NumbertoAnswer = lstPointUser[id].Count;
                // kiểm tra câu trả lời đúng trong danh sách điểm user
                foreach (Point_Player pointPlayer in lstPointUser[id])
                {
                    // nếu đúng thì cho số câu đúng thêm 1
                    if (pointPlayer.Result)
                    {
                        Statistics.CorrectAnswer++;
                    }
                    
                }
                for(int i=0;i<listStatistics.Count;i++)
                {
                    if (Statistics.ID == listStatistics[i].ID)
                        listStatistics.RemoveAt(i);
                }    
                // thêm thống kê vào danh sách thống kê
                listStatistics.Add(Statistics);
            }
            //sắp xếp lại danh sách
            listStatistics.Sort();
            // Điểm cao nhất 
            int max = 0;
            if (listStatistics.Count >0)
                max = listStatistics[0].CorrectAnswer;
            // Danh sách thống kê 
            foreach (Statistics_Results statistics in listStatistics)
            {
                // nếu số câu đúng trong danh sách thống kê bằng max
                // thêm vào danh sách điểm cao nhất.
                if (statistics.CorrectAnswer == max)
                {
                    for(int i=0;i<ListHighCore.Count;i++)
                    {
                        if (statistics.ID == ListHighCore[i])
                            ListHighCore.RemoveAt(i);
                    }    
                    ListHighCore.Add(statistics.ID);
                    if (ListHighCore.Count > 3)
                        ListHighCore.RemoveAt(0);
                }
            }
        }






    }
}

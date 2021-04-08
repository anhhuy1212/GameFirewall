using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using DTOProject.DTO;


namespace MyLib
{
    public class Utils
    {
        
        // Convert an object to a byte array
        public static byte[] ObjectToByteArray(Object obj)
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (var ms = new MemoryStream())
            {
                bf.Serialize(ms, obj);
                return ms.ToArray();
            }
        }

        // Convert a byte array to an Object
        public static Object ByteArrayToObject(byte[] arrBytes)
        {
            using (var memStream = new MemoryStream())
            {
                var binForm = new BinaryFormatter();
                memStream.Write(arrBytes, 0, arrBytes.Length);
                memStream.Seek(0, SeekOrigin.Begin);
                var obj = binForm.Deserialize(memStream);
                return obj;
            }
        }
        public static List<Question> getListQuestionFromFile(string pathFile, List<Question> listQuestion) //Get Data question from file question.txt
        {
            StreamReader sr = new StreamReader(pathFile);
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

            sr.Close();
            return listQuestion;
        }
        public static void getScheduleFromFile(string pathFile, List<GameShow> listGameShow) //Get Data question from file question.txt
        {
            StreamReader sr = new StreamReader(pathFile);
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
                    game.StartTime =  DateTime.Parse(line.Substring(1));
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
            sr.Close();
            sortSchedule(listGameShow,2);
        }

        public static void sortSchedule(List<GameShow> listGameShow,int numColum)
        {
            switch (numColum)
            {
                case 0:
                    listGameShow.Sort((a, b) => a.ID.CompareTo(b.ID));
                    break;
                case 1:
                    listGameShow.Sort((a, b) => a.Name.CompareTo(b.Name));
                    break;
                case 2:
                    listGameShow.Sort((a, b) => a.StartTime.CompareTo(b.StartTime));
                    break;
                case 3:
                    listGameShow.Sort((a, b) => a.EndTime.CompareTo(b.EndTime));
                    break;
                case 4:
                    listGameShow.Sort((a, b) => a.NumberPlayer.CompareTo(b.NumberPlayer));
                    break;
            }
            
        }
        public static void sortQuestion(List<Question> listQuestion, int numColum)
        {
            switch (numColum)
            {
                case 0:
                    listQuestion.Sort((a, b) => a.Id.CompareTo(b.Id));
                    break;
                case 1:
                    listQuestion.Sort((a, b) => a.Content.CompareTo(b.Content));
                    break;
                case 2:
                    for(int i= 0;i<5;i++)
                    listQuestion.Sort((a, b) => a.listAnswer[i].CompareTo(b.listAnswer[i]));
                    break;
                case 3:
                    listQuestion.Sort((a, b) => a.TopicInfor.CompareTo(b.TopicInfor));
                    break;

                    break;
            }

        }



        public static GameShow findNearestGame(List<GameShow> listGameShow) //Find nearest game in Broadcast Schedule
        {
            DateTime timeNow = DateTime.Now;
            GameShow nearestGame = null;
            int max = 0;
            listGameShow.ForEach(game =>
            {

                //Check whether the game has a valid broadcast time and is less than the min time
                if(game.ID == "01")
                {
                    game.StartTime = DateTime.Now.AddSeconds(5);
                    game.EndTime = DateTime.Now.AddMinutes(45);
                }    
            });
            listGameShow.ForEach(game =>
            {
                
                //Check whether the game has a valid broadcast time and is less than the min time
                if (timeNow < game.StartTime) 
                {
                    nearestGame = game;
                    if (game.StartTime.Subtract(timeNow) < nearestGame.StartTime.Subtract(timeNow))
                    {
                        nearestGame = game;
                    }
                }
            });
            return nearestGame;
        }




    }
}

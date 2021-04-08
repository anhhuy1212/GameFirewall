using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOProject.DTO
{
    [Serializable]
    public class Question
    {
        public string Id { get; set; }
        public string Content { get; set; }
        public List<string> listAnswer { get; set; }
        public string AnswerCorrect { get; set; }
        public string TopicInfor { get; set; }

        public Question()
        {
            listAnswer = new List<string>();
        }
    }
}

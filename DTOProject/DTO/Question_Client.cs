using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOProject.DTO
{
    [Serializable]

    public class Question_Client
    {
        public int NumberPeople { get; set; }
        public int id { get; set; }
        public string Content { get; set; }
        public List<string> listAnswer { get; set; }
        public Question_Client()
        {
            listAnswer = new List<string>();

        }
    }
}

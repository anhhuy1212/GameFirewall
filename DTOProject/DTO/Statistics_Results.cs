using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOProject.DTO
{
    public class Statistics_Results : IComparable<Statistics_Results>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int NumbertoAnswer { get; set; }
        public int CorrectAnswer { get; set; }
        public Statistics_Results()
        {
            NumbertoAnswer = 0;
            CorrectAnswer = 0;
        }

        public int CompareTo(Statistics_Results other)
        {
            return other.CorrectAnswer.CompareTo(this.CorrectAnswer);
        }
    }
}

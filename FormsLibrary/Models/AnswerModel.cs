using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsLibrary.Models
{
    public class AnswerModel
    {
        public ICollection<dynamic> Answers { get; set; }
        //public ShortAnswerModel? ShortAnswer { get; set; }
        //public LongAnswerModel? LongAnswer { get; set; }
        //public SingleChoiceModel? SingleChoice { get; set; }
        //public MultipleChoiceModel? MultipleChoice { get; set; }
        //public DropdownChoiceModel? DrowDownChoice { get; set; }
        //public DateTime? Date { get; set; }
        //public TimeSpan? Time { get; set; }

        public AnswerModel()
        {
            Answers = new List<dynamic>();
        }
    }
}

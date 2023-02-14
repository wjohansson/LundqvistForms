using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsLibrary.Models
{
    public class QuestionModel
    {
        public string QuestionTitle { get; set; } = "";
        public QuestionOptions Option { get; set; }
    }

    public enum QuestionOptions
    {
        Flerval,
        Enkelval,
        Rullgardin,
        Skala,
        Datum,
        Tid,
        Kort,
        Lång
    }
}

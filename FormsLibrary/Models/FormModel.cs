using System.ComponentModel;

namespace FormsLibrary.Models
{
    public class FormModel
    {
        public string FormTitle { get; set; } = "";
        public string FormDescription { get; set; } = "";
        public ICollection<QuestionModel> Components { get; set; }

        public FormModel()
        {
            Components = new List<QuestionModel>();
        }
    }
}
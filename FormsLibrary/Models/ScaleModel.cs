using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsLibrary.Models
{
    public class ScaleModel
    {
        public List<int> Scale { get; set; }
        public string LabelFirst { get; set; } = "";
        public string LabelLast { get; set; } = "";

        public ScaleModel(int range)
        {
            Scale = Enumerable.Range(1, range).ToList();
        }
    }
}

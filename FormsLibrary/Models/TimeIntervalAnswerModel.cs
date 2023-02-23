using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FormsLibrary.Models
{
    public class TimeIntervalAnswerModel
    {
        [Key]
        [JsonPropertyName("timeIntervalId")]
        public Guid TimeIntervalId { get; set; } = Guid.NewGuid();

        [JsonPropertyName("startDate")]
        public DateTime? StartDate { get; set; }

        [JsonPropertyName("endDate")]
        public DateTime? EndDate { get; set; }

        [JsonPropertyName("answerId")]
        public Guid AnswerId { get; set; }

        [JsonIgnore]
        [ForeignKey("AnswerId")]
        public AnswerModel Answer { get; set; }
    }
}

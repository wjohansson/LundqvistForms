﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace FormsLibrary.Models
{
    public class FormModel
    {
        [Key]
        [JsonPropertyName("formId")]
        public Guid FormId { get; set; } = Guid.NewGuid();

        [Required(ErrorMessage = "Formuläret måste ha en rubrik")]
        [JsonPropertyName("formTitle")]
        public string FormTitle { get; set; } = "";

        [Required(ErrorMessage = "Formuläret måste ha en beskrivning")]
        [JsonPropertyName("formDescription")]
        public string FormDescription { get; set; } = "";

        [JsonPropertyName("formDate")]
        public DateTime FormDate { get; set; }

        [JsonPropertyName("isDeleted")]
        public bool IsDeleted { get; set; } = false;

        [ForeignKey("FormId")]
        [JsonPropertyName("segments")]
        public ICollection<SegmentModel> Segments { get; set; }

        [ForeignKey("FormId")]
        [JsonPropertyName("answers")]
        public ICollection<AnswerModel> Answers { get; set; }

        public FormModel()
        {
            Segments = new List<SegmentModel>();
            Answers = new List<AnswerModel>();
        }
    }
}
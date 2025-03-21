
using System;

namespace SurveyApp.WebMvc.Models
{
    public class SurveyListItemViewModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public int ResponseCount { get; set; }
        public int CompletionRate { get; set; }
        public string Status { get; set; } = "Active";
        public string DeliveryType { get; set; } = "Manual";
        public DateTime? LastResponseDate { get; set; }
        public bool IsFeatured { get; set; }
        public string Category { get; set; }
        public int QuestionCount { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastUpdated { get; set; }
        
        // This property is needed in Dashboard/Index.cshtml
        public int Responses { get; set; }
    }
}

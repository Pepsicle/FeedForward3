using System;
using System.Collections.Generic;
using System.Text;

namespace FeedForward3.Models
{
    public class FeedbackListModel
    {
        public List<FeedbackModel> feedbackModels { get; set; } = new List<FeedbackModel>();

        public void AddFeedback(FeedbackModel feedback)
        {
            feedbackModels.Add(feedback);
        }
    }
}

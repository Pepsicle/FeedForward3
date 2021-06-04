using System;
using System.Collections.Generic;
using System.Text;

namespace FeedForward3.Models
{
    public class FeedbackModel
    {
        public int Id { get; set; }
        public int TestId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Feedback { get; set; }

        public FeedbackModel(int id, int testId, string name, string email, string feedback)
        {
            Id = id;
            TestId = testId;
            Name = name;
            Email = email;
            Feedback = feedback;
        }
        public FeedbackModel() : this(0, 0, "null", "null", "null")
        {
        }
    }
}

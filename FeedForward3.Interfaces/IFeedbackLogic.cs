using System;
using System.Collections.Generic;
using System.Text;
using FeedForward3.Models;

namespace FeedForward3.Interfaces
{
    public interface IFeedbackLogic
    {
        bool UploadFeedback(FeedbackModel feedbackModel);
        int GetVisits(int id);
        void Upvote(int id);
        void Downvote(int id);
    }
}

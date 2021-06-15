using System;
using System.Collections.Generic;
using System.Text;
using FeedForward3.Factories;
using FeedForward3.Models;
using FeedForward3.Interfaces;

namespace FeedForward3.Logic
{
    public class FeedbackLogic
    {
        private IFeedbackLogic _feedbackLogic;
        public FeedbackLogic()
        {
            _feedbackLogic = FeedbackLogicFactory.UploadFeedback();
        }


        public bool UploadFeedback(FeedbackModel feedbackModel) //wat als er niks is ingevuld
        {
            _feedbackLogic.UploadFeedback(feedbackModel);
            return true;
        }

        public void Upvote(int id)
        {
            _feedbackLogic.Upvote(id);
        }
        public void Downvote(int id)
        {
            _feedbackLogic.Downvote(id);
        }
    }
}

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
        //private BetaRepository betaRepository = new BetaRepository();
        private IFeedbackLogic _feedbackLogic;
        public FeedbackLogic()
        {
            _feedbackLogic = FeedbackLogicFactory.UploadFeedback();
        }

        //public BetaListModel GetBetaList()
        //{
        //    return _betaLogic.betaList();
        //}

        public bool UploadFeedback(FeedbackModel feedbackModel) //wat als er niks is ingevuld
        {
            _feedbackLogic.UploadFeedback(feedbackModel);
            return true;
        }
    }
}

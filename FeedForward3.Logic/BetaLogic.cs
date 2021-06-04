using System;
using System.Collections.Generic;
using System.Text;
using FeedForward3.DAL;
using FeedForward3.DAL.Repositories;
using FeedForward3.Factories;
using FeedForward3.Models;
using FeedForward3.Interfaces;

namespace FeedForward3.Logic
{
    public class BetaLogic
    {
        //private BetaRepository betaRepository = new BetaRepository();
        private IBetaLogic _betaLogic;
        public BetaLogic()
        {
            _betaLogic = BetaLogicFactory.betaList();
        }

        public BetaListModel GetBetaList()
        {
            return _betaLogic.betaList();
        }

        public bool UploadBeta(BetaModel betaModel) //wat als er niks is ingevuld
        {
            _betaLogic.UploadBeta(betaModel);
            return true;
        }

        public bool RemoveBeta(int id)
        {
            _betaLogic.RemoveBeta(id);
            return true;
        }
    }
}

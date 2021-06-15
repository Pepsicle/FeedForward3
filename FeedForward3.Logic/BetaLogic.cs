using System;
using System.Collections.Generic;
using System.Text;
using FeedForward3.DAL;
using FeedForward3.DAL.Repositories;
using FeedForward3.Factories;
using FeedForward3.Models;
using FeedForward3.Interfaces;
using System.Linq;

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

        public BetaListModel GetBetaListPopularity()
        {
            BetaListModel betaList = _betaLogic.betaList();
            List<BetaModel> betas = betaList.betaModels.OrderByDescending(b => b.Visits).ToList();
            BetaListModel betaListModel = new BetaListModel();
            foreach (var beta in betas)
            {
                betaListModel.AddBeta(beta);
            }
            return betaListModel;
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

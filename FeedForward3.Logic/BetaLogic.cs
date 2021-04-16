using System;
using System.Collections.Generic;
using System.Text;
using FeedForward3.DAL;
using FeedForward3.DAL.Repositories;
using FeedForward3.Models;

namespace FeedForward3.Logic
{
    public class BetaLogic
    {
        BetaRepository betaRepository = new BetaRepository();
        public BetaListModel GetBetaList()
        {
            return betaRepository.betaList();
        }
    }
}

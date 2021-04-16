using System;
using System.Collections.Generic;
using System.Text;
using FeedForward3.DAL.Repositories;
using FeedForward3.Interfaces;

namespace FeedForward3.Factories
{
    public class BetaLogicFactory
    {
        public static IBetaLogic betaList()
        {
            return new BetaRepository();
        }
    }
}

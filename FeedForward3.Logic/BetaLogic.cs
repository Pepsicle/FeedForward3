﻿using System;
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
        BetaRepository betaRepository = new BetaRepository();
        IBetaLogic _BetaLogic;
        public BetaLogic()
        {
            _BetaLogic = BetaLogicFactory.betaList();
        }
        public BetaListModel betaList()
        {
            return _BetaLogic.betaList();
        }
        public BetaListModel GetBetaList()
        {
            return betaRepository.betaList();
        }
    }
}
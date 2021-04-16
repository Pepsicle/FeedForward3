using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeedForward3.Models
{
    public class BetaListModel
    {
        public List<BetaModel> betaModels { get; set; } = new List<BetaModel>();
        //public BetaListModel()
        //{
        //    List<BetaModel> betaModels = new List<BetaModel>();
        //}

        public void AddBeta(BetaModel beta)
        {
            betaModels.Add(beta);
        }
    }
}

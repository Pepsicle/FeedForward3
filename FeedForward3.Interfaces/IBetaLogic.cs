using System;
using System.Collections.Generic;
using System.Text;
using FeedForward3.Models;

namespace FeedForward3.Interfaces
{
    public interface IBetaLogic
    {
        BetaListModel betaList();
        bool UploadBeta(BetaModel betaModel);
        bool RemoveBeta(int id);
    }
}

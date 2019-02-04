using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Interfaces
{
    interface IRequest
    {
        void SearchAwards();
        void CalculateAveragePoints();
        void SearchAwardsByGiver();
        void CalculateAveragePointsGivenByUser();
        void MostPopularAward();
    }
}

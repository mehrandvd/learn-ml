using Microsoft.ML.Runtime.Api;

namespace Mehran.TaxiFarePrediction.Model
{
    public class TaxiTripFarePrediction
    {
        [ColumnName("Score")]
        public float FareAmount;
    }
}

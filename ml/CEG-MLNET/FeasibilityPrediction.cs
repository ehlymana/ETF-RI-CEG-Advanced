using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEG_MLNET
{
    public class FeasibilityPrediction
    {
        [ColumnName("PredictedLabel")]
        public bool PredictedLabel { get; set; }
    }
}

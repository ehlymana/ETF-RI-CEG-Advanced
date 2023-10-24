using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CauseEffectGraph
{
    public class CEGData
    {
        [LoadColumn(0, 49)]
        [VectorType(50)]
        public float[] Features { get; set; }

        [LoadColumn(50)]
        public bool Outcome;
    }
}

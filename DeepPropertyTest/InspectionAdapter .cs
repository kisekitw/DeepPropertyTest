using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepPropertyTest
{
    /// <summary>
    /// Adapter to isolate source change
    /// </summary>
    public class InspectionAdapter : IInspection
    {
        /// <summary>
        /// Truely CRO Object
        /// </summary>
        private readonly Inspection inspection;

        public InspectionAdapter()
        {
            inspection = new Inspection();
        }

        public string HighResolution
        {
            get => inspection.Test.ImageParam.HighResolution;
            set => inspection.Test.ImageParam.HighResolution = value;
        }
    }
}

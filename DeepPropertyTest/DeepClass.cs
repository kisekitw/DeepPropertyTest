using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DeepPropertyTest
{
    public class DeepClass
    {
        public IInspection Inspection { get; set; } = new InspectionAdapter();
        public string HighResolution
        {
            get => Inspection.HighResolution;
            set => Inspection.HighResolution = value;
        }
    }
}

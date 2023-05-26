using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DeepPropertyTest
{
    /// <summary>
    /// Like TestManagementService
    /// </summary>
    public class TestManagementService
    {
        public IInspection Inspection { get; set; } = new InspectionAdapter();
        public string HighResolution
        {
            get => Inspection.HighResolution;
            set => Inspection.HighResolution = value;
        }
    }
}

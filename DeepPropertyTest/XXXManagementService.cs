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
    public class XXXManagementService
    {
        public ILv1Adapter Lv1Adapter { get; set; } = new Lv1Adapter();
        public string HighResolution
        {
            // Not access by far far away property path in URE core codebase
            get => Lv1Adapter.HighResolution;
            set => Lv1Adapter.HighResolution = value;
        }
    }
}

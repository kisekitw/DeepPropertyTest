using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepPropertyTest
{
    /// <summary>
    /// Properties or methods want to publish
    /// </summary>
    public interface IInspection
    {
        string HighResolution { get; set; }
    }
}

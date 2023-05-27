using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepPropertyTest
{
    /// <summary>
    /// CRO Class
    /// </summary>
    public class Lv1Class
    {
        public Lv2Class Lv2 { get; set; } = new Lv2Class();
    }

    public class Lv2Class
    {
        public Lv3Class Lv3 { get; set; } = new Lv3Class();
    }

    public class Lv3Class
    {
        public string HighResolution { get; set; } = string.Empty;
    }

}

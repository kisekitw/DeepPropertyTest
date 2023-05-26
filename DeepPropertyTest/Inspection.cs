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
    public class Inspection
    {
        public Test Test { get; set; } = new Test();
    }

    public class Test
    {
        public ImageSetting ImageParam { get; set; } = new ImageSetting();
    }

    public class ImageSetting
    {
        public string HighResolution { get; set; } = string.Empty;
    }

}

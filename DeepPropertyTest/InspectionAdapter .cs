﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepPropertyTest
{
    /// <summary>
    /// Adapter to isolate source change
    /// </summary>
    public class InspectionAdapter : Ilv1Adapter
    {
        /// <summary>
        /// Truely CRO Object
        /// </summary>
        private readonly Lv1Class lv1;

        public InspectionAdapter()
        {
            lv1 = new Lv1Class();
        }

        public string HighResolution
        {
            get => lv1.Lv2.Lv3.HighResolution;
            set => lv1.Lv2.Lv3.HighResolution = value;
        }
    }
}

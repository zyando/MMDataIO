﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CsMmdDataIO.Vmd.Data
{
    internal interface IVmdData
    {
        void Export(VmdExporter exporter);
    }
}

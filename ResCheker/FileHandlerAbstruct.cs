using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResCheker
{
    abstract class FileHandlerAbstruct
    {
        public float CpuPerformance { get; set; }
        public float MemPerformance { get; set; }
        public float GpuPerformance { get; set; }
        public float FpsCounter { get; set; }
    }
}

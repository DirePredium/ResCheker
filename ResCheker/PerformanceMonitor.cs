using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResCheker
{
    internal class PerformanceMonitor
    {
        private PerfomanceStruct perfomance;

        PerformanceCounter CPUperformanceCounter = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");
        PerformanceCounter MEMperformanceCounter = new PerformanceCounter("Memory", "% Committed Bytes In Use");

        private static int lastTick;
        private static int lastFrameRate;
        private static int frameRate;



        public PerformanceMonitor(PerfomanceStruct performance)
        {
            this.perfomance = performance;
        }


        private void SetCpuPerformance()
        {
            this.perfomance.CpuPerformance = (int)CPUperformanceCounter.NextValue();
        }

        private void SetMemPerformance()
        {
            this.perfomance.MemPerformance = (int)MEMperformanceCounter.NextValue();
        }

        private void SetGpuPerformance()
        {
            var category = new PerformanceCounterCategory("GPU Engine");
            var counterNames = category.GetInstanceNames();
            var gpuCounters = new List<PerformanceCounter>();
            var result = 0f;

            foreach (string counterName in counterNames)
            {
                if (counterName.EndsWith("engtype_3D"))
                {
                    foreach (PerformanceCounter counter in category.GetCounters(counterName))
                    {
                        if (counter.CounterName == "Utilization Percentage")
                        {
                            gpuCounters.Add(counter);
                        }
                    }
                }
            }

            gpuCounters.ForEach(x =>
            {
                _ = x.NextValue();
            });


            gpuCounters.ForEach(x =>
            {
                result += x.NextValue();
            });

            this.perfomance.GpuPerformance = (int)result;
        }

        private void SetFpsCounter()
        {
            if (System.Environment.TickCount - lastTick >= 1000)
            {
                lastFrameRate = frameRate;
                frameRate = 0;
                lastTick = System.Environment.TickCount;
            }

            frameRate++;

            this.perfomance.FpsCounter = lastFrameRate;
        }

        public void StartResCounting()
        {
            this.SetCpuPerformance();
            this.SetMemPerformance();
            this.SetGpuPerformance();
        }

        public void StartFPSCounting()
        {
            this.SetFpsCounter();
        }
    }
}

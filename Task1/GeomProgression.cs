using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class GeomProgression : ISeries
    {
        int step;
        int startValue;
        int currentValue;

        public int GetNext()
        {
            currentValue= currentValue * step;
            return currentValue;
        }

        public void Reset()
        {
            currentValue = startValue;
        }

        public void SetStart(int x)
        {
            startValue = x;
            currentValue = startValue;
        }

        public void SetStep(int s)
        { 
        step = s;
        }
    }
}

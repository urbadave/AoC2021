using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01
{
    public class DepthCounter : IDepthCounter
    {
        private IDepthDto _depth;

        public DepthCounter(IDepthDto depth)
        {
            _depth = depth;
        }

        public int GetDepthIncreases(bool test = false)
        {
            List<int> depthList;
            depthList = (test) ? _depth.TestData : _depth.RealData;

            return CountIncreases(depthList);
        }

        public int GetWindowDepthIncreases(bool test = false)
        {
            List<int> depthList;
            depthList = (test) ? _depth.TestData : _depth.RealData;
            var useList = new List<int>();
            for (int i = 2; i < depthList.Count; i++)
            {
                useList.Add(depthList[i - 2] + depthList[i - 1] + depthList[i]);
            }

            return CountIncreases(useList);
        }

        private int CountIncreases(List<int> input)
        {
            var increaseCount = 0;
            for (int i = 1; i < input.Count; i++)
            {
                if (input[i - 1] < input[i]) increaseCount++;
            }

            return increaseCount;

        }
    }
}

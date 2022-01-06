using System.Collections.Generic;

namespace Day01
{
    public interface IDepthDto
    {
        List<int> RealData { get; }
        List<int> TestData { get; }
    }
}
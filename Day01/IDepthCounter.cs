namespace Day01
{
    public interface IDepthCounter
    {
        int GetDepthIncreases(bool test = false);
        int GetWindowDepthIncreases(bool test = false);
    }
}
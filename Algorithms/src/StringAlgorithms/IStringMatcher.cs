namespace StringAlgorithms
{
    using System.Collections.Generic;

    public interface IStringMatcher
    {
        List<int> GetMatchingIndexes(string text, string pattern);
    }
}

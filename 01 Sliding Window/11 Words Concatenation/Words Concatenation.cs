public class Solution {
    public IList<int> FindSubstring(string s, string[] words) {
        List<int> validIndexWithSubString = new List<int>();
        int wordLength = words[0].Length;
        int arrayLength = words.Length;
        if(s.Length<(arrayLength*wordLength))
            return validIndexWithSubString;
        int loopLength = s.Length-(wordLength*arrayLength);
        Array.Sort(words);
        for(int i=0;i<=loopLength;i++) {
                IEnumerable<string> getSplittedArray = Split(s.Substring(i),wordLength, arrayLength);
                getSplittedArray = getSplittedArray.OrderBy(s => s);
                if(getSplittedArray.SequenceEqual(words))
                    validIndexWithSubString.Add(i);
        }
        return validIndexWithSubString;        
    }

    static IEnumerable<string> Split(string str, int wordLength, int arrayLength) {
        return Enumerable.Range(0, arrayLength)
            .Select(i => str.Substring(i * wordLength, wordLength));
    }
}
public class Solution {
    public IList<int> FindSubstring(string s, string[] words) {
        var result = new List<int>();
        if(string.IsNullOrEmpty(s) || words == null || words.Length == 0)
            return result;

        int wordLength = words[0].Length;
        int wordCount = words.Length;
        int substringLength = wordLength * wordCount;
        
        var wordFrequency = new Dictionary<string, int>();

        foreach(var word in words){
            if(wordFrequency.ContainsKey(word)) wordFrequency[word]++;
            else wordFrequency[word] = 1;
        }
        
        for(int i = 0; i < wordLength; i++) {
            int left = i, count = 0;
            var wordsFound = new Dictionary<string, int>();
            
            for(int j = i; j <= s.Length - wordLength; j += wordLength){
                string word = s.Substring(j, wordLength);
                
                if (wordFrequency.ContainsKey(word)) {
                    if(wordsFound.ContainsKey(word))
                        wordsFound[word]++;
                    else
                        wordsFound[word] = 1;
                    
                    count++;
                    
                    while(wordsFound[word] > wordFrequency[word]) {
                        string leftWord = s.Substring(left, wordLength);
                        wordsFound[leftWord]--;
                        count--;
                        left += wordLength;
                    }
                    
                    if(count == wordCount)
                        result.Add(left);
                } else {
                    wordsFound.Clear();
                    count = 0;
                    left = j + wordLength;
                }
            }
        }

        return result;
    }
}
class Solution(object):
    def findSubstring(self, s, words):
        from collections import Counter
        
        word_bag = Counter(words) 
        word_len = len(words[0])
        num_words = len(words)
        total_len = word_len * num_words
        res = []
        
        for i in xrange(word_len):
            left = i
            sub_counter = Counter()
            count = 0
            for j in xrange(i, len(s) - word_len + 1, word_len):
                word = s[j:j + word_len]
                if word in word_bag:
                    sub_counter[word] += 1
                    count += 1
                    while sub_counter[word] > word_bag[word]:
                        sub_counter[s[left:left + word_len]] -= 1
                        left += word_len
                        count -= 1
                    if count == num_words:
                        res.append(left)
                else:
                    sub_counter = Counter()
                    left = j + word_len
                    count = 0
                    
        return res
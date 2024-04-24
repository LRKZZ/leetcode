class Solution(object):
    def lengthOfLongestSubstring(self, s):
        """
        :type s: str
        :rtype: int
        """
        list_of_counts = []
        current_substr = ""

        for char in s:
            if char not in current_substr:
                current_substr += char
            else:
                list_of_counts.append(len(current_substr))
                current_substr = current_substr[current_substr.index(char) + 1:] + char

        list_of_counts.append(len(current_substr))

        max_value = max(list_of_counts) if list_of_counts else 0
        return max_value
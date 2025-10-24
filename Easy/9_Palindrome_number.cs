public class Solution {
    public bool IsPalindrome(int x) {
        var s = x.ToString();
        var c = s.ToCharArray();
        
        Array.Reverse(c);

        return s == new string(c);
    }
}
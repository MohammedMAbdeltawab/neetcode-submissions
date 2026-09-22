public class Solution {
    public bool IsAnagram(string s, string t) {
        var ss = new string(s.OrderBy(c=>c).ToArray());
        var tt = new string(t.OrderBy(c=>c).ToArray());
        if(ss.Contains(tt)&&tt.Contains(ss)){return true;}
        return false;
    }
}

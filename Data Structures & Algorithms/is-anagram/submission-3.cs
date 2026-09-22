public class Solution {
    public bool IsAnagram(string s, string t) {
         var ss=new string(s.OrderBy(s=>s).ToArray());
       var tt=new string(t.OrderBy(s=>s).ToArray());
       return ss.Contains(tt)&&tt.Contains(ss);
    }
}

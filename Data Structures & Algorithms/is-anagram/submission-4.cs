public class Solution {
    public bool IsAnagram(string s, string t) {
     string ss=new String(s.OrderBy(x=>x).ToArray());
     string tt= new String(t.OrderBy(x=>x).ToArray());
     return ss==tt;
    }
}

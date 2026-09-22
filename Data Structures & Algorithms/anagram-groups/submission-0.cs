public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary <string , List<string>>mp=new();
        foreach (var str in strs){
            string sorted =new string(str.OrderBy(s=>s).ToArray());
            if(!mp.ContainsKey(sorted)){
                mp[sorted]=new();
            }
            mp[sorted].Add(str);
        }
        return mp.Values.ToList<List<string>>();







    }
}

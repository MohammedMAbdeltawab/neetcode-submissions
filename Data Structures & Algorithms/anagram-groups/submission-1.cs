public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string,IList<string>> dic = new Dictionary<string,IList<string>>();
        foreach(var item in strs){
            string temp=new string(item.OrderBy(x=>x).ToArray());
            if(!dic.ContainsKey(temp)){
            dic[temp]= new List<string>();
            }
            dic[temp].Add(item);
        }
        List<List<string>>ans=new List<List<string>>();
        foreach(var item in dic){
            ans.Add(item.Value.ToList());
        }
        return ans;
    }
}

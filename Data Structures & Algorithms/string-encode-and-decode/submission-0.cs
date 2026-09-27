public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder res = new StringBuilder();
        foreach(var e in strs){
            res.Append(e.Length).Append("#").Append(e);
        }
        return res.ToString();
    }

    public List<string> Decode(string s) {
        List<string>res = new List<string>();
        int i=0;
        while(i<s.Length){
            int j=i;
            while(s[j]!='#'){j++;}
            int length= int.Parse(s.Substring(i,j-i));
            string str=s.Substring(j+1,length);
            res.Add(str);
            i=j+1+length;
        }

        return res;
   }
}

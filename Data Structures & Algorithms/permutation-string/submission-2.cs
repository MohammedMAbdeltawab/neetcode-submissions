public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        s1= new String(s1.OrderBy(c=>c).ToArray());
	for(int i=0;i<s2.Length-s1.Length+1;i++){
		string substr= s2.Substring(i,s1.Length);	
		substr = new String(substr.OrderBy(c=>c).ToArray());
        Console.WriteLine(substr);
		if(s1 == substr){return true;}
	
	}	
	return false;
    }
}

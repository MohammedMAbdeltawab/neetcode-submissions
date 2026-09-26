public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int>hs=new HashSet<int>(nums);
        int res=0;

        foreach(int i in hs){
            if(!hs.Contains(i-1)){
                int seq=1;
                while(hs.Contains(i+seq)){seq++;}
                res=Math.Max(res,seq);
            }
        }
    return res;
    }
}

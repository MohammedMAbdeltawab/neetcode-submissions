public class Solution {
    public int MaxArea(int[] heights) {
        int l=0,r=heights.Length-1,ans=-1;
        while(l<r){
            int temp= Math.Min(heights[l],heights[r]);
            ans=Math.Max(ans,temp*(r-l));
            if(heights[l]<heights[r]){l++;}
            else {r--;}
        }
        return ans;
    }
}

public class Solution {
    public int Trap(int[] height) {
        int n=height.Length;
        int[] pre= new int[n];
        int[] suff = new int[n];
        int mxl=0,mxr=0,sum=0,ans=0;
        for(int i=0,j=n-1;i<n;i++,j--){
            pre[i]=mxl;
            mxl=Math.Max(mxl,height[i]);
            suff[j]=mxr;
            mxr=Math.Max(mxr,height[j]);
        }
        for(int i=0;i<n;i++){
            int temp=(Math.Min(pre[i],suff[i])-height[i]);
            ans+=temp>0?temp:0;
        }
        return ans;
    }
}

public class Solution {
    public int MaxProfit(int[] prices) {
        int n=prices.Length;
	int[] pre = new int[n];
	int[] suf = new int[n];
	int mn= int.MaxValue ,  mx= int.MinValue,res=int.MinValue;
	for(int i=0,j=n-1;i<n;i++,j--){
	mn= Math.Min(mn,prices[i]);
    pre[i]=mn;
    mx= Math.Max(mx,prices[j]);
    suf[j]=mx;
	}
    for(int i=0;i<n;i++){
        res=Math.Max(res,suf[i]-pre[i]);

    }

	return res;
    }
}
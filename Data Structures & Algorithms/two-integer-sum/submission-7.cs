public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        List<int[]> arr = new List<int[]>();
        for(int i=0;i<nums.Length;i++){
            arr.Add(new int[]{nums[i],i});
        }
        arr.Sort((a,b)=>a[0].CompareTo(b[0]));
        int l=0,r=nums.Length-1;
        while(l<r){
            int sum=arr[l][0]+arr[r][0];
            if(sum>target){r--;}
            else if(sum<target){l++;}
            else{
                int idx1=Math.Min(arr[l][1],arr[r][1]);
                int idx2=Math.Max(arr[l][1],arr[r][1]);
                return (new int[]{idx1,idx2} );
            }
        }
        return new int[]{-1,-1};
    }
}

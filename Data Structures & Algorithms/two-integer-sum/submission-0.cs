public class Solution {
    public int[] TwoSum(int[] nums, int target) {
       Dictionary<int, int>mp=new();

       for(int i=0;i<nums.Length;i++){
        int n1=nums[i]; 
        int n2=target-n1;
        if(mp.ContainsKey(n2)){
            return new int[] {mp[n2],i};
        }
        mp[n1]=i;
       }
        return null;
    }
}

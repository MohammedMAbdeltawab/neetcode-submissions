public class Solution {
    public int Search(int[] nums, int target) {
        int l=0,r=nums.Length-1;
	while (l<=r){
		int md= (l+r)/2;
		if(nums[md]==target){
		return md;	
		}
		else if(nums[md]>target){r=md-1;}
		else{l=md+1;}
	}
	return -1;
    }
}

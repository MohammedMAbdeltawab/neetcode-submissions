public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int cntzeros=0,prod=1;
        foreach(var item in nums){
            if(item ==0){cntzeros+=1;}
            if(item!=0){prod*=item;}
        }
        if (cntzeros>1){
            for(int i =0;i<nums.Length;i++){nums[i]=0;}
        }
        else if(cntzeros==1){
             for(int i =0;i<nums.Length;i++){
                if(nums[i]==0){
                    nums[i]=prod;
                }
                else{
                    nums[i] =0;
                }
            }
        }
        else{
             for(int i =0;i<nums.Length;i++){
                nums[i] = prod /nums[i];
            }
        }
        return nums;
    }
}

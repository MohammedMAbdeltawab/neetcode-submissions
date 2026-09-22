public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int>st=new();
        foreach(var item in nums){
            st.Add(item);
        }
        return st.Count<nums.Length;
        
    }
}
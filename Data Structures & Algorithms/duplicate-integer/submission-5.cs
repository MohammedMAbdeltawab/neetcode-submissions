public class Solution {
    public bool hasDuplicate(int[] nums) {
        var st = new HashSet<int>();
        foreach(var e in nums){
            if(!st.Add(e)){
                return true;
            }
        }
        return false;
    }
}
public class Solution {
    public bool IsOperator(string c){
        // Fixed duplicate "*" and included "/"
        return c=="*" || c=="/" || c=="+" || c=="-";
    }

    public int EvalRPN(string[] tokens) {
        Stack<int> st = new Stack<int>();
        
        foreach(var e in tokens){
            if(IsOperator(e)){
                int right = st.Pop();
                int left = st.Pop();
                int ans = 0;
                
                if(e=="*"){ ans = left * right; }
                else if(e=="+"){ ans = left + right; }
                else if(e=="-"){ ans = left - right; }
                else { ans = left / right; }
                
                st.Push(ans);
            }
            else{
                st.Push(int.Parse(e));
            }
        }
        
        return st.Pop();
    }
}
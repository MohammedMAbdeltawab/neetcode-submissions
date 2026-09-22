public class Solution {
    public bool IsValid(string s) {
        Stack<char> st = new Stack<char>();
        foreach(var element in s){
            if(st.Count==0){
                st.Push(element);
            continue;
            }
            if(st.Peek()=='('&&element==')'){st.Pop();}
            else if(st.Peek()=='{'&&element=='}'){st.Pop();}
            else if(st.Peek()=='['&&element==']'){st.Pop();}
            else{st.Push(element);}
        }
        return st.Count==0;
    }
}

public class Solution {
    public bool IsValidSudoku(char[][] board) {
        bool added=true;
        HashSet<char> hs=new HashSet<char>();
        for(int i=0;i<board.Length;i++){
        hs.Clear();
            for(int j=0;j<board.Length;j++){
                if(board[i][j]=='.'){continue;}
                if(!hs.Add(board[i][j])){return false;}
            }
        }
        for(int j=0;j<board.Length;j++){
          hs.Clear();
            for(int i=0;i<board.Length;i++){
                if(board[i][j]=='.'){continue;}
                if(!hs.Add(board[i][j])){return false;}
            }
        }

        for(int i=0;i<3;i++){
            for(int j=0;j<3;j++){
                hs.Clear();
                for(int k=0;k<3;k++){
                    for(int l=0;l<3;l++){
                        int row=(i*3)+k;
                        int col=(j*3)+l;
                        if(board[row][col]=='.'){continue;}
                        if(!hs.Add(board[row][col])){return false;}
                    }
                }
            }
        }



        return true;

    }
}

public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> dic=new Dictionary<int,int>();
        foreach (var item in nums){
            dic[item]=dic.GetValueOrDefault(item,0)+1;
        }
        PriorityQueue<int,int> pq=new PriorityQueue<int,int>();
        foreach(var e in dic){
            pq.Enqueue(e.Key,e.Value);
        }
    while(pq.Count>k){pq.Dequeue();}

        int[] ans=new int[k];
        for(int i=0;i<k;i++){
            ans[i]=pq.Dequeue();
        }
        return ans;
    }
}

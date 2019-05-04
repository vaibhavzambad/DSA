public class QuickFindUF
{
    public QuickFindUF(int n)
    {
        int[] id = new int[n];
        for (int i = 0; i < n; ++i)
        {
            id[i] = i;
        }
    }
    public bool IsConnected(int p, int q)
    {
        return id[p] == id[q];
    }
    public void Union(int p, int q)
    {
        int pid = id[p];
        int qid = id[q];
        for (int i = 0; i < id.length; ++i)
        {
            if (id[i] == pid)
            {
                id[i] = qid;
            }
        }
    }
}
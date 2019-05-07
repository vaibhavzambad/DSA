public class WeightedQuickUnionPathCompressionUF
{
    private int[] arr;
    private int[] weight;
    public WeightedQuickUnionPathCompressionUF(int N)
    {
        arr = new int[N];
        weight = new int[N];
        for (int i = 0; i < N; ++i)
        {
            arr[i] = i;
            weight[i] = 1;
        }
    }
    private int Root(int p)
    {
        while (p != arr[p])
        {
            arr[p] = arr[arr[p]];
            p = arr[p];
        }
        return p;
    }
    public void Union(int p, int q)
    {
        int rootp = root(p);
        int rootq = root(q);
        if (rootp == rootq)
        {
            return;
        }
        if (weight[p] > weight[q])
        {
            arr[rootq] = rootp;
            weight[p] += weight[q];
        }
        else
        {
            arr[rootp] = rootq;
            weight[q] += weight[p];
        }
    }
    public void IsConnected(int p, int q)
    {
        return root(p) == root(q);
    }
}
public class WeightedQuickUnionUF
{
	private int[] id;
	private int[] weight;
	public WeightedQuickUnionUF(int N)
	{
		id = new int[N];
		weight = new int[N];
		for(int i=0;i<N;++i)
		{
			id[i] = i;
            weight[i] = 1;
		}
	}
	private int root(int p)
	{
		while(id[p] != p)
		{
			p = id[p];
		}
		return p;
	}
	public bool IsConnected(int p,int q)
	{
		return root(p) == root(q);
	}
	public void Union(int p ,int q)
	{
		int rootp = root(p);
		int rootq = root(q);
		if(rootp == rootq)
		{
			return;
		}
		if(weight[rootp] > weight[rootq])
		{
			id[rootq] = rootp;
			weight[rootp] += weight[rootq];
		}
		else
		{
			id[rootp] = rootq;
			weight[rootq] += weight[rootp];
		}
	}
}
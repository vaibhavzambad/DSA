public class QuickUnionUF
{
	private int[] id;
	public QuickUnionUF(int N)
	{
		id = new int[N];
		for(int i=0;i<N;++i)
		{
			id[i] = i;
		}
	}
	private int Root(int p,int q)
	{
		while(id[i] != i)
		{
			i = id[i];
		}
		return i;
	}
	public bool IsConnected(int p,int q)
	{
		return root(p) == root(q);
	}
	public void Union(int p,int q)
	{
		int rootp = root[p];
		int rootq = root[q];
		id[rootp] = rootq;
	}
}
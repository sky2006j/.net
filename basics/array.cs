class c4
{
	public static void Main()
	{
		int []x;
		int n;
		n=int.Parse(System.Console.ReadLine());
		x=new int[n];
		for(int i=0;i<n;i++)
		{
			x[i]=int.Parse(System.Console.ReadLine());
		}
		for(int i=0;i<n;i++)
		{
			System.Console.WriteLine(x[i]);
		}
	}
}
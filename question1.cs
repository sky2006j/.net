class c5
{
	public static void Main()
	{
		int []x;
		int i,n,search;
		n=int.Parse(System.Console.ReadLine());
		
		x=new int[n];
		for(i=0;i<n;i++)
		{
			x[i]=int.Parse(System.Console.ReadLine());
		}
		for(i=0;i<n;i++)
		{
			System.Console.WriteLine(x[i]);
		}
		search=int.Parse(System.Console.ReadLine());
		for(i=0;i<n;i++)
		{
		if(search==x[i])
		{
			System.Console.WriteLine("enter element fount");
			break;
		}
		}
		if(i==n)
		{
		System.Console.WriteLine("enter element not fount");
		}
	}
}
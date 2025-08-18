class c3
{
	public static void Main()
	{
		int c,C,java,total;
		System.Console.WriteLine("enter marks of c");
		c=int.Parse(System.Console.ReadLine());
		System.Console.WriteLine("enter marks of C");
		C=int.Parse(System.Console.ReadLine());
		System.Console.WriteLine("enter marks of java");
		java=int.Parse(System.Console.ReadLine());
		total=c+C+java;
		System.Console.WriteLine("the total marks are"+total);
		if(c>=35 && C>=35 && java>=35)
		{
		if((total)/3>=60)
		{
			System.Console.WriteLine("a grade");
		}
		else if((total)/3>=50)
		{
			System.Console.WriteLine("b grade");
		}
		else if((total)/3>=40)
		{
			System.Console.WriteLine("C grade");
		}
		}
		else 
		{
			System.Console.WriteLine("Fail");
		}
	}
}
		
		
		
		


		
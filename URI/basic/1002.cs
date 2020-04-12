using System;
					
public class Program
{
	public static void Main()
	{
		
		double raio = Convert.ToDouble(Console.ReadLine());
		double pi = 3.14159;
		double area = (pi*(raio*raio));

		Console.WriteLine("A={0}", String.Format("{0:0.####}",area), "\n");
				
	}
}

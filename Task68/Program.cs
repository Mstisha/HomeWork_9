int AkkermanFunc(int m, int n)
{
	if(m == 0)
	{
		return n + 1;
	}
		if(m > 0 && n == 0)
	{
		return AkkermanFunc(m - 1, 1);
	}
	return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
}
		
Console.WriteLine(AkkermanFunc(2,3));
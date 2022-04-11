using System;

namespace Prg
{
    public class Prgs
    {
	public static int[] ArrayOfMultiples(int n, int length) {
		return Enumerable.Range(n, length)
            .Select(n=>n*n)
            .ToArray();
	}
    }
}
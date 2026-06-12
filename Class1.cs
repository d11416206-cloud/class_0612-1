using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

delegate void MyDel(int a, int b);

public class MyMath
{
    public static string str = "";
	public static void Add (int a, int b)
	{
		str += "\n" + (a + b);
	}

    public static void Sub(int a, int b)
    {
        str += "\n" + (a - b);
    }

    public static void Mul(int a, int b)
    {
        str += "\n" + (a * b);
    }

    public static void Div(int a, int b)
    {
        str += "\n" + (a / b);
    }

}

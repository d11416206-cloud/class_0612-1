namespace class_0612_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDel hander = new MyDel(MyMath.Mul);
            hander += new MyDel(MyDel.Sub);
            hander += new MyDel(MyDel.Add);
            hander += new MyDel(MyDel.Div);
            hander -= new MyDel(MyMath.Mul);
            hander -= new MyDel(MyDel.Div);
            hander(10, 20);
            Console.WriteLine(MyMath.str);

        }
    }
}

using System.Runtime;

internal class Program
{
    static void Main(string[] args)
    {
        //baitap01();
        //baitap02();
        baitap03();
    }
    static void baitap01()
    {
        Console.WriteLine("Nhap so vao day: ");
        string num_str = Console.ReadLine();
        int num = Convert.ToInt16(num_str);
        Console.WriteLine($"So nha cua anh A la: {num}");
    }
    static void baitap02()
    {
        Console.WriteLine("Nhap vao chu vi hinh tron: ");
        string cv_string = Console.ReadLine();
        double cv = Convert.ToDouble(cv_string);
        const double pi = 3.14;
        double bk = cv /pi/2;
        double S = bk * bk * pi;
        Console.WriteLine("ban kinh cua hinh tron la: {0}", bk);
        Console.WriteLine("dien tich cua hinh tron la: {0}", S);
    }
    static void baitap03(){
    Console.WriteLine("Hello");
}
}

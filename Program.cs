internal class Program
{
    static void Main(string[] args)
    {
        //baitap01();
        //baitap02();
        //baitap03();
        //baitap04();
        //baitap05();
        //baitap08();
        //baitap09();
    }
    static void baitap01()
    {
        Console.WriteLine("Nhap vao so thu nhat");
        string num01_string = Console.ReadLine();
        int num01 = Convert.ToInt32(num01_string);
        Console.WriteLine("Nhap vao so thu hai");
        string num02_string = Console.ReadLine();
        int num02 = Convert.ToInt32(num02_string);
        int sum = num01 + num02;
        Console.WriteLine("Tong cua {0} và {1} là {2}", num01, num02, sum);

    }
    static void baitap02()
    {
        Console.WriteLine("Nhap vao so thu nhat");
        string num01_string = Console.ReadLine();
        int num01 = Convert.ToInt32(num01_string);
        Console.WriteLine("Nhap vao so thu hai");
        string num02_string = Console.ReadLine();
        int num02 = Convert.ToInt32(num02_string);
        int temp = num01;
        num01 = num02;
        num02 = temp;
        Console.WriteLine("Vi tri cua hai so sau khi hoan doi la {0},{1}",num01, num02);

    }
    static void baitap03() {
        Console.WriteLine("Nhap vao mot so thap phan");
        string num_string = Console.ReadLine();
        double num = Convert.ToDouble(num_string);
        double kq = num * 100;
        Console.WriteLine($"Ket qua la {kq}");
    }
    static void baitap04() {
        Console.WriteLine("Nhap vao feet");
        string feet_string = Console.ReadLine();
        double feet = Convert.ToDouble(feet_string);
        const double oneMeters = 0.3048;
        double feetToMeters = feet * oneMeters;
        Console.WriteLine("{0} feet bang {1} Meters",feet, feetToMeters);
    }
    static void baitap05()
    {
        Console.WriteLine("Nhap vao Celsius ");
        string celsius_string = Console.ReadLine();
        double celsius = Convert.ToDouble(celsius_string);
        double fahrenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine($"{celsius} doi qua fahrenheit la {fahrenheit}");
    }
    static void baitap08() {
        Console.WriteLine("Nhap vao ban kinh hinh tron ");
        string r_string = Console.ReadLine();
        double r = Convert.ToDouble(r_string);
        const double pi = 3.14;
        double S= r*r*pi;
        Console.WriteLine($"Dien tich hinh tron voi ban kinh {r} la {S}");

    }
    static void baitap09() {
        Console.WriteLine("Nhap vao do dai mot canh cua hinh vuong ");
        string a_string = Console.ReadLine();
        double a = Convert.ToDouble(a_string);
        double S = a * a;
        Console.WriteLine($"Dien tich hinh vuong canh {a} la {S}");
    }
}
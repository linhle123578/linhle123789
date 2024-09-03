internal class Program
{
    static void Main(string[] args)
    {
        //baitap01();
        //baitap02();
        //baitap03();
        //baitap04();
        //baitap05();
        //baitap06();
        //baitap08();
        //baitap09();
        //baitap10();
        baitap11();
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
        //string celsius_string = Console.ReadLine();
        float celsius = Convert. ToSingle(Console.ReadLine());
        float fahrenheit = celsius * 9 / 5 + 32;
        float kelvin = celsius + 273;
        /*double celsius = Convert.ToDouble(celsius_string);
        double fahrenheit = (celsius * 9 / 5) + 32;
        double kelvin = celsius + 274;*/
        Console.WriteLine($"{celsius} doi qua fahrenheit la {fahrenheit}");
        Console.WriteLine($"{celsius} doi qua kelvin la {kelvin}");
    }
    static void baitap06()
    {
        Console.WriteLine("sizeof(char)     : {0}", sizeof(char));
        Console.WriteLine("sizeof(byte)     : {0}", sizeof(byte));
        Console.WriteLine("sizeof(sbyte)    : {0}", sizeof(sbyte));
        Console.WriteLine("sizeof(float)    : {0}", sizeof(float));
        Console.WriteLine("sizeof(ushort)   : {0}", sizeof(ushort));
        Console.WriteLine("sizeof(double)   : {0}", sizeof(double));
        Console.WriteLine("sizeof(int)      : {0}", sizeof(int));
        Console.WriteLine("sizeof(bool)     : {0}", sizeof(bool));
        Console.WriteLine("sizeof(short)    : {0}", sizeof(short));
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
    static void baitap10() {
        Console.WriteLine("Nhap vao so ngay");
        string numDays_str = Console.ReadLine();
        double numDays = Convert.ToInt32(numDays_str);
        double years = Math.Floor(numDays / 365);
        double weeks = Math.Floor((numDays - years * 365) / 7);
        double days = numDays - (years * 365 + weeks * 7);
        Console.WriteLine($"Tu {numDays} ngay co {years} nam {weeks} tuan {days} ngay");
    }
    static void baitap11()
    {
        Console.WriteLine("Nhap vao ban kinh");
        float radius = Convert.ToSingle(Console.ReadLine());
        const double pi = Math.PI;
        //float surface = 4 * radius * radius * pi;
        //float volume = 4 / 3 * radius * radius * radius * pi;
        double surface = Math.Pow(radius, 2) * pi * 4;
        double volume = Math.Pow(radius, 3) * pi * 4/3;
        Console.WriteLine($"Dien tich be mat hinh cau la {surface}");
        Console.WriteLine($"The tich hinh cau la {volume}");
    }
}
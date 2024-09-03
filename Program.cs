using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        //baitap01();
        //baitap02();
        //baitap03();
        //baitap04();
        //baitap05();
        //baitap06();
        //baitap07();
        // baitap08();
        //baitap09();
        baitap10();
    }
    static void baitap01()
    {
        Console.WriteLine("Nhap vao mot so ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number % 2 == 0)
        {
            Console.WriteLine("So chan");
        }
        else
        {
            Console.WriteLine("So le");
        }
    }
    static void baitap02()
    {
        Console.WriteLine("Nhap vao so thu nhat ");
        double number01 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhap vao so thu hai ");
        double number02 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhap vao so thu ba ");
        double number03 = Convert.ToDouble(Console.ReadLine());
        double max = Math.Max(Math.Max(number01, number02), number03);
        Console.WriteLine("SO lon nhat la {0}", max);
    }
    static void baitap03()
    {
        Console.WriteLine("Nhap vao toa do x");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhap vao toa do y");
        double y = Convert.ToDouble(Console.ReadLine());
        if (x > 0 && y > 0)
        {
            Console.WriteLine("Goc phan tu thu nhat");
        }
        else if (x < 0 && y > 0) {
            Console.WriteLine("Goc phan tu thu hai");
        }
        else if (x < 0 && y < 0) {
            Console.WriteLine("Goc phan tu thu ba");
        }
        else
        {
            Console.WriteLine("Goc phan tu thu tu");
        }
    }
    static void baitap04()
    {
        Console.WriteLine("Nhap vao canh a");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhap vao canh b");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhap vao canh c");
        double c = Convert.ToDouble(Console.ReadLine());
        double max = Math.Max(Math.Max(a, b), c);
        double min = Math.Min(Math.Min(a, b), c);
        double min02;
        if (a < max && a > min)
        {
            min02 = a;
        }
        else if (b < max && b > min) {
            min02 = b;
        }
        else
        {
            min02 = c;
        }
        if (a + b > c && a + c > b && b + c > a)
        {
            if (a == b && a == c)
            {
                Console.WriteLine("tam giac deu");

            }
            else if (a == b || b == c|| a==c)
            {
                Console.WriteLine("tam giac can");
            }
            else if (Math.Pow(min, 2) + Math.Pow(min02, 2) == Math.Pow(max, 2))
            {
                Console.WriteLine("tam giac vuong");
            }
            else if (a==b || a==c || b==c && Math.Pow(min, 2) + Math.Pow(min02, 2) == Math.Pow(max, 2))
            {
                Console.WriteLine("tam giac vuong can");
            }
            else
            {
                Console.WriteLine("tam giac thuong");
            }
        }
        else Console.WriteLine("khong la tam giac");
    }
    static void baitap05()
    {
        for (int i = 2; i < 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.Write("{0} * {1} = {2} ",i,j, i * j);
                Console.WriteLine();
                //Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
    static void baitap06()
    {
        double sum=0.0;
        Console.WriteLine("Nhap vao so n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <=n; i++)
        {
            sum += 1.0 / i;
            Console.Write(" 1/{0} + ", i);
        }
        Console.WriteLine("= {0}", sum);
    }
    static void baitap07()
    {
        Console.WriteLine("Nhap vao mot so bat ki: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        for (int i = 1;i < number; i++)
        {
            if (number  % i == 0)
            {
                sum += i;
            }
        }
        if (sum==number)
        {
            Console.WriteLine("{0} la so hoan hao",number);
        }
        else
        {
            Console.WriteLine("{0} khong la so hoan hao", number);
        }
    }
    static void baitap08()
    {
        Console.WriteLine("Nhap vao mot so bat ki ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number < 0)
        {
            Console.WriteLine("{0} khong la so nguyen to", number);
            return;
        }
        if (number == 0 || number == 1)
        {
            Console.WriteLine("{0} khong la so nguyen to", number);
            return;
        }
        if (number == 2)
        {
            Console.WriteLine("{0} la so nguyen to", number);
            return;
        }
        int t = 0;
        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
            {
                t += 1;
            }
        }
        if (t == 0)
        {
            Console.WriteLine("{0} la so nguyen to", number);
        }
        else
        {
            Console.WriteLine("{0} khong la so nguyen to", number);
        }
    }    
    static void baitap09()
    {
        double sum = 0;
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("Nhap vao so bat ki ");
            int number =Convert.ToInt32(Console.ReadLine());
            sum += number;
        }
        double average = sum / 10;
        Console.WriteLine($"Tong la {sum}");
        Console.WriteLine($"Trung binh la {average}");
    }
    static void baitap10()
    {
        Console.Write("Enter the number of rows: ");
        int rows = int.Parse(Console.ReadLine());

        // Display the triangle pattern
        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }
}

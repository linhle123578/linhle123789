using System.Diagnostics.CodeAnalysis;

internal class Program
{
    private static void Main(string[] args)
    {
        //baitap01();
        //baitap04();
        //baitap05();
        //baitap06();
        baitap07();
    }
    static void baitap04()
    {
        int [] array = new int[5];
        InputRandomData(array);
        //int arrayl = array.Length-1;
        Console.WriteLine("Nhap vao mot so dac biet");
        int specialNumber = Convert.ToInt32(Console.ReadLine());
        //int[] b = { 3, 5, 6, 4, 7 };
        bool r2 = RemoveElement(array, specialNumber);
        //bo phan tu cuooi
        if (r2)
            Array.Resize(ref array, array.Length - 1);
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
        /*for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == specialNumber)
            {
                array[i + 1] = array[i];
                array.Length - 1;
            }
            
        }
        for (int i = 0; i <= arrayl; i++)
        {
            Console.WriteLine(array[i]);
        }*/
        }
    static void baitap01()
    {
        int sum = 0;
        int average = 0;
        int[] a = new int[5];
        InputRandomData(a);
        for (int i = 0; i < a.Length; i++)
        {
            sum += a[i];
            average = sum / 5;
        }
        Console.WriteLine(sum);
        Console.WriteLine(average);
    }
    static void baitap05()
    {
        int[] array = new int[5];
        InputRandomData(array);
        int min = array[0];
        int max = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min) min = array[i];
            if (array[i] > max) max = array[i];
        }
        Console.WriteLine(min);
        Console.WriteLine(max);
    }
    static void baitap06()
    {
        int[] array = new int[5];
        InputRandomData(array);
        Array.Reverse(array);
        for (int i = 0;i< array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
    static void baitap07()
    {
        int[] array = new int[5];
        for (int i = 0;i< array.Length; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0;i< array.Length; i++)
        {
            int temp = array[i];
            for (int j =i+1; j < array.Length; j++)
            {
                if (temp== array[j])
                {
                    Console.Write(temp + " ");
                    RemoveElement(array, temp);
                    break;
                }
            }
        }
        
    }
    static void InputRandomData(int[] a)
    {
        Random rnd = new Random();
        for (int i = 0; i < a.Length; i++)
        {
            a[i] = rnd.Next(100);
            Console.WriteLine(a[i]);
        }
        
    }
    static bool RemoveElement(int[] a, int ele)
    {
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == ele)
            {
                for (int j = i; j < a.Length - 1; j++)
                {
                    a[j] = a[j + 1];
                }
                return true;// loai bo phan tu dau tien tim thay
            }
        }
        return false;//khong co phan tu can xoa
    }

}
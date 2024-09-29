internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nhap vao chuoi thu nhat");
        string chuoi01 = Console.ReadLine();
        Console.WriteLine("Nhap vao chuoi thu hai");
        string chuoi02 = Console.ReadLine();
        CheckSubString(chuoi01, chuoi02);
        /*int count = LengthString(baitap02);
        Console.WriteLine(count);*/
        /*int wordCount = TotalWords(baitap);
        Console.WriteLine("Total number of words: " + wordCount);*/
        //CompareString (chuoi01, chuoi02);
        //CountCharacter(chuoi01);
    }
    static int LengthString(string a)
    {
        int dem = 0;
        foreach (char c in a)
        {
            dem++;
        }
        return dem;
    }
    static int TotalWords(string a)
    {
        a = a.Trim();
        if (a == " ")
        {
            return 0;
        }
        string[] words = a.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }
    static void CompareString(string a, string b)
    {
        int count01 = 0;
        int count02 = 0;
        foreach (char c in a)
        {
            count01++;
        }
        foreach (char k in b)
        {
            count02++;
        }
        if (count01 > count02)
        {
            Console.WriteLine("chuoi 1 dai hon chuoi 2");
        }
        else if (count01 == count02)
        {
            Console.WriteLine("hai chuoi bang nhau");
        }
        else
        {
            Console.WriteLine("chuoi 2 dai hon chuoi 1");
        }
    }
    static void CountCharacter(string a)
    {
        int demchucai = 0;
        int demso = 0;
        int demkytu = 0;
        int demkhoangtrong = 0;
        foreach (char i in a)
        {
            if (i >= 65 && i <= 90)
            {
                demchucai++;
            }
            else if (i >= 97 && i <= 122)
            {
                demchucai++;
            }
            else if (i >= 48 && i <= 57)
            {
                demso++;
            }
            else if (i == ' ')
            {
                demkhoangtrong++;
            }
            else
            {
                demkytu++;
            }

        }
        Console.WriteLine(demchucai);
        Console.WriteLine(demso);
        Console.WriteLine(demkytu);
    }
    static void CheckSubString(string a, string b)
    {
        int check = 0;
        int dodai = b.Length;
        for (int i = 0; i < a.Length; i++)
        {
            if (a.Substring(i, dodai) == b)
            {
                check = i;
            }
        }
        //int dodai = b.Length;
        int check2 = check + dodai;
        Console.WriteLine(check);
        Console.WriteLine(check2);
        /*if (check > 0)
        {
            Console.WriteLine("co substring");
        }
        else
        {
            Console.WriteLine("khong co substring");
        }*/
    }
}
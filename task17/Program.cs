//17.	По двум заданным числам проверять является ли одно квадратом другого

    
        Console.Clear();
        int a;
        int b;
        int c;
        string s1;
        System.Console.WriteLine(" введите число  a");
        a = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine(" введите число  b");
        b = Convert.ToInt32(Console.ReadLine());
        c = a / b;
        s1 = (c == b ? "число a является квадратом числа b" : "число a не является квадратом числа b");
        System.Console.WriteLine(s1);
    

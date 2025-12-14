

//using System.Runtime.CompilerServices;

//namespace tuto_01;

//class Program
//{

//    string username = "xhan chan";

//    string city = "yangon";

//    static int point = 1000;

//    static void Main(string[] args)
//    {
//        var t = new Test();

//        Console.WriteLine("this is first program" + args);

//        Console.WriteLine(t.Call());

//        var tester = "this is tester";

//        Console.WriteLine(tester.ToUpper());

//        var age = 22;

//        bool isActive = true;

//        string name = "mgmg";

//        double rate = 9.8;

//        Console.WriteLine("My name is " + name + " I am " + age + " year old");

//        var refrenceVAlue = name;   // that call refrence !
//        Console.WriteLine(refrenceVAlue);

//        refrenceVAlue = "this is reassign the value";  // that call override or reassign!
//        Console.WriteLine(name);
//        Console.WriteLine(refrenceVAlue);  // so string is value type ;
//        Console.WriteLine(name);

//        Number num = new Number();
//        Console.WriteLine(num.score);
//        num.score = 12;
//        Console.WriteLine(num.score);

//        Number num2 = new Number();
//        Console.WriteLine(num2.score);
//        Console.WriteLine(num2.score);
//        Console.WriteLine(num.score);

//        var mlbb = " moblie legend bung bang";
//        Console.WriteLine(mlbb.ToUpper());

//        int k = 4097;
//        Console.WriteLine((char)k);
//        Console.WriteLine(new User());

//        User user = new User();
//        //user.Name("mg mg");

//        User.Name("ko ko");

//        Console.WriteLine(User.name);

//        Program p = new();
//        p.Greeting("su su");

//        Program.Age(10);

//        Age(55);
//        name = "change name";
//        p.Greeting(name);

//        User.Name("chan");

//        Console.WriteLine(Program.score);
//        Number.TotalScore(99);
//        Console.WriteLine(Program.score);


//        Console.WriteLine(p.username);
//        p.username = name;
//        Console.WriteLine(p.username);

//        Console.WriteLine(point);
//        Program.point = 999;
//        Console.WriteLine(Program.point);

//        p.Print();

//        Program.StaticPrint();

//        Person person = new Person();
//        person.SetUser("hoho",22);

//        person.SetAmount(500);
        
//    }

//    public void Greeting(string name)
//    {
//        Console.WriteLine(name);
//    }

//    public static void Age(int age)
//    {
//        Console.WriteLine(age); 
//    }

//    public static int score = 0;
//    public static void Score(int score)
//    {
//        Program.score = score;
//    }


//    public void Print()
//    {   
//        Console.WriteLine(username);
//        Console.WriteLine(Program.point);
//        Console.WriteLine(point);
//        Console.WriteLine(city);
//        Console.WriteLine(this.city);
//    }

//    static void StaticPrint()
//    {
//        Console.WriteLine(point);

//        Program p3 = new ();
//        Console.WriteLine(p3.username);
//        Console.WriteLine(p3.city);
//    }

//}

//internal class Test
//{
//    public string Call()
//    {
//        return "this is call";
//    }
//}

//internal class Number
//{
//    public int score = 22;

//    public static void TotalScore(int score)
//    {
//        Program.Score(score);
//        Console.WriteLine(score);
//    }
//}


//internal class User
//{
//    public static readonly string name = "Aung Nyein Chan";

//    public static void Name(string name)
//    {
//        Console.WriteLine(name);    
//    }
//}


//internal class Person
//{
//    string personName= "";

//    int age;

//    int amount = 1000;

//    public void SetUser(string name, int age)
//    {
//        this.personName = name;
//        this.age = age;
//        Console.WriteLine(name);
//        Console.WriteLine(age);
//    }

//    public void SetAmount(int amount)
//    {
//        this.amount = amount;
//        Console.WriteLine(this.amount);
//    }



//}




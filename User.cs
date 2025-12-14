//using System;

//namespace tuto_01;

//public class User
//{
//	string name = "";
//	int age;
//	string address = "";
//	static long phone = 0977777777;
//	CreateUserDto  user;

//	static Animal dog = new Animal();



//	public void SetUser(string name, int age)
//	{
//		this.name = name;
//		this.age = age;
//		this.address = "Yangon";
//		User.phone = 09343453453;
//        Console.WriteLine("Set user ...finished!");
//	}

////	static void Main(string[] args)
////	{

////		User userOne = new();
////		Console.WriteLine(userOne);
////		userOne.SetUser("ko ko", 22);

////		Console.WriteLine(userOne.name);
////		Console.WriteLine(userOne.age);
////		Console.WriteLine(userOne.address);
////		Console.WriteLine(User.phone);

////		Animal animal = new();
////		animal.Run("Cat");

////		var eat = animal.Eat();
////		Console.WriteLine(eat);

////		var sleep = Animal.Sleep();
////		Console.WriteLine(sleep);

////		CreateUserDto userDto = new();
////		Console.WriteLine(userDto);

////		userDto.name = "hoho";
////		userDto.email = "hoho@gmail.com";
////		userDto.password = "123123123";


////        User u = new User();
////		u.user = userDto;

////		u.user.name = "Jojo";
////        Console.WriteLine(u.user.password);
////        Console.WriteLine(u.user.name);

////		userDto.Test();

////		User.dog.Run("mg nyo");
////        Console.WriteLine(dog.Eat());


////		//userDto
////		CreateUserDto.StaticCallAll();
////    }
////}


//internal class CreateUserDto
//{
//	public string name;

//	public string email;

//	public string password = "123123123";


//	public void Test()
//	{
//        Console.WriteLine(this.name);
//        Console.WriteLine(this.email);
//        Console.WriteLine(this.password);

//		var language = "c sharp";
//        Console.WriteLine(language);
//    }

//	public void CallAll()
//	{
//		this.Test();
//	}

//	public static void StaticCallAll()
//	{
//		CreateUserDto cu = new CreateUserDto();
//		cu.name = "sadfasd";
//		cu.email = "sadfasd";
//        Console.WriteLine("_________________");
//		cu?.Test();
//	}
//}

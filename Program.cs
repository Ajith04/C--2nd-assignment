using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Project002
{

    public class Products
    {
        public string Name;
        public string Category;
        public int Price;

    }

    public class Climate
    {
        public string City;
        public string Today;
        public string Day2;
        public string Day3;
        public string Day4;
        public string Day5;

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //printHello();
            //greetUser("Ajith");
            //greetUser("Thanura");
            //Console.WriteLine(calculateSum(5,3));
            //printMessage("It's without argument");
            //printMessage();
            //displayInfo("Ajith", 33);
            //displayInfo("Ajith");
            //orderCoffee(milk: false, size: "Medium", sugar: 50);
            //bookFlight(classType : "Economy", destination : "New York", date : "01.05.2025");
            //Console.WriteLine(multiplyNumbers(5,9));
            //Console.WriteLine(multiplyNumbers(3.32,5.8));
            //Console.WriteLine(multiplyNumbers(2,8,4));
            //display("Ajith");
            //display(20);
            //display(0.38);
            //Console.WriteLine(calculateArea(6));
            //Console.WriteLine(calculateArea(4, 5));
            //Console.WriteLine(convertTemperature(1));
            //Console.WriteLine(convertTemperature(32.5));
            //addToCart("Mobile", 5);
            //addToCart("Mouse", 12, 800);
            //transfer(8010, 5000);
            //transfer(8010, 12000, "Water bill payment");
            //Console.WriteLine(calculateDistance(10, 6, 7, 4));
            //Console.WriteLine(calculateDistance(10, 6, 7, 4, 7, 4));

            //Console.WriteLine(authenticUser("admin", 123));
            //Console.WriteLine(authenticUser("admin", 123, "Jaffna"));

            //sendEmail("sritharanajith04@gmail.com", "Hi... Welcome");
            //List<string> carboncopy = new List<string> {"1234@gmail.com","sample@gmail.com"};
            //sendEmail("sritharanajith04@gmail.com", "Hi... Welcome", "Birthday Invitation", carboncopy);

            //Console.WriteLine(calculateDiscount(5000, 10));
            //Console.WriteLine(calculateDiscount(5000, 10, false));

            //uploadFile(new Url("www.google.com"));
            //uploadFile(new Url("www.google.com"), "Flower image", new DateTime(2024,2,3));


            //processPayment(12000, "Paypal");
            //processPayment(8000, "credit card", 8896254398772434);

            //Console.WriteLine(registerUser("ajith", 1234));
            //Console.WriteLine(registerUser("ajith", 1234,"sritharanajith04@gmail.com",755255050));

            //Console.WriteLine(reserveBook(105, 1009));
            //Console.WriteLine(reserveBook(105, 1009, new DateTime(2024, 5, 4)));

            //Console.WriteLine(generateReport("Sales"));
            //Console.WriteLine(generateReport("Inventory", DateTime.Now, DateTime.Now));

            //searchProduct("Chair");
            //searchProduct("Electronics",5000,15000);

            //getWeatherForecast("Jaffna");
            //getWeatherForecast("Jaffna",3);

            //Console.WriteLine(calculateTax(100000));
            //Console.WriteLine(calculateTax(100000));

            //bookTicket("Billa", 4);
            //bookTicket("Mankatha", 12, new DateTime(2024,12,05));

            //Console.WriteLine(formatDate(new DateTime(2024,4,5)));
            //Console.WriteLine(formatDate(new DateTime(2024, 4, 5), new DateTime(24,8,7)));

            //orderFood("Noodles", 5);
            //orderFood("Appam", 2,"with egg");

            //bookTravel("Colombo", new DateTime(2024, 8, 1));
            //bookTravel("Colombo", new DateTime(2024, 8, 1),5,"Economy");

            //scheduleMeeting("Education", new DateTime(2024, 6, 15));
            //List<string> mparticipants = new List<string> { "Ajith", "Thanura", "Vijay", "Trisha" };
            //var final = (from names in mparticipants select names).ToList();
            //scheduleMeeting("Education", new DateTime(2024, 6, 15),final);


            Console.ReadLine();

        }

        //public static void printHello()
        //{
        //    Console.WriteLine("Hello, World!");
        //}

        //public static void greetUser(string name)
        //{
        //    Console.WriteLine($"Hello {name}");
        //}

        //public static int calculateSum(int no1, int no2)
        //{
        //    return no1 + no2;
        //}

        //public static void printMessage(string message = "Hello, World!")
        //{
        //    Console.WriteLine(message);
        //}

        //public static void displayInfo(string name, int age = 25)
        //{
        //    Console.WriteLine($"Name : {name} Age : {age}");
        //}

        //public static void orderCoffee(string size, int sugar, bool milk)
        //{
        //    Console.WriteLine($"Size : {size}\t Sugar : {sugar}\t Milk : {milk}");
        //}

        //public static void bookFlight(string destination, string date, string classType)
        //{
        //    Console.WriteLine($"Destination : {destination}\t Date : {date}\t Class Type : {classType}");
        //}

        //public static int multiplyNumbers(int no1, int no2)
        //{
        //    return no1 * no2;
        //}

        //public static double multiplyNumbers(double no1, double no2)
        //{
        //    return no1 * no2;
        //}

        //public static int multiplyNumbers(int no1, int no2, int no3)
        //{
        //    return no1 * no2 * no3;
        //}

        //public static void display(string word)
        //{
        //    Console.WriteLine(word);
        //}

        //public static void display(int no)
        //{
        //    Console.WriteLine(no);
        //}

        //public static void display(double no)
        //{
        //    Console.WriteLine(no);
        //}

        //public static double calculateArea(int radius)
        //{
        //    return Math.PI * radius * radius;
        //}

        //public static int calculateArea(int length, int width)
        //{
        //    return length * width;
        //}

        //public static double convertTemperature(int input)
        //{
        //    return (input * 9 / 5) + 32;
        //}

        //public static double convertTemperature(double input)
        //{
        //    return (input - 32) * 5 / 9;
        //}

        //public static void addToCart(string name, int quantity)
        //{
        //    Console.WriteLine(name + "-" + quantity);   
        //}

        //public static void addToCart(string name, int quantity, int price)
        //{
        //    Console.WriteLine($"{name} : {quantity} * {price} => {quantity*price}");
        //}

        //public static void transfer(int acNumber, int amount)
        //{
        //    Console.WriteLine($"{acNumber} - {amount}");
        //}

        //public static void transfer(int acNumber, int amount, string description)
        //{
        //    Console.WriteLine($"{acNumber} - {amount} - {description}");
        //}

        //public static double calculateDistance(int x1, int x2, int y1, int y2)
        //{
        //    return Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2));
        //}

        //public static double calculateDistance(int x1, int x2, int y1, int y2, int z1, int z2)
        //{
        //    return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2-z1),2));
        //}

        //public static string formatDate(DateTime date)
        //{
        //    return (date.ToShortDateString());
        //}

        //public static string formatDate(DateTime date, DateTime anotherdate)
        //{
        //    return ($"{date.ToShortDateString()} {anotherdate.ToShortDateString()}");
        //}

        //public static bool authenticUser(string username, int password)
        //{
        //    bool answer = false;
        //    if (username == "admin" && password == 123)
        //    {
        //        answer =  true;
        //    }
        //    return answer;
        //}

        //public static bool authenticUser(string username, int password, string answer)
        //{
        //    bool output = false;
        //    if (username == "admin" && password == 123 && answer == "Jaffna")
        //    {
        //        output = true;
        //    }
        //    return output;
        //}

        //public static void sendEmail(string email, string message)
        //{
        //    Console.WriteLine($"{email}\t{message}");
        //}

        //public static void sendEmail(string email, string message, string subject, List<string> cc)
        //{
        //    Console.WriteLine($"{email}\t{message}");
        //    Console.WriteLine($"{subject}\t");

        //    foreach (string c in cc)
        //    {
        //        Console.WriteLine(c);
        //    }
        //}

        //public static int calculateDiscount(int price, int percentage)
        //{
        //    return price - price * percentage / 100;
        //}

        //public static int calculateDiscount(int price, int percentage, bool wtd)
        //{
        //    int final = 0;
        //    if (wtd == true)
        //    {
        //        final = price - price * percentage / 100;
        //    }
        //    else
        //    {
        //        final = price - 150;
        //    }

        //    return final;
        //}

        //public static void uploadFile(Url filePath)
        //{
        //    Console.WriteLine($"{filePath} is uploaded successfully");

        //}

        //public static void uploadFile(Url filePath, string description, DateTime time)
        //{
        //    Console.WriteLine($"{filePath} is uploaded successfully");
        //    Console.WriteLine($"{description}\t{time}");

        //}

        //public static void processPayment(int amount, string method)
        //{
        //    Console.WriteLine(amount + " " + method);
        //}

        //public static void processPayment(int amount, string method, long details)
        //{
        //    Console.WriteLine(amount + " " + method + " " + details);
        //}

        //public static bool registerUser(string username, int password)
        //{
        //    return true;
        //}

        //public static bool registerUser(string username, int password, string mail, int phone)
        //{
        //    return true;
        //}

        //public static bool reserveBook(int bookid, int userid)
        //{
        //    return true;
        //}

        //public static bool reserveBook(int bookid, int userid, DateTime date)
        //{
        //    return true;
        //}

        //public static string generateReport(string type)
        //{
        //    string answer = "";
        //    if (type == "Sales")
        //    {
        //        answer = "Sales Report Details";
        //    }
        //    else if(type == "Inventory")
        //    {
        //        answer = "Inventory Report Details";
        //    }
        //    return answer;
        //}

        //public static string generateReport(string type, DateTime from, DateTime to)
        //{
        //    string answer = "";
        //    if (type == "Sales")
        //    {
        //        answer = ($"Sales Report Details from {from} to {to}");
        //    }
        //    else if (type == "Inventory")
        //    {
        //        answer = ($"Inventory Report Details from {from} to {to}");
        //    }
        //    return answer;
        //}

        //public static void searchProduct(string keyword)
        //{
        //    List<Products> products = new List<Products>
        //    {
        //        new Products {Name="Monitor", Category = "Electronics", Price = 12000},
        //        new Products {Name="Chair", Category = "Furniture", Price = 5000},
        //        new Products {Name="Pen", Category = "Stationery", Price = 8000},
        //        new Products {Name="System", Category = "Electronics", Price = 800},
        //        new Products {Name="UPS", Category = "Electronics", Price = 400}

        //    };

        //    var findkeyword = from a in products where a.Name == keyword select a;

        //    foreach(Products p in findkeyword) {
        //        Console.WriteLine(($"{p.Name},{p.Category},{p.Price}"));
        //    }
        //}

        //public static void searchProduct(string category, int pricefrom, int priceto)
        //{
        //    List<Products> products = new List<Products>
        //    {
        //        new Products {Name="Monitor", Category = "Electronics", Price = 12000},
        //        new Products {Name="Chair", Category = "Furniture", Price = 5000},
        //        new Products {Name="Pen", Category = "Stationery", Price = 8000},
        //        new Products {Name="System", Category = "Electronics", Price = 800},
        //        new Products {Name="UPS", Category = "Electronics", Price = 400}

        //    };

        //    var findkeyword = from a in products where a.Category == category && a.Price >pricefrom && a.Price <priceto select a;

        //    foreach (Products p in findkeyword)
        //    {
        //        Console.WriteLine(($"{p.Name},{p.Category},{p.Price}"));
        //    }
        //}


        //public static void getWeatherForecast(string city)
        //{
        //    List<Climate> climate = new List<Climate>
        //    {
        //        new Climate { City = "Jaffna", Today = "Cloudy", Day2 = "Sunny", Day3 = "Rainy", Day4 = "Cloudy", Day5 = "Rainy"},
        //        new Climate { City = "Colombo", Today = "Sunny", Day2 = "Rainy", Day3 = "Rainy", Day4 = "Cloudy", Day5 = "Rainy"},
        //        new Climate { City = "Vavuniya", Today = "Rainy", Day2 = "Sunny", Day3 = "Cloudy", Day4 = "Cloudy", Day5 = "Rainy"},
        //        new Climate { City = "Kilinochchi", Today = "Cloudy", Day2 = "Sunny", Day3 = "Cloudy", Day4 = "Cloudy", Day5 = "Rainy"},
        //        new Climate { City = "Mannar", Today = "Rainy", Day2 = "Sunny", Day3 = "Rainy", Day4 = "Cloudy", Day5 = "Rainy"},
        //    };

        //    var fclimate = from cl in climate where cl.City == city select cl;

        //    foreach(var cl in fclimate)
        //    {
        //        Console.WriteLine(cl.Today);
        //    }
        //}

        //public static void getWeatherForecast(string city, int days)
        //{
        //    List<Climate> climate = new List<Climate>
        //    {
        //        new Climate { City = "Jaffna", Today = "Cloudy", Day2 = "Sunny", Day3 = "Rainy", Day4 = "Cloudy", Day5 = "Rainy"},
        //        new Climate { City = "Colombo", Today = "Sunny", Day2 = "Rainy", Day3 = "Rainy", Day4 = "Cloudy", Day5 = "Rainy"},
        //        new Climate { City = "Vavuniya", Today = "Rainy", Day2 = "Sunny", Day3 = "Cloudy", Day4 = "Cloudy", Day5 = "Rainy"},
        //        new Climate { City = "Kilinochchi", Today = "Cloudy", Day2 = "Sunny", Day3 = "Cloudy", Day4 = "Cloudy", Day5 = "Rainy"},
        //        new Climate { City = "Mannar", Today = "Rainy", Day2 = "Sunny", Day3 = "Rainy", Day4 = "Cloudy", Day5 = "Rainy"},
        //    };

        //    var fclimate = from cl in climate where cl.City == city select cl;
        //    Climate[] array = fclimate.ToArray();



        //    for (int i = 1; i <= days; i++)
        //    {

        //    }
        //}

        //public static int calculateTax(int amount)
        // {
        //     return amount - amount * 10 / 100;
        // }

        // public static int calculateTax(int amount, int tax = 10)
        // {
        //     return amount - amount * tax / 100;
        // }

        //public static void bookTicket(string moviename, int ticketcount)
        //{
        //    Console.WriteLine($"Movie : {moviename}\t{ticketcount} tickets");
        //}

        //public static void bookTicket(string moviename, int ticketcount, DateTime showtime)
        //{
        //    Console.WriteLine($"Movie : {moviename}\tat {showtime}\t{ticketcount} tickets");
        //}

        //public static void orderFood(string foodname, int quantity)
        //{
        //    Console.WriteLine($"{foodname}\t{quantity}");
        //}

        //public static void orderFood(string foodname, int quantity, string sprequest)
        //{
        //    Console.WriteLine($"{foodname}\t{quantity}\t{sprequest}");
        //}

    //    public static void bookTravel(string destination, DateTime tdate)
    //    {
    //        Console.WriteLine($"to {destination} at{tdate}");
    //    }

    //public static void bookTravel(string destination, DateTime tdate, int travelers, string tclass)
    //{
    //    Console.WriteLine($"to {destination} at{tdate} {travelers} passengers {tclass} class");
    //}

        //public static void scheduleMeeting(string title, DateTime mdate)
        //{
        //    Console.WriteLine($"{title}\t{mdate}");
        //}

        //public static void scheduleMeeting(string title, DateTime mdate, List<string> participants)
        //{
            
        //    Console.WriteLine($"{title}\t{mdate}");
        //    foreach(string participant in participants) {
        //        Console.WriteLine(participant);
        //    }
        //}
    }
}

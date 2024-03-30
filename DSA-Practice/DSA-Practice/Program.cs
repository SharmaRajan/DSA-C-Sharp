// See https://aka.ms/new-console-template for more information


using DSA_Practice.String;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");

        string str = "This string is going to be reversed";

        var reversedString = new ReverseString();
        reversedString.reverse(str);
    }
}




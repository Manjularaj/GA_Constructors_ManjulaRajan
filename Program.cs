namespace GA_Constructors_ManjulaRajan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exploring Constructors in C#");

            // Creating instances using different constructors
            Book book1 = new Book("1984", "George Orwell");
            Console.WriteLine($"Book 1: Title = {book1.Title}, Author = {book1.Author}");

            Book book2 = new Book("The Hobbit");
            Console.WriteLine($"Book 2: Title = {book2.Title}, Author = {book2.Author}");

            //Now due to overload options we can use multiple parameter options to instances.
        }
    }
}
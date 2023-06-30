namespace InheritanceC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post();
            Post post2 = new Post("Thanks for the birthday wishes", true, "FunnyName");
            Post post3= new Post("Hi everyone!",false,"C#DevWithNoJob");
            Console.WriteLine(post3.ToString());

            Console.ReadLine();
        }
    }
}
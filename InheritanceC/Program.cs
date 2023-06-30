namespace InheritanceC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post();
            Post post2 = new Post("Thanks for the birthday wishes", true, "FunnyName");
            Post post3= new Post("Hi everyone!",true,"C#DevWithNoJob");
            Console.WriteLine(post3.ToString());
            ImagePost imagePost1 = new ImagePost("Check out my new shoes","SneekersLover","https://image.com/shoes",true);
            Console.WriteLine(imagePost1.ToString());
            Console.ReadLine();
        }
    }
}
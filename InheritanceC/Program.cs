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
            VideoPost videoPost1 = new VideoPost("Learn c# in 1hour![video]","DeveloperWannaBe","https://tutovidio.com/seesharp",24,true);
            Console.WriteLine(videoPost1.ToString());
            videoPost1.Play();
            Console.WriteLine("Press any key to stop the video!");
            Console.ReadKey();  
            videoPost1.Stop();
            Console.ReadLine();
        }
    }
}
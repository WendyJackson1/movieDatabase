namespace movieDatabase
{
    public class Program
    {
        public static void Main()
        {

            List<Movie> bestMovies = new List<Movie>();

            bestMovies.Add(new Movie("Inside Out", "animated"));
            bestMovies.Add(new Movie( "Soul","animated"));
            bestMovies.Add(new Movie("Coco", "animated"));
            bestMovies.Add(new Movie("UP", "animated"));
            bestMovies.Add(new Movie( "Hacksaw Ridge", "war" ));
            bestMovies.Add(new Movie("Saving Private Ryan", "war" ));
            bestMovies.Add(new Movie("The Imitation Game", "war" ));
            bestMovies.Add(new Movie("Mrs Doubtfire","comedy" ));
            bestMovies.Add(new Movie("The Mask", "comedy" ));
            bestMovies.Add(new Movie("Deadpool", "comedy" ));

            Run h = new Run();

            bool runAgain = true;

            while (runAgain)
            {

                Console.WriteLine("Please input a movie type you can enter Animated, War,or Comedy. Then I can give you a list of that movie type.");
                var userChoice = Console.ReadLine().ToLower();

                if (userChoice == "animated" || userChoice == "war" || userChoice == "comedy")
                {
                    Console.WriteLine("I think that is a good type of movie too");
                    GetMovieType(bestMovies,userChoice);
                }
                else
                {
                    Console.WriteLine("That input was not a valid movie type");
                    Console.WriteLine("Lets try again");
                    continue;
                }

                runAgain = h.RunAgain();
            }
        }
        public static void GetMovieType(List<Movie> movies, string category)
        {
            Console.WriteLine($"Here is a list of our {category} films.");

            for (int i = 0; i <= movies.Count - 1; i++)
            {
                if (movies[i].MovieType == category)
                {

                        Console.WriteLine(movies[i].MovieTitle);
                }

            }
        }
    }
}

using Movies.Logic;
using System;
using System.Threading.Tasks;

namespace Movies.ConsoleApp
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            Console.WriteLine("********** WELCOME TO ABC CINEMAS **********");
            Console.WriteLine();
            var moviesDb = new MoviesDB();
            var movies = moviesDb.ShowMoview();
            Console.WriteLine(     "***** List of Movies Showing Tonight *****");
            Console.WriteLine();
            Console.Write(" => ");
            Console.WriteLine("Select a Movie");
            Console.WriteLine();
            for (int m = 0; m < movies.Length; m++)
            {
                if (movies[m] == null)
                    continue;

                Console.WriteLine($"{m+1} .Movie Title: {movies[m].MovieTitle}");
                Console.WriteLine();
                
            }

            Console.Write("Please Enter a number from the Movie List, to Select: _");
            
            var userInput = Console.ReadLine();
            int userselection;
            while (!int.TryParse(userInput, out userselection)
               || (userselection < 1 || userselection > 5))
            {
                Console.WriteLine("Invalid Input: Select through numbers 1 to 5");
                userInput = Console.ReadLine();
            }
            var selectedMovie = movies[userselection-1];
            Clearscreen();
            Console.WriteLine($"Your Selected Movie is: {selectedMovie.MovieTitle}");
            Console.WriteLine();
            for (int i = 0; i < selectedMovie.MovieTimes.Length; i++)
            {
                Console.WriteLine($"{i + 1} .Movie Time: {selectedMovie.MovieTimes[i]}");
            }
            Console.WriteLine();
            Console.Write("Please select a movie time: _");
            var userInput1 = Console.ReadLine();
            int userTimeSelection;
            while(!int.TryParse(userInput1, out userTimeSelection)
                || (userTimeSelection < 1 || userTimeSelection > 3))
            {
                Console.WriteLine("Invalid Input: Choose from numbers 1 to 3");
                userInput1 = Console.ReadLine();
            }
            var selectedMovieTime = selectedMovie.MovieTimes[userTimeSelection-1];
            Clearscreen();
            Console.WriteLine($"Your selected movie time is: {selectedMovieTime}");
            Clearscreen();
            Console.Write("Please Enter Firstname: ");
            var firstName = Console.ReadLine();

            Console.Write("Please Enter Lastname: ");
            var lastName = Console.ReadLine();
            Console.Write("Please Enter Customer Phone: ");

            string phone = Console.ReadLine();
            long convertedPhone;
            while(!long.TryParse(phone,out convertedPhone)==true)
            {
                Console.WriteLine("Invalid Input: Enter a valid phone number?");
                phone = Console.ReadLine();
            }
            Console.WriteLine(convertedPhone);
            
            Clearscreen();
            //prompt user to select movie time
            // use selection  to find index in selectedMovie.MovieTimes array
            //pass value into processTicket method
            var ticket = moviesDb.ProcessTicket(selectedMovie, selectedMovieTime, firstName, lastName, phone);
           
            Console.WriteLine($"Customer Ticket Details: " );
            Console.WriteLine($"Movie Title: {ticket.SelectedMovieTitle}");
            Console.WriteLine($"Movie Id:  {ticket.MovieId}");
            Console.WriteLine($"Movie Time: {ticket.MovieTime}");
            Console.WriteLine($"Movie Rating:  {ticket.Rating}");
            Console.WriteLine($"Movie Price: {"$"}{ticket.MoviePrice}");
            Console.WriteLine($"Customer FirstName: {ticket.CustomerFirstName}");
            Console.WriteLine($"Customer LastName: {ticket.CustomerLastName}");
            Console.WriteLine($"Customer Phone: {"+234"}{ticket.CustomerPhone}");

            

            while (true)
            {
                await Task.Delay(1000);
            }
        } 
        private static void Clearscreen()
        {
            Console.Clear();
        }

        
    }
}

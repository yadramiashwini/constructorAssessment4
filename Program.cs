namespace constructorAssessment4
{
    using System;

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int NumberOfPages { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public int DaysToRead { get; set; }
        public double DailyLateFeeRate { get; set; }

        // Method to calculate average pages read per day
        public double CalculateAveragePagesReadPerDay()
        {
            return (double)NumberOfPages / DaysToRead;
        }

        // Method to calculate late fee
        public double CalculateLateFee()
        {
            if (ReturnDate > DueDate)
            {
                int lateDays = (ReturnDate - DueDate).Days;
                return lateDays * DailyLateFeeRate;
            }
            return 0;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // Create a new Book object
            Book book = new Book();

            // Get book details from the user
            Console.Write("Enter the title: ");
            book.Title = Console.ReadLine();

            Console.Write("Enter the author: ");
            book.Author = Console.ReadLine();

            Console.Write("Enter the number of pages: ");
            book.NumberOfPages = int.Parse(Console.ReadLine());

            Console.Write("Enter the due date (MM/DD/YYYY): ");
            book.DueDate = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter the return date (MM/DD/YYYY): ");
            book.ReturnDate = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter the days to read: ");
            book.DaysToRead = int.Parse(Console.ReadLine());

            Console.Write("Enter the daily late fee rate: ");
            book.DailyLateFeeRate = double.Parse(Console.ReadLine());

            // Calculate average pages read per day and late fee
            double averagePagesReadPerDay = book.CalculateAveragePagesReadPerDay();
            double lateFee = book.CalculateLateFee();

            // Display the results
            Console.WriteLine($"Average Pages Read Per Day: {averagePagesReadPerDay}");
            Console.WriteLine($"Late Fee: {lateFee}");
        }
    }

}

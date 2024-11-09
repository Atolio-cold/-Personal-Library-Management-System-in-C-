using System;
using System.Collections.Generic;


namespace LibrayManagmetn.books {

        class Book 
        {
            

            public int Id { get; set; }
            public string Title { get; set; }
            public string Author { get; set; }
            public string Genre { get; set; }
            public int PublicationYear { get; set; }
            public string Status { get; set;}    
        



        public Book(int id, string title, string author, string genre, int publicationYear, string status)
        {
            Id = id;
            Title = title;
            Author = author;
            Genre = genre;
            PublicationYear = publicationYear;
            Status = status;
            
        }
        


        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Genre: {Genre}");
            Console.WriteLine($"Publication Year: {PublicationYear}");
            Console.WriteLine($"Status: {Status}");
        }
     }
}
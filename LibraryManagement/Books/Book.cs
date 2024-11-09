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



        public override string ToString()
        {
            return($"{Id}: /n{Title}: /n{Author}: /n{Genre}: /n{PublicationYear}: /n{Status}");
        }
    }
}

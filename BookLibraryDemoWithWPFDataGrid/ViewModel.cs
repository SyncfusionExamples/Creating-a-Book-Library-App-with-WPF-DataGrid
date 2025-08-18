using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibraryDemoWithWPFDataGrid
{
    public class LibraryViewModel
    {
        public ObservableCollection<Book> Books { get; set; }

        public LibraryViewModel()
        {
            Books = new ObservableCollection<Book>
            {
            new Book { BookName = "The Sun Also Rises", AuthorName = "Arthur Golden", Genre = "Adventure", PublishedYear = 1986, IsAvailable = false, ReturnTimeline = "3 days" },
            new Book { BookName = "Madame Bovary", AuthorName = "Kurt Vonnegut", Genre = "Fantasy", PublishedYear = 1919, IsAvailable = false, ReturnTimeline = "5 days" },
            new Book { BookName = "The Divine Comedy", AuthorName = "Joseph Heller", Genre = "Historical", PublishedYear = 1956, IsAvailable = true, ReturnTimeline = "5 days" },
            new Book { BookName = "Crime and Punishment", AuthorName = "Homer", Genre = "Historical", PublishedYear = 1970, IsAvailable = true, ReturnTimeline = "7 days" },
            new Book { BookName = "Anna Karenina", AuthorName = "James Joyce", Genre = "Modernist", PublishedYear = 1933, IsAvailable = true, ReturnTimeline = "3 days" },
            new Book { BookName = "The Iliad", AuthorName = "William Faulkner", Genre = "Adventure", PublishedYear = 1910, IsAvailable = false, ReturnTimeline = "3 days" },
            new Book { BookName = "The Bell Jar", AuthorName = "Khaled Hosseini", Genre = "Realist", PublishedYear = 1908, IsAvailable = false, ReturnTimeline = "14 days" },
            new Book { BookName = "Les Misérables", AuthorName = "Homer", Genre = "Fantasy", PublishedYear = 1953, IsAvailable = true, ReturnTimeline = "10 days" },
            new Book { BookName = "Invisible Man", AuthorName = "Charles Dickens", Genre = "Historical", PublishedYear = 2013, IsAvailable = false, ReturnTimeline = "3 days" },
            new Book { BookName = "The Odyssey", AuthorName = "Homer", Genre = "Historical", PublishedYear = 1991, IsAvailable = true, ReturnTimeline = "14 days" },
            new Book { BookName = "The Metamorphosis", AuthorName = "Toni Morrison", Genre = "Surrealist", PublishedYear = 1918, IsAvailable = true, ReturnTimeline = "5 days" },
            new Book { BookName = "Moby Dick", AuthorName = "Charles Dickens", Genre = "Gothic", PublishedYear = 1926, IsAvailable = true, ReturnTimeline = "3 days" },
            new Book { BookName = "Invisible Man", AuthorName = "Oscar Wilde", Genre = "Adventure", PublishedYear = 1920, IsAvailable = true, ReturnTimeline = "14 days" },
            new Book { BookName = "The Count of Monte Cristo", AuthorName = "Joseph Heller", Genre = "Historical", PublishedYear = 1925, IsAvailable = false, ReturnTimeline = "3 days" },
            new Book { BookName = "The Divine Comedy", AuthorName = "Jane Austen", Genre = "Social Commentary", PublishedYear = 2013, IsAvailable = false, ReturnTimeline = "3 days" },
            new Book { BookName = "Beloved", AuthorName = "Homer", Genre = "Philosophical", PublishedYear = 1928, IsAvailable = true, ReturnTimeline = "5 days" },
            new Book { BookName = "The Adventures of Huckleberry Finn", AuthorName = "Ray Bradbury", Genre = "Realist", PublishedYear = 2015, IsAvailable = false, ReturnTimeline = "3 days" },
            new Book { BookName = "Frankenstein", AuthorName = "Mary Shelley", Genre = "Fantasy", PublishedYear = 1995, IsAvailable = true, ReturnTimeline = "7 days" },
            new Book { BookName = "Dracula", AuthorName = "Arthur Golden", Genre = "Philosophical", PublishedYear = 2016, IsAvailable = true, ReturnTimeline = "3 days" },
            new Book { BookName = "The Great Gatsby", AuthorName = "Leo Tolstoy", Genre = "Fantasy", PublishedYear = 1933, IsAvailable = true, ReturnTimeline = "10 days" },
           // new Book { BookName = "Les Misérables", AuthorName = "Gustave Flaubert", Genre = "Gothic", PublishedYear = 1946, IsAvailable = false, ReturnTimeline = "5 days" },
            new Book { BookName = "A Tale of Two Cities", AuthorName = "Mark Twain", Genre = "Science Fiction", PublishedYear = 2007, IsAvailable = true, ReturnTimeline = "5 days" },
            new Book { BookName = "Moby Dick", AuthorName = "Ernest Hemingway", Genre = "Gothic", PublishedYear = 1987, IsAvailable = false, ReturnTimeline = "7 days" },
            new Book { BookName = "Slaughterhouse-Five", AuthorName = "James Joyce", Genre = "Historical", PublishedYear = 1912, IsAvailable = false, ReturnTimeline = "5 days" },
           // new Book { BookName = "Les Misérables", AuthorName = "Charlotte Brontë", Genre = "Satire", PublishedYear = 1990, IsAvailable = false, ReturnTimeline = "14 days" },
            new Book { BookName = "The Kite Runner", AuthorName = "Ray Bradbury", Genre = "Surrealist", PublishedYear = 1945, IsAvailable = false, ReturnTimeline = "3 days" },
            new Book { BookName = "Catch-22", AuthorName = "Jane Austen", Genre = "Poetry", PublishedYear = 1951, IsAvailable = true, ReturnTimeline = "14 days" },
            new Book { BookName = "The Divine Comedy", AuthorName = "Charlotte Brontë", Genre = "Fantasy", PublishedYear = 1972, IsAvailable = false, ReturnTimeline = "7 days" },
            new Book { BookName = "Alice's Adventures in Wonderland", AuthorName = "Lewis Carroll", Genre = "Historical", PublishedYear = 1926, IsAvailable = true, ReturnTimeline = "5 days" },
            new Book { BookName = "1984", AuthorName = "J.D. Salinger", Genre = "Gothic", PublishedYear = 1995, IsAvailable = true, ReturnTimeline = "10 days" },
            new Book { BookName = "The Kite Runner", AuthorName = "Charles Dickens", Genre = "Historical", PublishedYear = 1941, IsAvailable = true, ReturnTimeline = "5 days" },
            new Book { BookName = "Memoirs of a Geisha", AuthorName = "James Joyce", Genre = "Bildungsroman", PublishedYear = 1970, IsAvailable = false, ReturnTimeline = "3 days" },
            new Book { BookName = "The Great Gatsby", AuthorName = "Mary Shelley", Genre = "Surrealist", PublishedYear = 1920, IsAvailable = false, ReturnTimeline = "10 days" },
            new Book { BookName = "Heart of Darkness", AuthorName = "Mary Shelley", Genre = "Modernist", PublishedYear = 1991, IsAvailable = true, ReturnTimeline = "14 days" },
          //  new Book { BookName = "Moby Dick", AuthorName = "Ernest Hemingway", Genre = "Epic", PublishedYear = 1918, IsAvailable = true, ReturnTimeline = "3 days" },
            new Book { BookName = "Madame Bovary", AuthorName = "Gustave Flaubert", Genre = "Epic", PublishedYear = 2002, IsAvailable = false, ReturnTimeline = "3 days" },
           // new Book { BookName = "The Adventures of Huckleberry Finn", AuthorName = "Alexandre Dumas", Genre = "Adventure", PublishedYear = 2020, IsAvailable = true, ReturnTimeline = "3 days" },
            new Book { BookName = "The Chronicles of Narnia", AuthorName = "Leo Tolstoy", Genre = "Adventure", PublishedYear = 2008, IsAvailable = false, ReturnTimeline = "5 days" },
         //   new Book { BookName = "Frankenstein", AuthorName = "Sylvia Plath", Genre = "Science Fiction", PublishedYear = 1969, IsAvailable = false, ReturnTimeline = "10 days" },
           // new Book { BookName = "The Adventures of Huckleberry Finn", AuthorName = "Ernest Hemingway", Genre = "Philosophical", PublishedYear = 1985, IsAvailable = true, ReturnTimeline = "10 days" },
            new Book { BookName = "The Grapes of Wrath", AuthorName = "F. Scott Fitzgerald", Genre = "Surrealist", PublishedYear = 1932, IsAvailable = false, ReturnTimeline = "3 days" },
            new Book { BookName = "Life of Pi", AuthorName = "Harper Lee", Genre = "Historical", PublishedYear = 1920, IsAvailable = true, ReturnTimeline = "10 days" },
          //  new Book { BookName = "Catch-22", AuthorName = "Bram Stoker", Genre = "Psychological", PublishedYear = 1953, IsAvailable = false, ReturnTimeline = "14 days" },
            new Book { BookName = "The Catcher in the Rye", AuthorName = "Khaled Hosseini", Genre = "Historical", PublishedYear = 2018, IsAvailable = true, ReturnTimeline = "7 days" },
            new Book { BookName = "Frankenstein", AuthorName = "Khaled Hosseini", Genre = "Fantasy", PublishedYear = 2016, IsAvailable = false, ReturnTimeline = "7 days" },
          //  new Book { BookName = "The Iliad", AuthorName = "Leo Tolstoy", Genre = "Surrealist", PublishedYear = 2000, IsAvailable = true, ReturnTimeline = "3 days" },
            new Book { BookName = "Slaughterhouse-Five", AuthorName = "Toni Morrison", Genre = "Fantasy", PublishedYear = 2019, IsAvailable = false, ReturnTimeline = "7 days" },
           // new Book { BookName = "The Bell Jar", AuthorName = "J.R.R. Tolkien", Genre = "Science Fiction", PublishedYear = 1902, IsAvailable = true, ReturnTimeline = "10 days" },
            new Book { BookName = "The Grapes of Wrath", AuthorName = "Harper Lee", Genre = "Fiction", PublishedYear = 2007, IsAvailable = false, ReturnTimeline = "7 days" },
         //   new Book { BookName = "Life of Pi", AuthorName = "Harper Lee", Genre = "Modernist", PublishedYear = 2016, IsAvailable = true, ReturnTimeline = "5 days" },
            };

        }
    }
}

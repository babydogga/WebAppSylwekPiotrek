﻿
namespace WebAppSylwek.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public Genre Genre { get; set; }
        public byte GenreId { get; set; }
        public int NumberInStock { get; set; }
    }
}

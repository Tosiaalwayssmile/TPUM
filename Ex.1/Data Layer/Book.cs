using System.Collections.Generic;

namespace DataLayer
{
    class Book : BaseEntity
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public int ReleaseYear { get; set; }
        public IList<string> Genres { get; set; }
    }
}

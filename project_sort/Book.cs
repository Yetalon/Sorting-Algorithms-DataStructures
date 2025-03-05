using System.Text.RegularExpressions;

namespace project_sort
{
    public class Book : IComparable<Book>
    {
        /// <summary>
        /// The authors last name.
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// The authors first name.
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// The tile of the book
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// The release date of the book
        /// </summary>
        public DateTime ReleaseDate { get; set; }
        /// <summary>
        /// Parses a string representing book information into an instace of a <see cref="Book"/>.
        /// </summary>
        /// <param name="line">a string containing information about a book</param>
        /// <returns>A book object</returns>
        private static Book Parse(string line)
        {
            string[] parts = line.Split("|");
            Book book = new()
            {
                LastName = parts[1].Trim(),
                FirstName = parts[2].Trim(),
                Title = parts[3].Trim(),
                ReleaseDate = DateTime.Parse(parts[4])
            };
            return book;
        }
        /// <summary>
        /// Checks to see if the string for a book is deliminated by '|',
        /// contains the 4 parts Last name, first name, title, and realase date,
        /// and checks if the datetime is a real date.
        /// </summary>
        /// <param name="line">A string containing information about a book.</param>
        /// <param name="book">An output parameter that will be populated in <see cref="Parse"/> as a book object</param>
        /// <returns>True if the string can be parsed and false otherwise </returns>
        public bool TryParse(string line, out Book book)
        {
            string pattern = @"\|\s\w*\s*\|\s\w*\s*\|\s[\w*\s\']+\|\s\d{4}-\d{2}-\d{2}\s*\|$";
            Regex regex = new(pattern);
            if (regex.IsMatch(line))
            {
                book = Parse(line);
                return true;
            }
            book = null;
            return false;
        }
        /// <summary>
        /// Converts the book into a formatted string
        /// </summary>
        /// <returns>The book in a formatted string</returns>
        public override string ToString()
        {
            return $"{LastName},{FirstName},\"{Title}\",{ReleaseDate.ToShortDateString()}";
        }
        /// <summary>
        /// Compares two books in order of last name, first name, title, realease date.
        /// In a fashion as so if last name is the same it moves on to first name and so on.
        /// </summary>
        /// <param name="other">The book to compare to.</param>
        /// <returns>
        /// A value indicating the relative order of the books
        /// Negative if the book shold come before the other book
        /// Zero if the books are even
        /// Postive if the book should come after the other book
        // </returns>
        public int CompareTo(Book? other)
        {
            int LastNameComparison = LastName.CompareTo(other.LastName);
            if (LastNameComparison != 0) return LastNameComparison;

            int FirstNameComparison = FirstName.CompareTo(other.FirstName);
            if (FirstNameComparison != 0) return FirstNameComparison;

            int TitleComparison = Title.CompareTo(other.Title);
            if (TitleComparison != 0) return TitleComparison;

            return ReleaseDate.CompareTo(other.ReleaseDate);
        }
    }
}

using System.Diagnostics;

namespace project_sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //InsertionDataInts(args);
            //InsertionDataBooks(args);
        }

        public static void InsertionDataBooks(string[] args) {
            string fileToWriteTo = "./insertion_data_books.txt";
            if (args.Length > 0) {
                foreach (var item in args) {
                    string filename = item;
                    List<Book> books = LoadBookTestData(item);
                    Stopwatch stopwatch = new();
                    InsertionSort<Book> insertionSort = new();
                    stopwatch.Start();
                    insertionSort.Sort(books);
                    stopwatch.Stop();
                    var time = stopwatch.ElapsedMilliseconds;
                    stopwatch.Reset();
                    using (StreamWriter writer = new(fileToWriteTo, true)) {
                        writer.WriteLine($"{filename},{time}");
                    }
                }
            }
        }
        public static void InsertionDataInts(string[] args) {
            string fileToWriteTo = "./insertion_data_ints.txt";
            if (args.Length > 0) {
                foreach (var item in args) {
                    string filename = item;
                    List<int> items = LoadIntegerTestData(item);
                    Stopwatch stopwatch = new();
                    InsertionSort<int> insertionSort = new();
                    stopwatch.Start();
                    insertionSort.Sort(items);
                    stopwatch.Stop();
                    var time = stopwatch.ElapsedMilliseconds;
                    stopwatch.Reset();
                    using (StreamWriter writer = new(fileToWriteTo, true)) {
                        writer.WriteLine($"{filename},{time}");
                    }
                }
            }
        }
        
        public static List<Book> LoadBookTestData (string filePath) {
            List<Book> books = [];
            using (StreamReader reader = new(filePath)) {
                string? line;
                while ((line = reader.ReadLine()) != null) {
                    Book book = new();
                    if (book.TryParse(line, out book)) {
                        books.Add(book);
                    }
                }
            }
            return books;
        }

        public static List<int> LoadIntegerTestData(string filePath) {
            List<int> ints = [];
            using (StreamReader reader = new(filePath)) {
                string? line;
                while ((line = reader.ReadLine()) != null) {
                    if (int.TryParse(line, out int value)) {
                        ints.Add(value);
                    }
                }
            }
            return ints;
        }
    }
}

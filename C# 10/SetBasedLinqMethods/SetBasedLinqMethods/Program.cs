using SetBasedLinqMethods;

var books = new List<Book>
{
    new() { Name = "How to Stop Time",   PublishYear = 2017 },
    new() { Name = "Little Women",       PublishYear = 1868 },
    new() { Name = "Catcher in the Rye", PublishYear = 1951 },
    new() { Name = "The Princess Bride", PublishYear = 1973 },
};

var oldBooks = new List<Book>
{
    new() { Name = "Little Women",        PublishYear = 1868 },
    new() { Name = "The Maid of Orleans", PublishYear = 1801 },
};

var movies = new List<Movie>
{
    new() { Name = "The Princess Bride", ReleaseYear = 1987 },
    new() { Name = "Good Will Hunting",  ReleaseYear = 1997 },
    new() { Name = "Inception",          ReleaseYear = 2010 },
    new() { Name = "Little Women",       ReleaseYear = 1994 },
    new() { Name = "Little Women",       ReleaseYear = 2019 },
    new() { Name = "Little Women",       ReleaseYear = 1949 },
};


// ExceptBy
Console.WriteLine($"***** ExceptBy *****\n");

var newerBooks = books.ExceptBy(oldBooks.Select(ob => ob.Name), b => b.Name);
Console.WriteLine($"Newer books: {string.Join(", ", newerBooks.Select(b => b.Name))}");

var newerBooks_multiple = books.ExceptBy(
    oldBooks.Select(ob => (ob.Name, ob.PublishYear)), b => (b.Name, b.PublishYear));
Console.WriteLine($"Newer books (by Name/Year): " +
    $"{string.Join(", ", newerBooks_multiple.Select(b => b.Name))}");

var booksOnly = books.ExceptBy(movies.Select(m => m.Name), b => b.Name);
Console.WriteLine("Books that aren't movies: " +
    string.Join(", ", booksOnly.Select(x => x.Name)));

var booksOnly_multiple = books.ExceptBy(
    movies.Select(m => (m.Name, m.ReleaseYear)), b => (b.Name, b.PublishYear));
Console.WriteLine("Books that aren't movies (by Name/Year): " +
    string.Join(", ", booksOnly_multiple.Select(x => x.Name)));

var moviesOnly = movies.ExceptBy(books.Select(b => b.Name), m => m.Name);
Console.WriteLine("Movies that aren't books: " +
    string.Join(", ", moviesOnly.Select(x => x.Name)));


// IntersectBy
Console.WriteLine($"\n***** IntersectBy *****\n");

var moviesANDbooks = books.IntersectBy(movies.Select(m => m.Name), b => b.Name);
Console.WriteLine("Books that are also movies: " +
    string.Join(", ", moviesANDbooks.Select(x => x.Name)));


// UnionBy
Console.WriteLine($"\n***** UnionBy *****\n");

var allBooks = books.UnionBy(oldBooks, b => b.Name);
Console.WriteLine("All the books: " +
    string.Join(", ", allBooks.Select(x => x.Name)));

var moviesORbooks = books.UnionBy(movies.Select(movie =>
    new Book { Name = movie.Name, PublishYear = 2000 }), book => book.Name);
Console.WriteLine("Books, movies, or both: " +
    string.Join(", ", moviesORbooks.Select(x => x.Name)));


// DistinctBy
Console.WriteLine($"\n***** DistinctBy *****\n");

var uniqueMovies = movies.DistinctBy(m => m.Name);
Console.WriteLine("Unique list of movies: " +
    string.Join(", ", uniqueMovies.Select(x => $"{x.Name} ({x.ReleaseYear})")));

var uniqueMovies2 = movies.DistinctBy(m => (m.Name, m.ReleaseYear));
Console.WriteLine("Unique list of movie/year combos: " +
    string.Join(", ", uniqueMovies2.Select(x => $"{x.Name} ({x.ReleaseYear})")));

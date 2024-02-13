



using LibraryDb_DataBase.Contexts;

LibraryContext libraryContext = new LibraryContext();


var books = libraryContext.Books.ToList();




foreach (var item in books)
{

    Console.WriteLine(item.Name);
}
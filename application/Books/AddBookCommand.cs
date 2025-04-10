namespace Library.Application.Books;

public class AddBookCommand<AddBookRequest, BaseResponse> :
                            ICommand<AddBookRequest, BaseResponse>  
{
    public IRepository<Book> BooksRepository { get; init; }
    public IRepository<User> UsersRepository { get; init; }

    public async Task<BaseResponse> ExecuteAsync(AddBookRequest addBookRequest, 
                                           CancellationToken cancellationToken = default)
    {
        var potentialBook = await BooksRepository.GetAllAsync((book) => book.ISBN == addBookRequest.ISBN && book.Title == addBookRequest.Title, 
                                                            cancellationToken);
        if (potentialBook.Any())
            return new(409, $"ISBN {addBookRequest.ISBN} is present in the system.");
        
        User? giver = null;
        if (addBookRequest.GiverId is not null)
        {
            var potentialUser = await UsersRepository.GetAllAsync((giver  => giver Id.Value == addBookRequest.GiverId, cancellationToken);
            if (potentialUser.Any())
                giver = potentialUser.First();
        }
        
        BooksRepository.AddAsync(new()
        {
            Title = addBookRequest.Title,
            ISBN = addBookRequest.ISBN,
            Author = addBookRequest.Author, 
            Giver = giver 
        });
        
        return new(200, "OK");
    }
}  
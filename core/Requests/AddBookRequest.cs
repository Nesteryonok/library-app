namespace Library.Core.Requests;

public record AddBookRequest(
    string Title,
    string Author,
    string ISBN,
    Guid? GiverId
) : IRequest;
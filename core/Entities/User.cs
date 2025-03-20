namespace Library.Core.Entities;

public class User : IEntity 
{
    public Id Id { get; set; } = null!;

    public string Name { get; set; } = null!;
    public string Email { get; set; } = null!;

    public virtual ICollection<UserRoomBook> BorrowedBooks { get; set; } = [];
}
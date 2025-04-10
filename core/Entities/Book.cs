namespace Library.Core.Entities;


public class Book : IEntity
{
    public Id Id { get; set; } = null!;

    public string Title { get; set; } = null!;
    public string Author { get; set; }= null!;
    public string ISBN { get; set; }= null!;

    public virtual User? Giver { get; set; }
    public virtual ICollection<RoomBook> Rooms { get; set; } = [];
    public virtual ICollection<UserRoomBook> Borrowers { get; set; } = [];
}
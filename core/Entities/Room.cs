namespace Library.Core.Entities;

public class Room : IEntity 
{
    public Id Id { get; set; } = null!;

    public string Name { get; set; } = null!;
    public virtual ICollection<RoomBook> Books { get; set; } = [];
}
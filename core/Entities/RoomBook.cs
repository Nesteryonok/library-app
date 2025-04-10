namespace Library.Core.Entities;

public class RoomBook : IEntity 
{
    public Id Id { get; set; } = null!;

    public virtual Room Room { get; set; } = null!;
    public virtual Book Book { get; set; } = null!;
    public int Amount { get; set; }

    public virtual ICollection<UserRoomBook> User { get; set; } = [];
}
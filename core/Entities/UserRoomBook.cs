namespace Library.Core.Entities;

public class UserRoomBook : IEntity 
{
    public Id Id { get; set; } = null!;

    public virtual RoomBook RoomBook { get; set; } = null!;
    public virtual User User { get; set; } = null!;

    public DateTime IssuingDate { get; set; }
    public TimeSpan Period { get; set; }
    public DateTime ReturnDate { get; set; }
}
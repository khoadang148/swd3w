﻿namespace DAL.Models
{
    public class Seat : BaseEntity
    {
        public required string SeatNumber { get; set; }

        public required string Row { get; set; }
        public bool IsEnable { get; set; } = true;

        public Guid RoomId { get; set; }

        public virtual Room Room { get; set; }
        public bool IsVip { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}

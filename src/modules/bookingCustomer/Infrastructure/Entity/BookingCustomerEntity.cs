namespace SistemaDeGestionDeTicketsAereos.src.modules.bookingCustomer.Infrastructure.Entity;

public class BookingCustomerEntity
{
    public int IdBookingCustomer { get; set; }
    public int IdBooking { get; set; }
    public int IdUser { get; set; }
    public int IdPerson { get; set; }
    public int IdSeat { get; set; }
    public bool IsPrimary { get; set; }
    public DateTime AssociationDate { get; set; }
}

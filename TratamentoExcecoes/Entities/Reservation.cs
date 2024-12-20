using System;
using TratamentoExcecoes.Entities.Exceptions;
namespace TratamentoExcecoes.Entities;
public class Reservation
{
    public int RoomNumber { get; set; }
    public DateTime CheckIn { get; set; }
    public DateTime CheckOut { get; set; }
    public Reservation()
    {
    }
    public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
    {
        if (checkOut <= checkIn)
        {
            throw new DomainException(" Reservation for updates must be future date");
        }

        RoomNumber = roomNumber;
        CheckIn = checkIn;
        CheckOut = checkOut;
    }
    public int Duration()
    {
        TimeSpan duration = CheckOut.Subtract(CheckIn);
        return (int)duration.TotalDays;
    }

    public void UpadeteDates(DateTime checkIn, DateTime checkOut)
    {
        DateTime now = DateTime.Now;

        if (checkIn < now || checkOut < now)
        {
            throw new DomainException(" Reservation for updates must be future date");
        }
        if (checkOut <= checkIn)
        {
            throw new DomainException("Check- out date must be after chck-in dates");
        }
        CheckIn = checkIn;
        CheckOut = checkOut;


    }


    public override string ToString()
    {
        return "Room "
            + RoomNumber
            + ", Check-in: "
            + CheckIn.ToString("dd/MM/yyyy")
            + ", check-out: "
            + CheckOut.ToString("dd/MM/yyyy")
            + ", "
            + Duration()
            + " nights";

    }
}





using GraphQLProject.Models;

namespace GraphQLProject.Interfaces
{
    public interface IReservationRepository
    {
        List<Reservation> GetReservations();
       
        Reservation AddReservation(Reservation reservation);

        //Reservation UpdateReservation(int id, Reservation reservation);
        //Reservation GetReservationById(int id);

    }
}

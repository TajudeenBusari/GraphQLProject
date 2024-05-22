using GraphQL;
using GraphQL.Types;
using GraphQLProject.Interfaces;
using GraphQLProject.Type;

namespace GraphQLProject.Query //folder containing the class
{
    public class ReservationQuery : ObjectGraphType
    {
        public ReservationQuery(IReservationRepository reservationRepository)
        {   
            //list of reservations
            Field<ListGraphType<ReservationType>>("Reservations").Resolve(context =>
            {
                return reservationRepository.GetReservations();
            });
        }
    }
}
/*Query -->will contain only Get methods
 * we need to derive the class from the object GraphType*/
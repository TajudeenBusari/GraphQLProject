using GraphQL.Types;

namespace GraphQLProject.Type
{
    public class ReservationInputType : InputObjectGraphType
    {
        public ReservationInputType()
        {
            Field<IntGraphType>("id");
            Field<StringGraphType>("customerName");
            Field<StringGraphType>("email");
            Field<StringGraphType>("phoneNumber");
            Field<IntGraphType>("partySize");
            Field<StringGraphType>("specialRequest");
            Field<DateGraphType>("reservationDate");
        } 
    }
}
/*go to the mutation folder and create mutations
 fill according to the Reservation field in the model class*/
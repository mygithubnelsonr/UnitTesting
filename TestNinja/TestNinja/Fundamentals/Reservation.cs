namespace TestNinja.Fundamentals
{
    public class Reservation
    {
        public User MadeBy { get; set; }

        public bool CanBeCancelledBy(User user)
        {
            //if (user.IsAdmin)
            //    return true;

            //if (MadeBy == user)
            //    return true;

            // can reduce the code to only one line
            return (user.IsAdmin || MadeBy == user);

            //return false;
        }

    }

    public class User
    {
        public bool IsAdmin { get; set; }
    }
}
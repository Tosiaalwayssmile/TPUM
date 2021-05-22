namespace DataLayer.Model
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public Cart Cart { get; set; }

        public override bool Equals(object obj)
        {
            User other = (User)obj;

            return (string.Equals(FirstName, other.FirstName) &&
                string.Equals(LastName, other.LastName) &&
                string.Equals(Email, other.Email) &&
                string.Equals(Phone, other.Phone));
        }
    }
}

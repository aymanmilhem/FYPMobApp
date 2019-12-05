using SQLite;

namespace GreenWorld.Models
{
    public class User
    {
        private string _password;

        public string Password { get; set; }

        [PrimaryKey]
        public int Id { get; set; }

        [MaxLength(40)]
        public string FirstName { get; set; }

        [MaxLength(40)]
        public string LastName { get; set; }

        public string FirstLastName => FirstName + " " + LastName;
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public int PointsTotal { get; set; }
        public int[] CompletedTasksIds { get; set; }

        public string ProfileImageUrl { get; set; }

    }
}

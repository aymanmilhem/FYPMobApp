using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace GreenWorld
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(40)]
        public string FirstName { get; set; }

        [MaxLength(40)]
        public string LastName { get; set; }

        public string FirstLastName
        {
            get { return FirstName + " " + LastName; }
            
        }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public int PointsTotal { get; set; }
        public int[] CompletedTasksIds { get; set; }

        public string ProfileImageUrl { get; set; }

    }
}

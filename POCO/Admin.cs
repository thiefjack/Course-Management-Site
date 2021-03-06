﻿namespace POCO
{
    public class Admin
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public override string ToString()
        {
            return this.Id + "-"
                + this.FirstName + "-"
                + this.LastName + "-"
                + this.Email;
        }
    }
}

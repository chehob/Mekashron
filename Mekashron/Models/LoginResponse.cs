﻿namespace Mekashron.Models
{
    public class LoginResponse
    {
        public int EntityId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public int ResultCode { get; set; }
        public string ResultMessage { get; set; }

    }
}

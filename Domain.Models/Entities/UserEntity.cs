using System;
using Doroga.Domain.Models.Enums;

namespace Doroga.Domain.Models.Entities
{
    public class UserEntity
    {
        public string Id { get; set; }

        public UserRole UserRole { get; set; }

        public string Login { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public GenderType GenderType { get; set; }

        public DateTimeOffset? Birthday { get; set; }

        public string Signature { get; set; }

        public bool IsDeleted { get; set; }

        // Need Add Address and Model of Car 
    }
}

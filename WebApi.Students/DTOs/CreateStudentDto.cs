﻿using Students.CQRS.Commands;

namespace Students.DTOs
{
    public record CreateStudentDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Gender { get; set; }
        public int Age { get; set; }

        public string Email { get; set; }

        public string Country { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
    }
}

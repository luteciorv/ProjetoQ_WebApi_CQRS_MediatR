﻿using MediatR;

namespace Students.CQRS.Commands
{
    public class CreateStudentCommand : IRequest
    {
        public CreateStudentCommand(string firstName, string lastName, int gender, int age, string email, string country, string zipCode, string city, string state, string street, string number)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Age = age;
            Email = email;
            Country = country;
            ZipCode = zipCode;
            City = city;
            State = state;
            Street = street;
            Number = number;
        }

        public Guid GeneratedId { get; set; }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Gender { get; private set; }
        public int Age { get; private set; }

        public string Email { get; private set; }

        public string Country { get; private set; }
        public string ZipCode { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string Street { get; private set; }
        public string Number { get; private set; }
    }
}

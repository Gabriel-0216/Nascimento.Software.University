using Xunit;
using System;
using Nascimento.Software.University.Domain.Entities;

namespace University.Tests
{
    public class PersonTests
    {
        [Fact]
        public void CreatePersonCorrectly()
        {
            var person = new IndividualPerson("Gabriel", "Souza", new System.DateTime(2000, 01, 14));
            Assert.True(person.IsValid);
        }
        [Fact]
        public void CreatePersonWithoutLastName()
        {
            var person = new IndividualPerson("Gabriel", null, new System.DateTime(2000, 01, 14));
            Assert.True(person.IsValid);
        }
        [Fact]
        public void CreatePersonWithoutFirstNameReturnFalse()
        {
            var person = new IndividualPerson(string.Empty, null, new System.DateTime(2000, 01, 14));
            Assert.False(person.IsValid);
        }
        [Fact]
        public void CreatePersonInvalidDateReturnFalse()
        {
            // Given
            var person = new IndividualPerson("Gabriel", "Ss", new System.DateTime(2023, 01, 14));
            // When
            Assert.False(person.IsValid);
            // Then
        }
        [Fact]
        public void ValidPersonAddValidEmail()
        {
            // Given
            var person = new IndividualPerson("Gabriel", "Nascimento", new System.DateTime(2000, 01, 14));
            // When
            person.AddEmail("emailvalido.com");
            // Then
            Assert.True(person.IsValid);
        }
        [Fact]
        public void ValidPersonInvalidEmail()
        {
            // Given
            var person = new IndividualPerson("Gabriel", "Nascimento", new System.DateTime(2000, 01, 14));

            // When
            person.AddEmail(string.Empty);
            // Then
            Assert.False(person.IsValid);
        }
        [Fact]
        public void ValidPersonValidPhone()
        {
            // Given
            var person = new IndividualPerson("Gabriel", "Nascimento", new System.DateTime(2000, 01, 14));

            // When
            person.AddPhone(71, "23233232");
            // Then
            Assert.True(person.IsValid);
        }
        [Fact]
        public void ValidPersonInvalidPhone()
        {
            var person = new IndividualPerson("Gabriel", "Nascimento", new System.DateTime(2000, 01, 14));

            // When
            person.AddPhone(71, string.Empty);
            // Then
            Assert.False(person.IsValid);

        }
    }
}
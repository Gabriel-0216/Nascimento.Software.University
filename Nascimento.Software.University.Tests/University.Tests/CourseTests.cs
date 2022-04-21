using Xunit;
using System;
using Nascimento.Software.University.Domain.Entities;
namespace University.Tests
{
    public class CourseTests
    {
        [Fact]
        public void CreateValidCourseTrue()
        {
            // Given
            var course = new Course("Curso teste", "descrição", 10.0M);
            // When
            Assert.True(course.IsValid);
            // Then
        }
        [Fact]
        public void CourseWithoutDescriptionReturnFalse()
        {
            // Given
            var course = new Course("Curso teste", "", 10.0M);

            // When
            Assert.False(course.IsValid);

            // Then
        }
    }
}
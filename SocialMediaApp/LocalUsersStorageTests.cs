using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SocialMediaApp
{
    public class LocalUsersStorageTests_AddUser
    {
        private User testUser = new User()
        {
            Email = "123",
            FirstName = "123",
            LastName = "123",
            ImagePath = "123",
            Password = "123",
            Username = "123"
        };


        [Fact]
        public void AddUser_When_User_Not_Exists()
        {
            // Arrange

            LocalUsersStorage.DeleteUser(testUser.Username);
            bool expectedResult = true;

            // Act
            bool result = LocalUsersStorage.AddUser(testUser);

            // Assert
            Assert.Equal(expectedResult, result);

            LocalUsersStorage.DeleteUser(testUser.Username);
        }
    }
}

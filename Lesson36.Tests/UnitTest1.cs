using Lesson36.Controllers;
using Lesson36.Models;
using Microsoft.EntityFrameworkCore;

namespace Lesson36.Tests
{
    public class UnitTest1
    {
        private readonly UsersController usersController;
        private readonly Context context;
        public UnitTest1() 
        {
            context = new Context( new DbContextOptions<Context>());
            usersController = new UsersController(context);
        }
        [Fact]
        public void GetUsers_ShouldReturnAllUSers()
        {
            //Arrange
            var dbUsers = context.Users.ToList();
            //Act
            var result = usersController.GetUsers();
            var users = result.Result.Value.ToList();
            //Assert
            Assert.Equal(dbUsers, users);
        }
        [Fact]
        public void GetUserById_ShouldReturnCorrectUser() 
        {
            var user = context.Users.FirstOrDefault();
            if (user == null)
            {
                Assert.Null(user);
            }
            else
            {
                var result = usersController.GetUser(user.Id);
                Assert.Equal(user, result.Result.Value);
            }
        }
    }
}
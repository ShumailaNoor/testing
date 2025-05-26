using NUnit.Framework;
using UserRegistrations;
namespace UserRegistrations
{
    public class Tests
    {
        private RegistrationService service;

        [SetUp]
        public void Setup()
        {
            service = new RegistrationService();
        }

        [Test]
        public void RegistrationWithValidUser_ReturnsTrue()
        {
            var newUser = new User { username = "Saira", password = "123456" };
            var result = service.Register(newUser);
            Assert.IsTrue(result);
        }

        [Test]
        public void Register_WithEmptyUsername_ReturnsFalse()
        {
            var user = new User { username = "", password = "pass123" };
            var result = service.Register(user);
            Assert.IsFalse(result);
        }

        [Test]
        public void Register_WithShortPassword_ReturnsFalse()
        {
            var user = new User { username = "Ali", password = "123" };
            var result = service.Register(user);
            Assert.IsFalse(result);
        }
    }
}
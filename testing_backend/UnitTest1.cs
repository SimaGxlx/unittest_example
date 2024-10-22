using System.Security.Cryptography.X509Certificates;
using unittest_example.Models;

namespace testing_backend
{
    public class UnitTest1
    {
        register test_register = new register();

        [Fact]
        public void test_login()
        {
            string result = test_register.check_user("nsovo", "nsovo@gmail.com", "glory");

            Assert.Equal("done", result);

        }
        [Fact]
        public void not_corerect_registerDetails()
        {
            string result = test_register.check_user("nsovo", "nsovo", "glory");

            Assert.Equal("no", result);
        }

    }
}
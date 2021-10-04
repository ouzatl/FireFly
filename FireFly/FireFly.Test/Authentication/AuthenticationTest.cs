using FireFly.Contract.Authentication;
using FireFly.Test.Moqs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace FireFly.Test.Authentication
{
    [TestClass]
    public class AuthenticationTest
    {
        [TestMethod]
        public async Task LOGIN_SUCCESS_CASE()
        {
            var result = await AuthenticationMoq.GetAuthenticationService()
                .Login(new AuthenticationContract { Email = AuthenticationMoq.successLoginEmail, Password = AuthenticationMoq.successLoginPassword });

            Assert.IsTrue(result);
        }

        [TestMethod]
        public async Task REGISTER_SUCCESS_CASE()
        {
            var result = await AuthenticationMoq.GetAuthenticationService()
                .Register(new AuthenticationContract { Email = AuthenticationMoq.successRegisterEmail, Password = AuthenticationMoq.successRegisterPassword });

            Assert.IsTrue(result);
        }

        [TestMethod]
        public async Task LOGIN_FAIL_CASE()
        {
            var result = await AuthenticationMoq.GetAuthenticationService()
                .Login(new AuthenticationContract { Email = AuthenticationMoq.failLoginEmail, Password = AuthenticationMoq.failLoginPassword });

            Assert.IsFalse(result);
        }

        [TestMethod]
        public async Task REGISTER_FAIL_CASE()
        {
            var result = await AuthenticationMoq.GetAuthenticationService()
                .Register(new AuthenticationContract { Email = AuthenticationMoq.failRegisterEmail, Password = AuthenticationMoq.failRegisterPassword });

            Assert.IsFalse(result);
        }

    }
}
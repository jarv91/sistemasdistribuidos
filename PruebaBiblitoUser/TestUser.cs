using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ServiceModel;

namespace PruebaBiblitoUser
{
    [TestClass]
    public class TestUser
    {
        [TestMethod]
        public void TestCreateUserfake()
        {
            UserWCF.UserClient user = new UserWCF.UserClient();

            try
            {
                UserWCF.User UserCreatefake = user.CreateUser(new UserWCF.User()
                {
                    idUser = 0,
                    username = "admin",
                    name = "admin",
                    password = "admin",
                    idUserType = 1
                });
            }
            catch (FaultException<UserWCF.BiblitoException> Error)
            {
                Assert.AreEqual(Error.Detail.Code, "101");
                Assert.AreEqual(Error.Detail.Description, "Ese username ya existe");

            }
        }
    }
}

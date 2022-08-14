using ChainOfResponsibility_Snap.Chain;
using ChainOfResponsibility_Snap.DTO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SnapTest
{
    [TestClass]
    public class ChainFixture
    {
        [TestMethod]
        public void CheckUserActiveUserTest()
        {
            CheckUserActiveUser checkUserActiveUser = new CheckUserActiveUser();
            CreateOrder createOrder = new CreateOrder();

            checkUserActiveUser.SetSuccessor(createOrder);

            string expected = 
            checkUserActiveUser.Execute(new RequestContext
            {
                UserId = 1,
                Origin = new Point { Lat = 53.3636, Lng = 54.22 },
                Destination = new Point { Lat = 53.3636, Lng = 54.22 },
            }).Message;

            string actual = "Error Order Created ";

            Assert.AreEqual(expected, actual);

        }
    }
}

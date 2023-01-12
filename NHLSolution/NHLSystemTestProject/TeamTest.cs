using NHLSystemClassLibrary;

namespace NHLSystemTestProject
{
    [TestClass]
    public class TeamTest
    {
        [TestMethod]
        [DataRow("Oilers")]
        [DataRow("Flames")]
        [DataRow("Canucks")]
        [DataRow("Maple Leafs")]
        [DataRow("Senators")]
        [DataRow("Canadiens")]
        public void Name_ValidName_NameSet(string teamName, Conference conference, Division division)
        {
            //arrange
            //act
            Team currentTeam = new Team(teamName);
            //assert
            Assert.AreEqual(teamName, currentTeam.Name);
        }


        [TestMethod]
        [DataRow(null, "Name cannot be blank.")]
        [DataRow("", "Name cannot be blank.")]
        [DataRow("      ", "Name cannot be blank.")]
        public void Name_InvalidName_ThrowsArgumentNullException(string teamName, string expectedErrorMessage)
        {
            //arrange and act
            try
            {
                Team currentTeam = new Team(teamName);
                Assert.Fail("An ArgumentNullException should have been thrown");
            }
            catch(ArgumentNullException ex)
            {
                StringAssert.Contains(ex.Message, expectedErrorMessage);
            }
        }
    }
}
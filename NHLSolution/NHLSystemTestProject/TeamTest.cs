using NhlSystemClassLibrary;

namespace NhlSystemTestProject
{
    [TestClass]
    public class TeamTest
    {
        [TestMethod]
        [DataRow("Oilers", Conference.Western, Division.Pacific)]
        [DataRow("Flames", Conference.Western, Division.Pacific)]
        [DataRow("Canucks", Conference.Western, Division.Pacific)]
        [DataRow("Maple Leafs", Conference.Eastern, Division.Atlantic)]
        [DataRow("Senators", Conference.Eastern, Division.Atlantic)]
        [DataRow("Canadiens", Conference.Eastern, Division.Atlantic)]
        [DataRow("Jets", Conference.Western, Division.Central)]
        public void Name_ValidName_NameSet(
            string teamName,
            Conference conference,
            Division division)
        {
            // Arrange
            // Act
            Team currentTeam = new Team(teamName, conference, division);
            // Assert
            Assert.AreEqual(teamName, currentTeam.Name);
            Assert.AreEqual(conference, currentTeam.Conference);    
            Assert.AreEqual(division, currentTeam.Division);
        }

        [TestMethod]
        [DataRow("", "Name cannot be blank.", Conference.Western, Division.Pacific)]
        [DataRow("     ", "Name cannot be blank.", Conference.Western, Division.Pacific)]
        public void Name_InvalidName_THrowsArgumentNullException(
            string teamName, 
            string exceptedErrorMessage,
            Conference conference,
            Division divison
            )
        {
            // Arrange and Act
            try
            {
                Team currentTeam = new Team(teamName, conference, divison);
                Assert.Fail("An ArgumentNullException should have been thrown");
            }
            catch(ArgumentNullException ex)
            {
                StringAssert.Contains(ex.Message, exceptedErrorMessage);
            }
        }
    }
}
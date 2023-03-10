using NhlSystemClassLibrary;

namespace NhlSystemTestProject
{
    [TestClass]
    public class TeamTest
    {
        [TestMethod]
        [DataRow("Oilers","Edmonton","Rogers Place", Conference.Western, Division.Pacific)]
        [DataRow("Flames","Calgary","Scotiabank Saddledome", Conference.Western, Division.Pacific)]
        [DataRow("Canucks","Vacouver","Rogers Arena", Conference.Western, Division.Pacific)]
        [DataRow("Maple Leafs","Toronto","Scotiabank Arena", Conference.Eastern, Division.Atlantic)]
        [DataRow("Senators","Ottawa","Canadian Tire Centre", Conference.Eastern, Division.Atlantic)]
        [DataRow("Canadiens", "Montreal","Centre Bell",Conference.Eastern, Division.Atlantic)]
        [DataRow("Jets", "Winnipeg","Canadian Life Centre",Conference.Western, Division.Central)]
        public void Name_ValidName_NameSet(
            string teamName,
            string city,
            string arena,
            Conference conference,
            Division division)
        {
            // Arrange
            // Act
            //Team currentTeam = new Team(teamName, city, arena, conference, division);
            // Assert
            //Assert.AreEqual(teamName, currentTeam.Name);
            //Assert.AreEqual(conference, currentTeam.Conference);    
            //Assert.AreEqual(division, currentTeam.Division);
            //Assert.AreEqual(city, currentTeam.City);
            //Assert.AreEqual(arena, currentTeam.Arena);
        }

        //[TestMethod]
        //[DataRow("", "Name cannot be blank.", Conference.Western, Division.Pacific)]
        //[DataRow("     ", "Name cannot be blank.", Conference.Western, Division.Pacific)]
        //public void Name_InvalidName_THrowsArgumentNullException(
        //    string teamName, 
        //    string exceptedErrorMessage,
        //    Conference conference,
        //    Division divison
        //    )
        //{
        //    // Arrange and Act
        //    try
        //    {
        //        Team currentTeam = new Team(teamName, conference, divison);
        //        Assert.Fail("An ArgumentNullException should have been thrown");
        //    }
        //    catch(ArgumentNullException ex)
        //    {
        //        StringAssert.Contains(ex.Message, exceptedErrorMessage);
        //    }
        //}
    }
}
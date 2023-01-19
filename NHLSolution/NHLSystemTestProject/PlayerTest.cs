using NhlSystemClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhlSystemTestProject
{
    [TestClass]
    public class PlayerTest
    {

        [TestMethod]
        [DataRow(97, "Connor McDavid", Position.C)]
        [DataRow(93, "Ryan Nugget-Hopkins", Position.CW)]
        [DataRow(91, "Evander Kane", Position.LW)]
        public void Constructor_ValidData_ShouldPass(int playerNo, string playerName, Position playerPosition)
        {
            //Arrange, act, assert
            Player currentPlayer = new Player(playerNo, playerName, playerPosition);
            Assert.AreEqual(playerNo, currentPlayer.PlayerNo);
            Assert.AreEqual(playerName, currentPlayer.Name);
            Assert.AreEqual(playerPosition, currentPlayer.Position);
        }

        [TestMethod]
        [DataRow(0, "Connor McDavid", Position.C)]
        [DataRow(99, "Connor McDavid", Position.C)]
        [DataRow(-1, "Connor McDavid", Position.C)]
        [DataRow(100, "Connor McDavid", Position.C)]
        public void PlayerNo_InvaldValue_ThrowsArfumentException(int playerNo, string playerName, Position playerPosition)
        {
            try
            {
                Player currentPlayer = new Player(playerNo, playerName, playerPosition);
                Assert.Fail("An ArgumentException should have been thrown.");
            }
            catch(ArgumentException ex)
            {
                StringAssert.Contains(ex.Message, "PlayerNo must be between 1 and 98.");
                Assert.AreEqual(ex.Message, "PlayerNo must be between 1 and 98.");
            }
            catch(Exception ex)
            {
                Assert.Fail("Incorrect exception type thrown.");
            }
        }

        [TestMethod]
        [DataRow(41, "", Position.C)]//passes
        [DataRow(14, "      ", Position.C)]//passes
        [DataRow(44, null, Position.C)]//passes
        //[DataRow(11, "Connor McDavid", Position.C)]//fails
        public void PlayerName_InvaldValue_ThrowsArfumentException(int playerNo, string playerName, Position playerPosition)
        {
            try
            {
                Player currentPlayer = new Player(playerNo, playerName, playerPosition);
                Assert.Fail("An ArgumentException should have been thrown.");
            }
            catch (ArgumentException ex)
            {
                StringAssert.Contains(ex.Message, "Name cannot be blank.");
            }
            catch (Exception ex)
            {
                Assert.Fail("Incorrect exception type thrown.");
            }
        }

        [TestMethod]
        [DataRow(1, "one", Position.C, 0, 1, 1, 1)]//pass
        [DataRow(2, "two", Position.C, 0, 2, 2, 2)]//pass
        [DataRow(3, "three", Position.C, 0, 3, 3, 3)]//pass
        [DataRow(4, "four", Position.C, 4, 4, 4, 4)]//fail
        public void GamesPlayed_InvaldValue_ThrowsArfumentException(int playerNo, string playerName, Position playerPosition, int gamesPlayed, int goals, int assists, int points)
        {
            try
            {
                Player currentPlayer = new Player(playerNo, playerName, playerPosition, gamesPlayed, goals, assists, points);
                Assert.Fail("An ArgumentException should have been thrown.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                StringAssert.Contains(ex.Message, "Goals cannot be less than 0");
            }
            catch (Exception ex)
            {
                Assert.Fail("Incorrect exception type thrown.");//THIS KEEPS HAPPENING
            }
        }

        //Goals
        //Assists
        //Points


        //Addgamesplayed
        //Addgoals
        //AddAssists
    }
}

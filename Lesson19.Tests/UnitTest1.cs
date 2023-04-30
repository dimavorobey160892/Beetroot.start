using Bogus;
using Lesson19HomeTask;
using Moq;

namespace Lesson19.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(38.8976, -77.0366, 39.9496, -75.1503, 4148.03)]
        [InlineData(50, 26, 50, 27, 6128.38)]
        [InlineData(12, 43, 22, 222, 3577.32)]
        public void GetDistance_ReturnsExpectedResult(double lat1, double lng1, double lat2, double lng2, double result)
        {
            var distance = Math.Round(Program.getDistance(lat1, lng1, lat2, lng2),2);
            Assert.Equal(result, distance);
        }

        [Theory]
        [InlineData ("hello world, how are you", "good morning world, bey bey", 1)]
        public void SameWordsCount_ReturnExpectedResult(string personAbout1, string personAbout2, int personCount) 
        {
            var result = Program.SameWordsCount(personAbout1, personAbout2);
            Assert.Equal(personCount, result);
        }
        [Fact]
        public void IsSameFriends_ReturnsExpectedResult() 
        {
            var friends1 = new Friend[2];
            var friends2 = new Friend[2];
            for (int i = 0; i < friends1.Length; i++)
            {
                var faker = new Faker();
                string name = faker.Name.FullName();
                friends1[i] = new Friend { Name = name };
                friends2[i] = new Friend { Name = name };
            }
            var result = Program.IsSameFriends(friends1, friends2);
            Assert.True(result);
        }
    }
}
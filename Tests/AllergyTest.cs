using Xunit;
using Allergy.Objects;

namespace Allergy
{
    public class AllergyTest
    {
        [Fact]
        public void WhichAllergen_ForExactScore_ReturnAllergen()
        {
            int score = 8;
            AllergyScore newScore = new AllergyScore(score);
            string result = newScore.FindAllergen();
            Assert.Equal(true, result == "strawberries");
        }
        [Fact]
        public void WhichAllergen_ForHigherScore_ReturnAllergen()
        {
            int score = 9;
            AllergyScore newScore = new AllergyScore(score);
            string result = newScore.FindAllergen();
            Assert.Equal(true, result == "strawberries");
        }
    }
}

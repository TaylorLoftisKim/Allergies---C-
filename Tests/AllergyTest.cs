using Xunit;
using Allergy.Objects;

namespace Allergy
{
    public class AllergyTest
    {
        [Fact]
        public void WhichAllergen_ForScore_ReturnAllergen()
        {
            int score = 8;
            AllergyScore newScore = new AllergyScore(score);
            string result = newScore.FindAllergen();
            Assert.Equal(true, result == "strawberries");
        }
    }
}

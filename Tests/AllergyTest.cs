using Xunit;
using Allergy.Objects;
using System;
using System.Collections.Generic;

namespace Allergy
{
    public class AllergyTest
    {
        [Fact]
        public void WhichAllergen_ForExactScore_ReturnAllergen()
        {
            int score = 8;
            AllergyScore newScore = new AllergyScore(score);
            List<string> results = newScore.FindAllergen();
            string result = results[0];
            Console.WriteLine(result);
            Assert.Equal(true, result == "strawberries");
        }
        [Fact]
        public void WhichAllergen_ForHigherScore_ReturnAllergen()
        {
            int score = 9;
            AllergyScore newScore = new AllergyScore(score);
            List<string> results = newScore.FindAllergen();
            string result = results[0];
            Assert.Equal(true, result == "strawberries");
        }
        [Fact]
        public void WhichAllergen_ForHigherScore_ReturnAllergenWithRemainder()
        {
            int score = 9;
            AllergyScore newScore = new AllergyScore(score);
            List<string> results = newScore.FindAllergen();
            string result = results[0];
            if(newScore.GetScore() > 0)
            {
                result = result + ", " + newScore.GetScore().ToString();
            }
            // remainder of 1 removed upon completion of following spec(multiple allergens)
            Assert.Equal(false, result == "strawberries, 1");
        }
        [Fact]
        public void WhichAllergen_ForLargeScore_ReturnAllAllergens()
        {
            int score = 9;
            AllergyScore newScore = new AllergyScore(score);
            List<string> results = newScore.FindAllergen();
            string result = results[0];
            if(results.Count > 1)
            {
                for(var idx = 1; idx < results.Count ;idx++)
                {
                    result = result + ", " + results[idx];
                }
            }
            Console.WriteLine("result string: " + result);
            Assert.Equal(true, result == "strawberries, eggs");
        }
    }
}

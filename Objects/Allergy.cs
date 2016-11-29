using System;
using System.Collections.Generic;

namespace Allergy.Objects
{
    public class AllergyScore
    {
        private int _score;
        private Dictionary<int, string> allergens = new Dictionary<int, string>
        {
            { 1, "eggs" },
            { 2, "peanuts" },
            { 4, "shellfish" },
            { 8, "strawberries" },
            { 16, "tomatoes" },
            { 32, "chocolate" },
            { 64, "pollen" },
            { 128, "cats" }
        };
        public AllergyScore(int score)
        {
            _score = score;
        }

        public string FindAllergen()
        {
            Console.WriteLine(_score.ToString());
            Console.WriteLine(allergens[_score]);
            return allergens[_score];
        }
    }
}

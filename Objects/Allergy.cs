using System;
using System.Collections.Generic;

namespace Allergy.Objects
{
    public class AllergyScore
    {
        private int _score;
        private int[] _scores = new int[] { 128, 64, 32, 16, 8, 4, 2, 1 };
        private string[] _allergens = new string[] { "cats", "pollen", "chocolate", "tomatoes", "strawberries", "shellfish", "peanuts", "eggs" };

        public AllergyScore(int score)
        {
            _score = score;
        }

        public string FindAllergen()
        {
            int index = Array.IndexOf(_scores, _score);
            return _allergens[index];
        }
    }
}

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

        public int GetScore()
        {
            return _score;
        }

        public string FindAllergen()
        {
            int whichNumber = 0;
            foreach(int number in _scores)
            {
                if(_score >= number)
                {
                    whichNumber = number;
                    Console.WriteLine("number: " + whichNumber);
                    break;
                }
            }
            int index = Array.IndexOf(_scores, whichNumber);
            Console.WriteLine("allergen: " + _allergens[index]);
            string whichAllergen = _allergens[index];
            _score -= whichNumber;
            return whichAllergen;
        }
    }
}

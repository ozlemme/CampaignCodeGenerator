using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampaignCodeGenerator
{
    public class Generate
    {
        public static HashSet<string> GenerateCodes(int number)
        {
            var hashSet = new HashSet<string>();

            do
            {
                hashSet.Add($"{GenerateCharacterForRule1()}" +
                    $"{GenerateCharacterForRule1()}" +
                    $"{GenerateCharacterForRule2()}" +
                    $"{GenerateCharacterForRule2()}" +
                    $"{GenerateCharacterForRule3()}" +
                    $"{GenerateCharacterForRule3()}" +
                    $"{GenerateCharacterForRule4()}" +
                    $"{GenerateCharacterForRule4()}");

            } while (hashSet.Count < number);

            return hashSet;
        }

        private static string GenerateCharacterForRule1()
        {
            var rd = new Random();
            return Constants.CharacterList[rd.Next(0, 11)];
        }

        private static string GenerateCharacterForRule2()
        {
            var rd = new Random();
            return Constants.CharacterList[rd.Next(12, Constants.CharacterList.Count - 1)];
        }

        private static string GenerateCharacterForRule3()
        {
            var rd = new Random();
            int randNumber = rd.Next(0, 22);

            if (randNumber % 2 == 0)
                return Constants.CharacterList[randNumber];
            else
                return Constants.CharacterList[randNumber + 1];
        }

        private static string GenerateCharacterForRule4()
        {
            var rd = new Random();
            var randNumber = rd.Next(0, 22);

            if (randNumber % 2 == 1)
                return Constants.CharacterList[randNumber];
            else if (randNumber + 1 > Constants.CharacterList.Count)
                return Constants.CharacterList[randNumber - 1];
            else
                return Constants.CharacterList[randNumber + 1];
        }
    }
}

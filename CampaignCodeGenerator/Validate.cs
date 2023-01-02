using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampaignCodeGenerator
{
    public class Validate
    {
        public static bool ValidateCode(string code)
        {
            if (code.Length != 8)
                return false;

            for (int i = 0; i < code.Length; i++)
            {
                bool valid;

                if (i == 0 || i == 1)
                    valid = ValidationForRule1(code[i].ToString());
                else if (i == 2 || i == 3)
                    valid = ValidationForRule2(code[i].ToString());
                else if (i == 4 || i == 5)
                    valid = ValidationForRule3(code[i].ToString());
                else
                    valid = ValidationForRule4(code[i].ToString());

                if (!valid)
                    return valid;
            }

            return true;
        }

        private static bool ValidationForRule1(string character)
        {
            return (0 <= Constants.CharacterList.IndexOf(character) &&
                Constants.CharacterList.IndexOf(character) <= 11);
        }

        private static bool ValidationForRule2(string character)
        {
            return (12 <= Constants.CharacterList.IndexOf(character) &&
                Constants.CharacterList.IndexOf(character) <= Constants.CharacterList.Count - 1);
        }

        private static bool ValidationForRule3(string character)
        {
            return (Constants.CharacterList.IndexOf(character) % 2 == 0);
        }

        private static bool ValidationForRule4(string character)
        {
            return (Constants.CharacterList.IndexOf(character) % 2 == 1);
        }
    }
}

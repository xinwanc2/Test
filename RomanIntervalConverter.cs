namespace Test
{
    public class RomanIntervalConverter
    {
        private static Dictionary<string, int> RomanNumerals = new()
        {
            {
                "I",
                1
            },
            {
                "IV",
                4
            },
            {
                "V",
                5
            },
            {
                "IX",
                9
            },
            {
                "X",
                10
            },
            {
                "XL",
                40
            },
            {
                "L",
                50
            },
            {
                "XC",
                90
            },
            {
                "C",
                100
            },
            {
                "CD",
                400
            },
            {
                "D",
                500
            },
            {
                "CM",
                900
            },
            {
                "M",
                1000
            }
        };

        public static int RomanToNum(string value)
        {
            int total = 0;

            for (int i = 0; i < value.Length; i++)
            {
                string currentRomanChar = value[i] + "";
                RomanNumerals.TryGetValue(currentRomanChar, out int num);
                if (i + 1 < value.Length && RomanNumerals[value[i + 1] + ""] > RomanNumerals[currentRomanChar])
                {
                    total -= num;
                }
                else
                {
                    total += num;
                }
            }
            return total;
        }

        public static string NumToRoman(int value)
        {
            string result = "";

            foreach (var item in RomanNumerals.Reverse())
            {
                if (value <= 0)
                {
                    break;
                };

                while (value >= item.Value)
                {
                    result += item.Key;
                    value -= item.Value;
                }
            }
            return result;
        }
    }
}
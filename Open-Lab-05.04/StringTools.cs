using System;

namespace Open_Lab_05._04
{
    public class StringTools
    {
        public string RemoveSpecialCharacters(string original)
        {
            char[] allowed = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '_', '-', ' ' };
            string ret = "";
            for (int i = 0; i < original.Length; i++)
            {
                for (int k = 0; k < allowed.Length; k++)
                {
                    if (original[i] == allowed[k])
                    {
                        ret = ret + original[i];
                    }
                }
            }
            return ret;
        }
    }
}

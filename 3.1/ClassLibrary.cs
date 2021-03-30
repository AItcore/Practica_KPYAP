using System;

namespace _3._1
{
    class ClassLibrary
    {
        public static bool Palindrom(string line)
        {
            for (int i = 0; i < line.Length / 2; i++)
            {
                if (line[i] != line[line.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
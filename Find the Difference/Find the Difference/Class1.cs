// Written by Holbrait
// 04/09/25

public class LetterFinder
{
    public char FindAddedLetter(string s, string t)
    {
        int sumS = 0;
        int sumT = 0;

        for (int i = 0; i < s.Length; i++)
        {
            sumS += s[i];
        }

        for (int i = 0; i < t.Length; i++)
        {
            sumT += t[i];
        }

        int difference = sumT - sumS;
        return (char)difference;
    }
}

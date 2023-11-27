using System;
using System.Collections.Generic;

/// <summary>
/// Class to find anagrams of a base word.
/// </summary>
public class Anagram
{
    private readonly string _baseWord;
    private const int NUMBER_OF_ENGLISH_LETTERS = 26;
    public Anagram(string baseWord)
    {
        this._baseWord = baseWord.ToLower();
    }

    /// <summary>
    /// Finds anagrams of the base word in a list of potential matches.
    /// </summary>
    /// <param name="potentialMatches">The potential matches to check for anagrams.</param>
    /// <returns>An array of strings that are anagrams of the base word.</returns>
    public string[] FindAnagrams(string[] potentialMatches)
    {
        List<string> potentialAnagrams = new List<string>();
        foreach (var potentialWord in potentialMatches)
        {
            string potentialWordLowerCase = potentialWord.ToLower();
            if(CheckEquivalent(potentialWordLowerCase))
                continue;
            
            if(CheckAnagram(potentialWordLowerCase))
                potentialAnagrams.Add(potentialWord);
        }

        return potentialAnagrams.ToArray();
    }

    /// <summary>
    /// Checks if a potential word is equivalent to the base word.
    /// </summary>
    /// <param name="potentialWord">The potential word to check for equivalence.</param>
    /// <returns>True if the potential word is equivalent to the base word, false otherwise.</returns>
    private bool CheckEquivalent(string potentialWord)
    {
        if (this._baseWord.Equals(potentialWord))
            return true;
        return false;
    }

    /// <summary>
    /// Checks if a potential word is an anagram of the base word.
    /// </summary>
    /// <param name="potentialWord">The potential word to check for anagram.</param>
    /// <returns>True if the potential word is an anagram of the base word, false otherwise.</returns>
    private bool CheckAnagram(string potentialWord)
    {
        int[] baseWordLetterFreq = new int[NUMBER_OF_ENGLISH_LETTERS];
        int[] potentialWordLetterFreq = new int[NUMBER_OF_ENGLISH_LETTERS];

        if (this._baseWord.Length != potentialWord.Length)
            return false;
        
        for (int i = 0; i < this._baseWord.Length; ++i)
        {
            baseWordLetterFreq[(int) this._baseWord[i] - 'a']++;
            potentialWordLetterFreq[(int) potentialWord[i] - 'a']++;
        }

        for (int i = 0; i < NUMBER_OF_ENGLISH_LETTERS; ++i)
        {
            if(baseWordLetterFreq[i] != potentialWordLetterFreq[i])
                return false;
        }

        return true;
    }
}

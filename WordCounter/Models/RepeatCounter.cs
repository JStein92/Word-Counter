using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
    public class RepeatCounter
    {
        private string _userSentence;
        private string _userWord;
        private int _wordCount;
        private int _wordCountAll;

        private List<string> _specialCharacters = new List<string>{".", ",","!","?","/", "$", "@", "#", "%", "&", "*", "(", ")", "=", "+", "<", ">","\\"};

        public RepeatCounter(string userSentence, string userWord)
        {
            _userSentence = userSentence;
            _userWord = userWord;
        }

        public int GetWordCountAll()
        {
            return _wordCountAll; 
        }

        public string GetUserWord()
        {
            return _userWord;
        }
        public string GetUserSentence()
        {
            return _userSentence;
        }

        public bool IsWordContained()
        {
            if (_userSentence.ToUpper().Contains(_userWord.ToUpper()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int CountRepeats()
        {  
            
            string[] wordArray = _userSentence.Split(' ');

                foreach (string word in wordArray)
                {
                    _wordCountAll++; //for test method 2

                    string wordNoSpecialChars = word;

                    foreach (char character in word) // for every character in each word
                    {
                        foreach (string specialCharacter in _specialCharacters) //loop through each special character in list
                        {
                            if (character.ToString() == specialCharacter) //if any character in the word matches any special character
                            {
                                wordNoSpecialChars = word.Replace(specialCharacter, ""); //replace it with a blank and assign to temp string wordNoSpecialChars
                            }
                        }                      
                    }
        
                    if (wordNoSpecialChars.ToUpper() == _userWord.ToUpper())
                    {
                    
                        _wordCount++;
                    }
                }
            
            return _wordCount;
        }
    }
}
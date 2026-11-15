using System;
using System.Collections.Generic;
using System.Text;

namespace lab_3_4
{
    public class Word
    {
        private string _polishWord = string.Empty;
        private string _englishWord = string.Empty;
        public string PolishWord
        {
            get => _polishWord;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Polskie słowo nie może być puste.");
                _polishWord = value.Trim();
            }
        }
        public string EnglishWord
        {
            get => _englishWord;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Angielskie słowo nie może być puste.");
                _englishWord = value.Trim();
            }
        }
      
        public string Category { get; set; } = "brak";

        public DateTime DateAdded { get; private set; }

     
        public string DisplayText => $"{PolishWord} – {EnglishWord}";
        public Word(string polish, string english, string category) 
            {
    PolishWord = polish;
        EnglishWord = english;
           Category = string.IsNullOrWhiteSpace(category) ? "brak" : category.Trim();
            DateAdded = DateTime.Now;

            }
        public Word(string polish, string english) =>
    (PolishWord, EnglishWord, DateAdded) = (polish, english, DateTime.Now);
        public override string ToString() => $"Polish: {PolishWord}, English: {EnglishWord}, Category: {Category}, Date Added: {DateAdded}";
    }


}






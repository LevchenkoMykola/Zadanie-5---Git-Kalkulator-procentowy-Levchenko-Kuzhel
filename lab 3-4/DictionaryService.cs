using System;
using System.Collections.Generic;
using System.Text;

namespace lab_3_4
{
    public class DictionaryService
    {
       private readonly List<Word> _words = new List<Word>();
       
       private readonly Queue<string> _history = new Queue<string>();
        
        private  const int MaxHistory = 10;
       
        public DictionaryService()
        {
            _words.Add(new Word("kot", "cat", "zwierzęta"));
            _words.Add(new Word("pies", "dog"));
            _words.Add(new Word("samochód", "car", "pojazdy"));
            _words.Add(new Word("rower", "bicycle", "pojazdy"));
            _words.Add(new Word("dom", "house", "budynki"));
        }
        public IReadOnlyList<Word> Words => _words;
        public IEnumerable<string> History => _history.Reverse();
        private static bool Same(string a, string b) => string.Equals(a?.Trim(), b?.Trim(), StringComparison.OrdinalIgnoreCase);
        private void AddToHistory(string text )
        {
            _history.Enqueue(text);
            while(_history.Count > MaxHistory)
            {
                _history.Dequeue();
            }
        }
        public Word? Find(string Text)
        {
            if(string.IsNullOrWhiteSpace(Text))
                return null;
            AddToHistory(Text.Trim());
            return
            _words.FirstOrDefault(w =>Same(w.PolishWord, Text) || Same(w.EnglishWord, Text));
        }
        public void AddWord(string polish, string english, string category)
        {
            if (string.IsNullOrWhiteSpace(polish) || string.IsNullOrWhiteSpace(english))
                throw new ArgumentException("Polskie i angielskie słowo nie może być puste.");
            if (_words.Any(w => Same(w.PolishWord, polish) || Same(w.EnglishWord, english)))
                throw new InvalidOperationException("Słowo już istnieje w słowniku.");
            _words.Add(new Word(polish, english, category));
        }
        public void UpdateWord (Word word, string newPolish, string newEnglish, string newCategory)
        {
            if (word == null)
                throw new ArgumentNullException(nameof(word));
            if (string.IsNullOrWhiteSpace(newPolish) || string.IsNullOrWhiteSpace(newEnglish))
                throw new ArgumentException("Polskie i angielskie słowo nie może być puste.");
            if (_words.Any(w => w != word && (Same(w.PolishWord, newPolish) || Same(w.EnglishWord, newEnglish))))
                throw new InvalidOperationException("Słowo już istnieje w słowniku.");
            word.PolishWord = newPolish;
            word.EnglishWord = newEnglish;
            word.Category = string.IsNullOrWhiteSpace(newCategory) ? "brak" : newCategory.Trim();
        }
        public void RemoveWord(Word word) => _words.Remove(word);
        public void GetRandomWord(out Word? word)
        {
            if (_words.Count == 0)
            {
                word = null;
                return;
            }
            var random = new Random();
            int index = random.Next(_words.Count);
            word = _words[index];
        }
        public List<Word> GetRandomWords(int count) =>
    _words.OrderBy(_ => Random.Shared.Next()).Take(count).ToList();

        public static bool CheckAnswer(Word word, string answer) =>
            Same(word.EnglishWord, answer);
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace lab_3_4
{
    public partial class Form1 : Form
    {
        private readonly DictionaryService _service = new DictionaryService();

        // Wyszukiwanie
        private TextBox txtSearch = new TextBox();
        private Label lblResult = new Label();
        private ListBox lstHistory = new ListBox();

        // Słownik
        private ListBox lstWords = new ListBox();
        private TextBox txtPolish = new TextBox();
        private TextBox txtEnglish = new TextBox();
        private TextBox txtCategory = new TextBox();

        // Test
        private NumericUpDown numCount = new NumericUpDown();
        private Label lblQuestion = new Label();
        private TextBox txtAnswer = new TextBox();
        private Label lblScore = new Label();

        private List<Word> _testWords = new List<Word>();
        private int _current;
        private int _correct;

        public Form1()
        {
            InitializeComponent();
            Text = "Słownik polsko-angielski";
            ClientSize = new Size(900, 400);

            // ---- Kolumna 1: wyszukiwanie ----
            Put(new Label(), 10, 10, 250, "Szukaj (PL lub EN):");
            Put(txtSearch, 10, 35, 170);
            Put(new Button(), 190, 33, 80, "Szukaj").Click += Search_Click;
            Put(lblResult, 10, 70, 270);
            Put(new Label(), 10, 110, 250, "Historia:");
            Put(lstHistory, 10, 135, 260);
            lstHistory.Height = 250;

            // ---- Kolumna 2: słownik ----
            Put(new Label(), 300, 10, 250, "Słownik:");
            Put(lstWords, 300, 35, 300);
            lstWords.Height = 200;
            lstWords.SelectedIndexChanged += Words_SelectedIndexChanged;
            Put(new Label(), 300, 245, 90, "Polskie:");
            Put(txtPolish, 390, 242, 210);
            Put(new Label(), 300, 275, 90, "Angielskie:");
            Put(txtEnglish, 390, 272, 210);
            Put(new Label(), 300, 305, 90, "Kategoria:");
            Put(txtCategory, 390, 302, 210);
            Put(new Button(), 300, 340, 70, "Dodaj").Click += Add_Click;
            Put(new Button(), 377, 340, 70, "Zmień").Click += Update_Click;
            Put(new Button(), 454, 340, 70, "Usuń").Click += Delete_Click;
            Put(new Button(), 531, 340, 70, "Wyczyść").Click += Clear_Click;

            // ---- Kolumna 3: test ----
            Put(new Label(), 630, 10, 250, "Test – liczba słów:");
            Put(numCount, 630, 35, 60);
            numCount.Minimum = 1;
            numCount.Value = 3;
            Put(new Button(), 700, 33, 100, "Start").Click += StartTest_Click;
            Put(lblQuestion, 630, 75, 260);
            Put(txtAnswer, 630, 100, 170);
            Put(new Button(), 810, 98, 80, "Sprawdź").Click += Check_Click;
            Put(lblScore, 630, 140, 260);
            lblScore.Height = 40;

            RefreshWords();
        }

        // Ставить елемент на форму у вказане місце
        private Control Put(Control c, int x, int y, int width, string text = "")
        {
            c.Location = new Point(x, y);
            c.Width = width;
            if (text != "") c.Text = text;
            Controls.Add(c);
            return c;
        }

        private static void ShowError(string message) => MessageBox.Show(message, "Błąd");

        private void RefreshWords()
        {
            lstWords.DataSource = null;
            lstWords.DataSource = _service.Words.ToList();
            lstWords.ClearSelected();
            ClearFields();
        }

        private void RefreshHistory()
        {
            lstHistory.DataSource = null;
            lstHistory.DataSource = _service.History.ToList();
        }

        private void ClearFields()
        {
            txtPolish.Clear();
            txtEnglish.Clear();
            txtCategory.Clear();
        }

        // ===== WYSZUKIWANIE =====
        private void Search_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                ShowError("Wpisz słowo.");
                return;
            }
            Word? w = _service.Find(txtSearch.Text);
            lblResult.Text = w != null ? w.DisplayText : "Nie ma takiego słowa w słowniku.";
            RefreshHistory();
        }

        // ===== SŁOWNIK =====
        private void Words_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (lstWords.SelectedItem is Word w)
            {
                txtPolish.Text = w.PolishWord;
                txtEnglish.Text = w.EnglishWord;
                txtCategory.Text = w.Category;
            }
        }

        private void Add_Click(object? sender, EventArgs e)
        {
            try
            {
                _service.AddWord(txtPolish.Text, txtEnglish.Text, txtCategory.Text);
                RefreshWords();
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void Update_Click(object? sender, EventArgs e)
        {
            if (lstWords.SelectedItem is not Word w)
            {
                ShowError("Wybierz słowo z listy.");
                return;
            }
            try
            {
                _service.UpdateWord(w, txtPolish.Text, txtEnglish.Text, txtCategory.Text);
                RefreshWords();
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void Delete_Click(object? sender, EventArgs e)
        {
            if (lstWords.SelectedItem is not Word w)
            {
                ShowError("Wybierz słowo z listy.");
                return;
            }
            _service.RemoveWord(w);
            RefreshWords();
        }

        private void Clear_Click(object? sender, EventArgs e)
        {
            lstWords.ClearSelected();
            ClearFields();
            txtSearch.Clear();
            lblResult.Text = "";
        }

        // ===== TEST =====
        private void StartTest_Click(object? sender, EventArgs e)
        {
            _testWords = _service.GetRandomWords((int)numCount.Value);
            if (_testWords.Count == 0)
            {
                ShowError("Słownik jest pusty.");
                return;
            }
            _current = 0;
            _correct = 0;
            lblScore.Text = "";
            ShowQuestion();
        }

        private void ShowQuestion()
        {
            lblQuestion.Text = $"{_current + 1}/{_testWords.Count}: {_testWords[_current].PolishWord} = ?";
            txtAnswer.Clear();
        }

        private void Check_Click(object? sender, EventArgs e)
        {
            if (_current >= _testWords.Count)
            {
                ShowError("Najpierw kliknij Start.");
                return;
            }

            Word w = _testWords[_current];
            bool ok = DictionaryService.CheckAnswer(w, txtAnswer.Text);
            if (ok) _correct++;
            lblScore.Text = ok ? "Dobrze!" : $"Źle, poprawnie: {w.EnglishWord}";

            _current++;
            if (_current < _testWords.Count)
            {
                ShowQuestion();
            }
            else
            {
                lblQuestion.Text = "Koniec testu!";
                lblScore.Text += $"\nWynik: {_correct}/{_testWords.Count}";
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using SQLite;

namespace Hangman
{
    public class WordsModel : INotifyPropertyChanged
    {
        public WordsModel()
        {

        }

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Word { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}

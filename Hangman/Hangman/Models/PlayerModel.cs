using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Hangman
{
    public class PlayerModel : INotifyPropertyChanged
    {
        public PlayerModel()
        {

        }

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string NameOfPlayer { get; set; }
        public string AvatarOfPlayer { get; set; }
        public int Gems { get; set; }
        public int BestScore { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.CascadeRead)]
        public HangmanModel hangmanModel { get; set; }

        [ForeignKey(typeof(HangmanModel))]
        public int HangmanModelID { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}

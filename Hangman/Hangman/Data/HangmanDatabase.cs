using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Threading.Tasks;

namespace Hangman.Data
{
    public class HangmanDatabase
    {
        readonly SQLiteAsyncConnection _database;

        public HangmanDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<HangmanModel>().Wait();
            _database.CreateTableAsync<WordsModel>().Wait();
        }

        public Task<List<HangmanModel>> GetHangmansAsync()
        {
            return _database.Table<HangmanModel>().ToListAsync();
        }

        public Task<HangmanModel> GetHangmanAsync(int id)
        {
            return _database.Table<HangmanModel>()
                            .Where(i => i.Id == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveHangmanAsync(HangmanModel hangman)
        {
            if (hangman.Id != 0)
            {
                return _database.UpdateAsync(hangman);
            }
            else
            {
                return _database.InsertAsync(hangman);
            }
        }

        public Task<int> DeleteHangmanAsync(HangmanModel hangman)
        {
            return _database.DeleteAsync(hangman);
        }

        public Task<List<WordsModel>> GetWordsAsync()
        {
            return _database.Table<WordsModel>().ToListAsync();
        }

        public Task<WordsModel> GetWordAsync(int id)
        {
            return _database.Table<WordsModel>()
                            .Where(i => i.Id == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveWordAsync(WordsModel word)
        {
            if (word.Id != 0)
            {
                return _database.UpdateAsync(word);
            }
            else
            {
                return _database.InsertAsync(word);
            }
        }

        public Task<int> DeleteWordAsync(WordsModel word)
        {
            return _database.DeleteAsync(word);
        }

    }
}

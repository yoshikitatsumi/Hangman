using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Hangman
{
    //MW's Space
    class Logic
    {
        
        /*public string SpaceString(string MyString)
        {
            string spacedString = "";

            for (int i = 0; i < VisWord.Length; i++)
            {
                spacedString += " " + MyString.Substring(i, 1) + " ";
            }

            return spacedString;
        }*/

        /*
        public void GuessChar(object sender, EventArgs e)
        {
            if (sender is Button btn && (badGuess + 1) != deadNum)
            {
                btn.IsEnabled = false;

                //The Char Exists in HidWord
                if (HidWord.Contains(btn.Text) == true)
                {
                    //Background is greenish for correct input
                    btn.BackgroundColor = Color.FromRgb(223, 236, 223);

                    string NewVisWord = "";

                    //Safety Measure for For Loop
                    if (HidWord.Length == VisWord.Length)
                    {
                        for (int i = 0; i < HidWord.Length; i++)
                        {
                            if (HidWord.Substring(i, 1) == btn.Text)
                            {
                                NewVisWord += btn.Text;
                            }
                            else
                            {
                                NewVisWord += VisWord.Substring(i, 1);
                            }
                        }
                    }
                    else
                    {
                        Debug.WriteLine("Error: Hidden Word and Visable Word Lengths Are Different");
                    }

                    VisWord = NewVisWord;
                    label.Text = SpaceString(VisWord);

                    //If all Letters are Found
                    if (VisWord.Contains("_") != false)
                    {

                    }

                } //The Char Exists in HidWordENDS
                else
                {
                    badGuess++;
                    if ((badGuess + 1) == deadNum)
                    {
                        HMimage.Source = "HMDead.png";
                        label.Text = SpaceString(HidWord);
                    }
                    else
                    {
                        HMimage.Source = HMpics + (badGuess + 1) + ".png";
                    }

                    //Background is redish for incorrect input
                    btn.BackgroundColor = Color.FromRgb(236, 223, 223);
                }
            }
        }
        */
    }
}

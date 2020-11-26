using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Security.Cryptography.X509Certificates;

namespace Hangman
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HangManPage : ContentPage
    {
        // Setting public int and string.
        public int score = 0;
        public int attempt = 0;
        public int HMpicture = 1;
        public string word = "_";
        Label letterLabel = new Label();

        public HangManPage()
        {
            InitializeComponent();

            // Setting score as GScore, attempt as GAttempt, Hangman picture as HMImage, word as letterLabel, then keyborad and HMGem at bottom right.

            Grid myGrid = new Grid();

            // Color line.
            BoxView scoreBox = new BoxView
            {
                Color = Color.Purple
            };
            Grid.SetRow(scoreBox, 0);
            Grid.SetColumnSpan(scoreBox, 7);

            // Score Label as GScore
            Label GScore = new Label
            {
                Text = "Score: " + Convert.ToString(score),
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.Center,
                TextColor = Color.Cyan,
                FontSize = 30
            };
            Grid.SetRow(GScore, 0);
            Grid.SetColumnSpan(GScore, 7);

            // Attempt Label as GAttempt
            Label GAttempt = new Label
            {
                Text = "Attempt: " + Convert.ToString(attempt),
                HorizontalOptions = LayoutOptions.End,
                VerticalOptions = LayoutOptions.Center,
                TextColor = Color.Cyan,
                FontSize = 20
            };
            Grid.SetRow(GAttempt, 0);
            Grid.SetColumnSpan(GAttempt, 7);

            // Color line
            BoxView imageBox = new BoxView
            {
                Color = Color.Black
            };
            Grid.SetRow(imageBox, 1);
            Grid.SetRowSpan(imageBox, 3);
            Grid.SetColumnSpan(imageBox, 7);

            // Hangman image as HMimage
            Image HMimage = new Image
            {
                Source = "/Resouces/drawable/HMH" + Convert.ToString(HMpicture) + ".png",
            };
            Grid.SetRow(HMimage, 1);
            Grid.SetRowSpan(HMimage, 3);
            Grid.SetColumnSpan(HMimage, 7);

            // Color line
            BoxView letterBox = new BoxView
            {
                Color = Color.Purple
            };
            Grid.SetRow(letterBox, 4);
            Grid.SetColumnSpan(letterBox, 7);

            // Word Label as letterLabel with word as text
            Label letterLabel = new Label
            {
                Text = word,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                TextColor = Color.Cyan,
                FontSize = 30
            };
            Grid.SetRow(letterLabel, 4);
            Grid.SetColumnSpan(letterLabel, 7);

            // Keyboard setting.
            int letter = 65;
            //Value = A
            int letterZ = 90;
            char MyChar;
            Button Mybtn = new Button();
            //Rows
            for (int r = 5; letter <= letterZ; r++)
            {
                //Columns
                for (int c = 0; c < 7 && letter <= letterZ; c++)
                {
                    MyChar = Convert.ToChar(letter);
                    //myGrid.Children.Add(new BoxView
                    //{
                    //    Margin = 0,
                    //    HeightRequest = 40
                    //}, c, r);
                    myGrid.Children.Add(new Button
                    {
                        Text = Convert.ToString(MyChar),
                        FontSize = 20,
                    }, c, r);
                    letter++;
                }
            }
        
            Mybtn.Clicked += OnButtonClicked;

            // Gem Button as HMGem
            Button HMGem = new Button
            {
                ImageSource = "/Resouces/drawable/HMGem.jpg",
                HorizontalOptions = LayoutOptions.End,
                VerticalOptions = LayoutOptions.Center,
                
            };
            Grid.SetRow(HMGem, 8);
            Grid.SetColumnSpan(HMGem, 7);
            HMGem.Clicked += HMGem_Clicked;

            myGrid.Children.Add(scoreBox);
            myGrid.Children.Add(GAttempt);
            myGrid.Children.Add(GScore);
            myGrid.Children.Add(imageBox);
            myGrid.Children.Add(HMimage);
            myGrid.Children.Add(letterBox);
            myGrid.Children.Add(letterLabel);
            myGrid.Children.Add(HMGem);

            Content = myGrid;

        }

        private void HMGem_Clicked(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        public string Temp;
        public void OnButtonClicked(object sender, EventArgs args)
        {
            Temp = ((Button)sender).Text;
            letterLabel.Text = Temp;
        }

    }
}
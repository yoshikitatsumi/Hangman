using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hangman
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LevelPage : ContentPage
    {
        public LevelPage()
        {
            InitializeComponent();

            // Color line.
            BoxView BoxLine = new BoxView
            {

                Color = Color.Chocolate

            };

            // Message
            Label Level = new Label
            {
                Text = "Here are levels to choose!",
                TextColor = Color.Blue,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                FontSize = 25
            };

            // Color line.
            BoxView BoxLine2 = new BoxView
            {
               
                Color = Color.Chocolate
                
            };

            // Easy button as btnEasy
            Button btnEasy = new Button
            {
                Text = "Easy",
                FontSize = 25,
                TextColor = Color.Green
            };
            btnEasy.Clicked += btnEasy_Clicked;

            // Medium button as btnMed
            Button btnMed = new Button
            {
                Text = "Medium",
                FontSize = 25,
                TextColor = Color.Yellow
            };
            btnMed.Clicked += btnMed_Clicked;

            // Hard button as btnHard
            Button btnHard = new Button
            {
                Text = "Hard",
                FontSize = 25,
                TextColor = Color.Red
            };
            btnHard.Clicked += btnHard_Clicked;

            Content = new StackLayout
            {
                Children =
                {
                    BoxLine,
                    Level,
                    BoxLine2,
                    new StackLayout
                    {
                        HorizontalOptions = LayoutOptions.Center,
                        Children =
                        {
                            btnEasy,
                            btnMed,
                            btnHard,
                        }
                    }
                }
            };
        }

        // Button navigations
        private void btnHard_Clicked(object sender, EventArgs e)
        {
            string level = "Hard";
            BindingContext = level;
            Navigation.PushAsync(new HangManPage());
        }

        private void btnMed_Clicked(object sender, EventArgs e)
        {
            string level = "Medium";
            BindingContext = level;
            Navigation.PushAsync(new HangManPage());
        }

        private void btnEasy_Clicked(object sender, EventArgs e)
        {
            string level = "Easy";
            BindingContext = level;
            Navigation.PushAsync(new HangManPage());
        }
    }
}
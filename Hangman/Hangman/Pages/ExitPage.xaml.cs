using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Diagnostics;

namespace Hangman
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExitPage : ContentPage
    {
        public ExitPage()
        {
            InitializeComponent();

            Process myProcessInstance = Process.GetCurrentProcess();
            myProcessInstance.Kill();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamKey.Keypad
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Keypad : ContentView
    {
        public string ValueText;
        public Keypad()
        {
            InitializeComponent();
        }

        private void OnNumberSelect(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            ValueText = ValueText + button.Text;
            InputText.Text = ValueText;
        }

        private void OnBackSelect(object sender, EventArgs e)
        {
            if (ValueText == "")
            {
                return;
            }

            string newText = ValueText.Remove(ValueText.Length - 1, 1);
            ValueText = newText;
            InputText.Text = ValueText;
        }

        private async void OnEnterSelect(object sender, EventArgs e)
        {
            await App.Current.MainPage.DisplayAlert("Valor", ValueText, "OK");
            ValueText = "";
            InputText.Text = ValueText;
        }

        static class Constants
        {
            public static readonly Style KeypadStyles = new Style(typeof(Button));
        }
    }
}
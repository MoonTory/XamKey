using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamKey.Keypad;

namespace XamKey
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public string ValueText = "0";
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
            InputText.Text = ValueText;
            XamKeypad.PropertyChanged += (sender, e) =>
            {
                var view = (Keypad.Keypad)sender;
                ValueText = view.ValueText;
                InputText.Text = ValueText;
            };
        }
    }
}
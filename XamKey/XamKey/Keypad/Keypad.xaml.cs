using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamKey.Keypad
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Keypad : ContentView
    {
        public Keypad()
        {
            InitializeComponent();
        }

        static class Constants
        {
            public static readonly Style KeypadStyles = new Style(typeof(Button));
        }
    }
}
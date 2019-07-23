
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
        public string ValueText { get; set; }

        public View CustomInput
        {
            get { return (View)GetValue(LabelValueProperty); }

            set { SetValue(LabelValueProperty, value); }
        }
        public Keypad()
        {
            InitializeComponent();
        }

        public static BindableProperty ValueTextProperty = BindableProperty
            .Create(propertyName: "ValueText", returnType: typeof(string), declaringType: typeof(Keypad), defaultValue: "", defaultBindingMode: BindingMode.TwoWay, propertyChanged: HandleValueTextChanged);

        public static BindableProperty LabelValueProperty = BindableProperty
            .Create<Keypad, View>(myView => myView.CustomInput, null, defaultBindingMode: BindingMode.TwoWay, propertyChanged: HandleCustomInputChanged);

        private static void HandleCustomInputChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var myView = (Keypad)bindable;
            myView.Container.Content = (View)newValue;
        }

        private static void HandleValueTextChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var myView = (Keypad)bindable;
            myView.ValueText = newValue.ToString();
        }

        private void OnNumberSelect(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            ValueText = ValueText + button.Text;
            OnPropertyChanged(nameof(ValueText));
            // InputText.Text = ValueText;
        }

        private void OnBackSelect(object sender, EventArgs e)
        {
            if (ValueText == "")
            {
                return;
            }

            string newText = ValueText.Remove(ValueText.Length - 1, 1);
            ValueText = newText;
            OnPropertyChanged(nameof(ValueText));
            // InputText.Text = ValueText;
        }

        private async void OnEnterSelect(object sender, EventArgs e)
        {
            await App.Current.MainPage.DisplayAlert("Valor", ValueText, "OK");
            ValueText = "";
            OnPropertyChanged(nameof(ValueText));
            // InputText.Text = ValueText;
        }

        static class Constants
        {
            public static readonly Style KeypadStyles = new Style(typeof(Button));
        }
    }
}
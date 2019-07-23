# XamKey

Custom Xamarin Forms numeric keypad with custom input support!

## Usage

The _"Keypad"_ component exposes a _"CustotmInput"_ property where you can render a custom view for the Label.

```xml
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:XamKey.Keypad"
             x:Class="XamKey.MainPage">
    <ContentPage.Content>
        <StackLayout>
            <!-- Render XamKey:Keypad -->
            <local:Keypad ValueText="{Binding ValueText}" x:Name="XamKeypad" HorizontalOptions="FillAndExpand" VerticalOptions="FillAndExpand" >
                <local:Keypad.CustomInput>
                    <!-- Here you can declare your Custom Input View -->
                    <Label Text="{Binding ValueText}" x:Name="InputText" FontSize="48" FontAttributes="Bold" BackgroundColor="White" TextColor="Black" LineBreakMode="NoWrap" VerticalTextAlignment="Center"  />
                </local:Keypad.CustomInput>
            </local:Keypad>
        </StackLayout>
    </ContentPage.Content>
</ContentPage>
```

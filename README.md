# XamKey

Custom Xamarin Forms numeric keypad with custom view support!

## Usage

The _"Keypad"_ component exposes a _"CustomView"_ property where you can render a custom view for the Label.

```xml
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:XamKey.Keypad"
             x:Class="XamKey.MainPage">
    <ContentPage.Content>
        <StackLayout>
            <!-- Render XamKey:Keypad -->
            <local:Keypad x:Name="XamKeypad" HorizontalOptions="FillAndExpand" VerticalOptions="FillAndExpand" >
                <local:Keypad.CustomView>
                    <!-- Here you can declare your Custom Input View -->
                    <Label Text="{Binding ValueText}" x:Name="InputText" FontSize="48" FontAttributes="Bold" BackgroundColor="White" TextColor="Black" LineBreakMode="NoWrap" VerticalTextAlignment="Center"  />
                </local:Keypad.CustomView>
            </local:Keypad>
        </StackLayout>
    </ContentPage.Content>
</ContentPage>
```

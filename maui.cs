
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="MAUI_test_app.MainPage">

    <ScrollView>
        <VerticalStackLayout
            Spacing="25"
            Padding="30,0"
            VerticalOptions="Center"
            MaximumWidthRequest="550">

            <Image
                Source="burger.png"
                SemanticProperties.Description="Cute dot net bot waving hi to you!"
                HeightRequest="200"
                HorizontalOptions="Center" />

            <Label
                Text="MyFitCook"
                SemanticProperties.HeadingLevel="Level1"
                FontSize="32"
                HorizontalOptions="Center" />

            <Label
                x:Name="LabelWelcom"
                Text="Welcome to the best cookbook on the world ( pre-alpha test )"
                SemanticProperties.HeadingLevel="Level2"
                FontSize="18"
                HorizontalOptions="Center" />

            <Entry   
                x:Name="RecipeName"
                Placeholder="What Do You Want To Eat?"
                MaxLength="100"
                HorizontalOptions="Center" 
                MinimumWidthRequest="160"/>

            <Button
                x:Name="CounterBtn"
                Text="Find recipes for me"
                SemanticProperties.Hint="Counts the number of times you click"
                Clicked="SgowAvableRecipes"
                HorizontalOptions="Center" />

            <Label 
                IsVisible="false"
                x:Name="FoundListLabel"
                Text="We found this for you:"
                SemanticProperties.HeadingLevel="Level2"
                FontSize="18"
                HorizontalOptions="Center" />

            <CollectionView ItemsSource="{Binding Chats}"  
                            Margin="10" 
                            HorizontalOptions="Center"
                            x:Name="ListOfRecipes2">

                <CollectionView.ItemTemplate>
                    <DataTemplate>
                        <StackLayout Orientation="Vertical">

                            <Border Stroke="Gray"
                                    StrokeShape="RoundRectangle 8"
                                    StrokeThickness="1"
                                    HorizontalOptions="Start"
                                    Margin="8">
                                <Label Text="{Binding Title}"
                                       WidthRequest="400" HeightRequest="50"
                                       HorizontalOptions="Center"
                                       HorizontalTextAlignment="Center"
                                       VerticalTextAlignment="Center">
                                    <Label.GestureRecognizers>
                                        <TapGestureRecognizer Tapped="Lux2"/>
                                    </Label.GestureRecognizers>
                                </Label>
                            </Border>

                        </StackLayout>
                    </DataTemplate>
                </CollectionView.ItemTemplate>
            </CollectionView>
        </VerticalStackLayout>
    </ScrollView>

</ContentPage>

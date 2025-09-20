namespace VampireTheMasquerade.Controls;

public partial class TopMenu : ContentView
{
	public TopMenu()
	{
		InitializeComponent();
	}

	private async void ImageCheckBoxButton_Clicked(object sender, EventArgs e)
	{
		var imageButton = TopMenuButton;

		if (imageButton!.IsChecked)
		{
			imageButton.HorizontalOptions = LayoutOptions.End;
			TopMenuButtonGrid.IsVisible = true;
			GradientColorButton.IsVisible = true;
			imageButton.Margin = new Thickness(0, -25, 0, 0);
		}
		else
		{
			imageButton.HorizontalOptions = LayoutOptions.Start;
			TopMenuButtonGrid.IsVisible = false;
			GradientColorButton.IsVisible = false;
			imageButton.Margin = new Thickness(0, 0, 0, 0);

		}
	}
}
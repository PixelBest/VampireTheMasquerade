namespace VampireTheMasquerade.Controls;

public partial class TopMenu : ContentView
{
	public TopMenu()
	{
		InitializeComponent();
	}

	private async void ImageCheckBoxButton_Clicked(object sender, EventArgs e)
	{
		var imageButton = sender as ImageCheckBoxButton;

		if (imageButton!.IsChecked)
		{
			await imageButton.TranslateTo(this.Width - 86, 0, 0);
			imageButton.HorizontalOptions = LayoutOptions.End;
			imageButton.TranslationX = default;
			TopMenuButtonGrid.IsVisible = true;
		}
		else
		{
			await Task.WhenAll(imageButton.TranslateTo(0, 0, 0));

			imageButton.HorizontalOptions = LayoutOptions.Start;
			imageButton.TranslationX = default;
			TopMenuButtonGrid.IsVisible = false;
		}
	}
}
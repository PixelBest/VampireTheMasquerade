using VampireTheMasquerade.Pages.GameInformationPages;

namespace VampireTheMasquerade.Controls;

public partial class TopMenu : ContentView
{
	public static readonly BindableProperty DescriptionMenuItem =
		BindableProperty.Create(nameof(Description), typeof(string), typeof(DropdownList), string.Empty);

	public string Description
	{
		get => (string)GetValue(DescriptionMenuItem);
		set => SetValue(DescriptionMenuItem, value);
	}

	public TopMenu()
	{
		InitializeComponent();
		DescriptionLabel.SetBinding(Label.TextProperty, new Binding(nameof(Description), source: this));
	}

	private async void ImageCheckBoxButton_Clicked(object sender, EventArgs e)
	{
		var imageButton = TopMenuButton;

		if (imageButton!.IsChecked)
		{
			imageButton.HorizontalOptions = LayoutOptions.End;
			TopMenuButtonGrid.IsVisible = true;
			GradientColorButton.IsVisible = true;
			imageButton.Margin = new Thickness(0, -25, 0, -20);
			DescriptionLabel.IsVisible = false;
		}
		else
		{
			imageButton.HorizontalOptions = LayoutOptions.Start;
			TopMenuButtonGrid.IsVisible = false;
			GradientColorButton.IsVisible = false;
			imageButton.Margin = new Thickness(0, 0, 0, -20);
			DescriptionLabel.IsVisible = true;
		}
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		Navigation.PushModalAsync(new GameInformationPage());
	}

	private void Button_Clicked_1(object sender, EventArgs e)
	{
		Navigation.PopModalAsync();
	}
}
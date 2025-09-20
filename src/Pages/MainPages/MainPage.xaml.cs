using VampireTheMasquerade.Controls;
using VampireTheMasquerade.Pages.MainPages;

namespace VampireTheMasquerade
{
	public partial class MainPage : ContentPage
	{
		private readonly MainPageViewModel _viewModel;

		public MainPage(MainPageViewModel viewModel)
		{
			BindingContext = viewModel;
			_viewModel = viewModel;
			InitializeComponent();
		}

		private async void ImageButton_Clicked(object sender, EventArgs e)
		{
			var imageButton = sender as ImageCheckBoxButton;
			//var topMenu = TopMenu;

			//if (imageButton!.IsChecked)
			//{
			//	await Task.WhenAll(imageButton.TranslateTo(this.Width - 86, 0, 0), topMenu.TranslateTo(0, 0, 0));
			//	imageButton.HorizontalOptions = LayoutOptions.End;
			//	imageButton.TranslationX = default;
			//	topMenu.IsVisible = true;
			//}
			//else
			//{
			//	await Task.WhenAll(
			//		topMenu.TranslateTo(0, -300, 0),
			//		imageButton.TranslateTo(0, 0, 0)
			//		);

			//	imageButton.HorizontalOptions = LayoutOptions.Start;
			//	imageButton.TranslationX = default;
			//	topMenu.IsVisible = false;
			//}
		}
	}
}

using VampireTheMasquerade.Controls;
using VampireTheMasquerade.DataContext.WriteContext;
using VampireTheMasquerade.Pages.MainPages;

namespace VampireTheMasquerade
{
	public partial class MainPage : ContentPage
	{
		private readonly MainPageViewModel _viewModel;

		public MainPage(MainPageViewModel viewModel,
						WriteDataContext writeDataContext)
		{
			
			BindingContext = viewModel;
			_viewModel = viewModel;
			InitializeComponent();
		}
	}
}

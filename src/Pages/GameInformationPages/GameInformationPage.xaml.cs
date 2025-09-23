using System.Collections.ObjectModel;
using VampireTheMasquerade.Data;
using VampireTheMasquerade.Models;

namespace VampireTheMasquerade.Pages.GameInformationPages;

public partial class GameInformationPage : ContentPage
{
	public ObservableCollection<DropdownListItem> Items { get; } = new();

	public GameInformationPage()
	{
		InitializeComponent();
		LoadData();
		MainCollectionView.ItemsSource = Items;
	}

	private void LoadData()
	{
		foreach(var gameInformationItem in GameInformationData.GetGameInformationItems())
		{
			Items.Add(new DropdownListItem
			{
				MainText = gameInformationItem,
				DropdownItems = new (GameInformationData.GetGameInformationSubItems(gameInformationItem)),
				ItemSelectedCommand = new Command<string>(OnItemSelected)
			});
		}
	}

	private void OnItemSelected(string selectedItem)
	{
		ItemInformationView.ItemName = selectedItem;
		ItemInformationView.ContentText = GameInformationData.GetGameInformationByItem(selectedItem);
		ItemInformationView.IsVisible = true;
	}
}
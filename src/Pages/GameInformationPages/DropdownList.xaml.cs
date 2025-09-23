using System.Collections;

namespace VampireTheMasquerade.Pages.GameInformationPages;

public partial class DropdownList : ContentView
{
	public static readonly BindableProperty MainTextProperty =
		BindableProperty.Create(nameof(MainText), typeof(string), typeof(DropdownList), string.Empty);

	public static readonly BindableProperty ItemsSourceProperty =
		BindableProperty.Create(nameof(ItemsSource), typeof(IEnumerable), typeof(DropdownList),
			default(IEnumerable), propertyChanged: OnItemsSourceChanged);

	public static readonly BindableProperty ItemSelectedCommandProperty =
		BindableProperty.Create(nameof(ItemSelectedCommand), typeof(Command<string>), typeof(DropdownList));

	public string MainText
	{
		get => (string)GetValue(MainTextProperty);
		set => SetValue(MainTextProperty, value);
	}

	public IEnumerable ItemsSource
	{
		get => (IEnumerable)GetValue(ItemsSourceProperty);
		set => SetValue(ItemsSourceProperty, value);
	}

	public Command<string> ItemSelectedCommand
	{
		get => (Command<string>)GetValue(ItemSelectedCommandProperty);
		set => SetValue(ItemSelectedCommandProperty, value);
	}

	public DropdownList()
	{
		InitializeComponent();
		MainLabel.SetBinding(Label.TextProperty, new Binding(nameof(MainText), source: this));
	}

	private static void OnItemsSourceChanged(BindableObject bindable, object oldValue, object newValue)
	{
		if (bindable is DropdownList control && newValue is IEnumerable items)
		{
			control.DropdownCollectionView.ItemsSource = items;
		}
	}

	private void OnDropdownButtonClicked(object sender, EventArgs e)
	{
		var isVisible = !DropdownCollectionView.IsVisible;

		DropdownCollectionView.IsVisible = isVisible;
		if (isVisible)
		{
			CalculateDropdownHeight();
		}
		DropdownButton.Text = isVisible ? "▲" : "▼";
	}

	private void CalculateDropdownHeight()
	{
		if (ItemsSource == null)
		{
			DropdownCollectionView.HeightRequest = 0;
			return;
		}

		int itemCount = 0;
		foreach (var item in ItemsSource)
		{
			itemCount++;
		}

		int calculatedHeight = itemCount * 50;
		DropdownCollectionView.HeightRequest = calculatedHeight;
	}

	private void OnItemTapped(object sender, TappedEventArgs e)
	{
		if (sender is Grid grid && grid.BindingContext is string selectedItem)
		{
			ItemSelectedCommand?.Execute(selectedItem);
		}
	}
}
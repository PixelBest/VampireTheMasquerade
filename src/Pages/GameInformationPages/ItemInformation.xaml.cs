namespace VampireTheMasquerade.Pages.GameInformationPages;

public partial class ItemInformation : ContentView
{
	public static readonly BindableProperty ItemNameProperty =
		BindableProperty.Create(nameof(ContentText), typeof(string), typeof(ItemInformation),
			string.Empty, propertyChanged: OnItemNameChanged);

	public static readonly BindableProperty ContentTextProperty =
		BindableProperty.Create(nameof(ContentText), typeof(string), typeof(ItemInformation),
			string.Empty, propertyChanged: OnContentTextChanged);

	public string ItemName
	{
		get => (string)GetValue(ItemNameProperty);
		set => SetValue(ItemNameProperty, value);
	}

	public string ContentText
	{
		get => (string)GetValue(ContentTextProperty);
		set => SetValue(ContentTextProperty, value);
	}

	public ItemInformation()
	{
		InitializeComponent();
		ItemLabel.SetBinding(Label.TextProperty, new Binding(nameof(ItemName), source: this));
		ContentLabel.SetBinding(Label.TextProperty, new Binding(nameof(ContentText), source: this));
	}

	private static void OnItemNameChanged(BindableObject bindable, object oldValue, object newValue)
	{
		if (bindable is ItemInformation control)
		{
			control.ItemLabel.Text = newValue?.ToString() ?? string.Empty;
		}
	}

	private static void OnContentTextChanged(BindableObject bindable, object oldValue, object newValue)
	{
		if (bindable is ItemInformation control)
		{
			control.ContentLabel.Text = newValue?.ToString() ?? string.Empty;
		}
	}
}
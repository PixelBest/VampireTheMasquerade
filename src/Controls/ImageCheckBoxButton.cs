namespace VampireTheMasquerade.Controls
{
	public class ImageCheckBoxButton : ImageButton
	{
		public static readonly BindableProperty IsCheckedProperty =
			BindableProperty.Create(nameof(IsChecked), typeof(bool), typeof(ImageCheckBoxButton), default(bool));
		public bool IsChecked
		{
			get
			{
				return (bool)GetValue(IsCheckedProperty);
			}
			set
			{
				SetValue(IsCheckedProperty, value);
			}
		}

		public ImageCheckBoxButton()
		{
			Clicked += ImageCheckBoxButton_Clicked;
		}

		private void ImageCheckBoxButton_Clicked(object? sender, EventArgs e)
		{
			if (IsChecked)
			{
				IsChecked = false;
			}
			else
			{
				IsChecked = true;
			}
		}
	}
}

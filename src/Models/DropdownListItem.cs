namespace VampireTheMasquerade.Models
{
	public class DropdownListItem
	{
		public string MainText { get; set; }
		public List<string> DropdownItems { get; set; } = new();
		public Command<string> ItemSelectedCommand { get; set; }
	}
}

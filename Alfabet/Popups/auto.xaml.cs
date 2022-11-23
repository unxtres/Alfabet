using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class auto : CommunityToolkit.Maui.Views.Popup
{
	public auto()
	{
		InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}
using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class a0
	: CommunityToolkit.Maui.Views.Popup
{
	public a0()
	{
		InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}
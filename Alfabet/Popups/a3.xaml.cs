using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class a3
    : CommunityToolkit.Maui.Views.Popup
{
	public a3()
	{
		InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}
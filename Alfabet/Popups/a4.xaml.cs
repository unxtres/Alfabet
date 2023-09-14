using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class a4
    : CommunityToolkit.Maui.Views.Popup
{
	public a4()
	{
		InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}
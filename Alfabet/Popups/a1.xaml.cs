using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class a1
    : CommunityToolkit.Maui.Views.Popup
{
	public a1()
	{
		InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}
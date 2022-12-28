using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class a2
    : CommunityToolkit.Maui.Views.Popup
{
	public a2()
	{
		InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}
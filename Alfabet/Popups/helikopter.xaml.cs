using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class helikopter : CommunityToolkit.Maui.Views.Popup
{
    public helikopter()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}
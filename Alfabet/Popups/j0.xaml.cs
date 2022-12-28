using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class j0 : CommunityToolkit.Maui.Views.Popup
{
    public j0()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}
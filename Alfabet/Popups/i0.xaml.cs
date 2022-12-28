using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class i0 : CommunityToolkit.Maui.Views.Popup
{
    public i0()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}
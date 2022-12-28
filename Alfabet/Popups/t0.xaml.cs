using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class t0 : CommunityToolkit.Maui.Views.Popup
{
    public t0()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}
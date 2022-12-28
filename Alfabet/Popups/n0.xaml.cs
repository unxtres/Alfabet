using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class n0 : CommunityToolkit.Maui.Views.Popup
{
    public n0()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}
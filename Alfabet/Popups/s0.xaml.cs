using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class s0 : CommunityToolkit.Maui.Views.Popup
{
    public s0()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}
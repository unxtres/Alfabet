using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class o0 : CommunityToolkit.Maui.Views.Popup
{
    public o0()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}
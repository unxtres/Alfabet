using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class h0 : CommunityToolkit.Maui.Views.Popup
{
    public h0()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}
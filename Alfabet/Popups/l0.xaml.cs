using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class l0 : CommunityToolkit.Maui.Views.Popup
{
    public l0()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}
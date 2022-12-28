using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class g0 : CommunityToolkit.Maui.Views.Popup
{
    public g0()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}
using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class u0 : CommunityToolkit.Maui.Views.Popup
{
    public u0()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}
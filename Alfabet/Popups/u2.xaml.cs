using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class u2 : CommunityToolkit.Maui.Views.Popup
{
    public u2()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}
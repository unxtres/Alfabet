using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class l2 : CommunityToolkit.Maui.Views.Popup
{
    public l2()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}
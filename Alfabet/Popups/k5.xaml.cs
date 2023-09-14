using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class k5 : CommunityToolkit.Maui.Views.Popup
{
    public k5()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}
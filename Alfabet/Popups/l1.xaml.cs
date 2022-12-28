using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class l1 : CommunityToolkit.Maui.Views.Popup
{
    public l1()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}
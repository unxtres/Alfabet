using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class l3 : CommunityToolkit.Maui.Views.Popup
{
    public l3()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}
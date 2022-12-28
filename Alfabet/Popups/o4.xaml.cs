using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class o4 : CommunityToolkit.Maui.Views.Popup
{
    public o4()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}
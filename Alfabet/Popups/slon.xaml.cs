using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class slon : CommunityToolkit.Maui.Views.Popup
{
    public slon()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}
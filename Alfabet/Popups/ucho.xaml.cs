using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class ucho : CommunityToolkit.Maui.Views.Popup
{
    public ucho()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}
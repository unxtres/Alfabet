using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class nosorozec : CommunityToolkit.Maui.Views.Popup
{
    public nosorozec()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}
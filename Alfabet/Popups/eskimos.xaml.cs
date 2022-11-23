using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class eskimos : CommunityToolkit.Maui.Views.Popup
{
    public eskimos()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}
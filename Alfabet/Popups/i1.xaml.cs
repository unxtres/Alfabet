using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class i1 : CommunityToolkit.Maui.Views.Popup
{
    public i1()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}
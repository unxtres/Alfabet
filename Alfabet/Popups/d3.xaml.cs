using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class d3 : CommunityToolkit.Maui.Views.Popup
{
    public d3()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}
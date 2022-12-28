using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class d1 : CommunityToolkit.Maui.Views.Popup
{
    public d1()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}
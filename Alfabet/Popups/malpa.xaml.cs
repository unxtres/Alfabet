using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class malpa : CommunityToolkit.Maui.Views.Popup
{
    public malpa()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}
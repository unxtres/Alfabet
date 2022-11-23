using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class gruszka : CommunityToolkit.Maui.Views.Popup
{
    public gruszka()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}
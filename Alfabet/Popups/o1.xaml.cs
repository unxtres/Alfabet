using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class o1 : CommunityToolkit.Maui.Views.Popup
{
    public o1()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}
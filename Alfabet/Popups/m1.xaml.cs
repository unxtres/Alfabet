using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class m1 : CommunityToolkit.Maui.Views.Popup
{
    public m1()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}
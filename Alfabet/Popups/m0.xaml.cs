using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class m0 : CommunityToolkit.Maui.Views.Popup
{
    public m0()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}
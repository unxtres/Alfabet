using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class m2 : CommunityToolkit.Maui.Views.Popup
{
    public m2()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}
using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class m3 : CommunityToolkit.Maui.Views.Popup
{
    public m3()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}
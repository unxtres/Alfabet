using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class m4 : CommunityToolkit.Maui.Views.Popup
{
    public m4()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}
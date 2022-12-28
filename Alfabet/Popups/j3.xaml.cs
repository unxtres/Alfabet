using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class j3 : CommunityToolkit.Maui.Views.Popup
{
    public j3()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}
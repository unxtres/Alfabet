using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class f1 : CommunityToolkit.Maui.Views.Popup
{
    public f1()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}
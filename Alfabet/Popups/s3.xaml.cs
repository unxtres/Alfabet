using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class s3 : CommunityToolkit.Maui.Views.Popup
{
    public s3()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}
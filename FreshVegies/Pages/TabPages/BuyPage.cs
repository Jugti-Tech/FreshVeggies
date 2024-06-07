using CommunityToolkit.Maui.Converters;
using FreshVeggies.Models;

namespace FreshVeggies.Pages.TabPages;

public class BuyPage : BasePage
{
     private readonly BuyViewModel viewModel;	
	public BuyPage(BuyViewModel viewModel): base(viewModel)
	{

		this.viewModel = viewModel;
		Content = new CollectionView
		{
			ItemsLayout = new GridItemsLayout(2, ItemsLayoutOrientation.Vertical),
			SelectionMode = SelectionMode.Single,
			ItemTemplate = new DataTemplate(() =>
			{
				return new VerticalStackLayout
				{
					Children =
				{
					new Image {  }.Bind(Image.SourceProperty,nameof(Vegetable.Image),converter: new ByteArrayToImageSourceConverter()),
					new Label { FontSize = 20, FontAttributes = FontAttributes.Bold }.Bind(Label.TextProperty, nameof(Vegetable.Name)),
					new Label {  FontSize = 15 }.Bind(Label.TextProperty, nameof(Vegetable.Description)),
					new Label { FontSize = 20, FontAttributes = FontAttributes.Bold }.Bind(Label.TextProperty, nameof(Vegetable.DisplayPrice) ),
					new Button { Text = "Add to cart" }
				}
				};
			})
		}.Bind(ItemsView.ItemsSourceProperty, nameof(viewModel.Veggies)).Bind(SelectableItemsView.SelectionChangedCommandProperty, nameof(viewModel.VeggieSelectedCommand));


        Loaded += BuyPage_Loaded;
	}

    private async void BuyPage_Loaded(object? sender, EventArgs e)
    {
        await viewModel.Initialize();	
    }
}
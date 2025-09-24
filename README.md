# itemtemplate-selector-listview-xamarin
ItemTemplateSelector listview xamarin

## Sample

```xaml
<ContentPage.Resources>
    <ResourceDictionary>
        <local:MyDataTemplateSelector x:Key="MessageTemplateSelector"/>
    </ResourceDictionary>
</ContentPage.Resources>
<Grid>
    <sync:SfListView x:Name="ListView" 
                        ItemTemplate="{StaticResource MessageTemplateSelector}" 
                        ItemsSource="{Binding Messages}"
                        ItemSize="105"
                        SelectionMode="None"
                        BackgroundColor="#FFFAF0"/>
</Grid>

Incoming Cell:
<ViewCell xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="DataTemplateSelector.IncomingViewCell">
        <code>
        . . .
        . . .
        <code>
</ViewCell>

Outgoing cell:
<ViewCell xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="DataTemplateSelector.OutgoingViewCell">
        <code>
        . . .
        . . .
        <code>
</ViewCell>

DataTemplateSelector:

class MyDataTemplateSelector : Xamarin.Forms.DataTemplateSelector
{
    public DataTemplate IncomingDataTemplate { get; set; }
    public DataTemplate OutgoingDataTemplate { get; set; }

    public MyDataTemplateSelector()
    {
        this.incomingDataTemplate = new DataTemplate(typeof(IncomingViewCell));
        this.outgoingDataTemplate = new DataTemplate(typeof(OutgoingViewCell));  
    }

    protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
    {
        var messageVm = item as Message;
        if (messageVm == null)
            return null;
        return messageVm.IsIncoming ? this.incomingDataTemplate : this.outgoingDataTemplate;
    }

    private readonly DataTemplate incomingDataTemplate;
    private readonly DataTemplate outgoingDataTemplate;
}
```



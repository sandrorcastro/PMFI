using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using FiscalMobile.Context;
using FiscalMobile.Models;

namespace FiscalMobile.Views;
[QueryProperty("Items", "Items")]
public partial class ProcessoListPage : ContentPage
{
    FiscalMobileDBContext database;
    public ObservableCollection<ImovelCheck> Items { get; set; } = new();
   
    public ProcessoListPage(FiscalMobileDBContext fiscalMobileDBContext)
    {
       InitializeComponent();
       database = fiscalMobileDBContext;
       BindingContext = this;
    }
    public ProcessoListPage(List<ImovelCheck> docencontrado)
    {
        InitializeComponent();
        //this.Items = docencontrado.ToList();
        BindingContext = this;
    }


    protected override async void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
        var items = await database.ImovelCheck.Take(100).OrderBy(i=>i.InscricaoImobiliaria).ToListAsync(); // .GetItemsAsync();
        MainThread.BeginInvokeOnMainThread(() =>
        {
            Items.Clear();
            foreach (var item in items)
                Items.Add(item);

        });
    }
    async void OnItemAdded(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(VistoriaPage), true, new Dictionary<string, object>
        {
            ["Item"] = new Vistoria()
        });
    }

    private async void  CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is not Vistoria item)
            return;

        await Shell.Current.GoToAsync(nameof(VistoriaPage), true, new Dictionary<string, object>
        {
            ["Item"] = item
        });
    }
}


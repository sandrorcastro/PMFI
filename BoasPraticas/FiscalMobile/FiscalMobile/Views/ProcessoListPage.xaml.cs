using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using FiscalMobile.Context;
using FiscalMobile.Models;

namespace FiscalMobile.Views;
//[QueryProperty("Items", "Items")]
[QueryProperty("insc", "insc")]
public partial class ProcessoListPage : ContentPage
{
    FiscalMobileDBContext database;
    public string insc 
    {
        get =>  BindingContext as string ;
        set =>  BindingContext =value ;
    }
    public ObservableCollection<ImovelCheck> Items { get; set; } = new();
    /*public ObservableCollection<ImovelCheck> Items 
    { 
        get=> BindingContext as ObservableCollection<ImovelCheck>; 
        set=> BindingContext = value; 
    } */// = new();
    public ProcessoListPage()
    {
        InitializeComponent();
        BindingContext = this;
    }
    public ProcessoListPage(FiscalMobileDBContext fiscalMobileDBContext)
    {
       InitializeComponent();
       database = fiscalMobileDBContext;
       BindingContext = this;
       
    }
    public ProcessoListPage(FiscalMobileDBContext fiscalMobileDBContext,string inscricao)
    {
        InitializeComponent();
        this.insc = inscricao;
        database = fiscalMobileDBContext;
        BindingContext = this;
        //BindingContext = new ProcessoListPage(fiscalMobileDBContext, this.insc);
        
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

        if (e.Source == ShellNavigationSource.Push)
        {
            if (e.Parameter is Dictionary<string, object> parameters)
            {
                if (parameters.TryGetValue("insc", out object inscricao))
                {
                    // Agora você pode usar a inscrição (inscricao) na página de destino
                    // Certifique-se de fazer a conversão de tipo apropriada, se necessário
                    var items = await database.ImovelCheck.Where(i=>i.InscricaoImobiliaria==(string)inscricao).Take(10).OrderBy(i=>i.idDocumento).ToListAsync(); // .GetItemsAsync();
                }
            }
        }
        //var items = await database.ImovelCheck.Where(i => i.InscricaoImobiliaria == args.insc).Take(10).OrderBy(i => i.idDocumento).ToListAsync(); // .GetItemsAsync();
        
        
        
        
        
        
        
        
        
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
        if (e.CurrentSelection.FirstOrDefault() is not ImovelCheck item)
            return;

        await Shell.Current.GoToAsync(nameof(VistoriaPage), true, new Dictionary<string, object>
        {
            ["Item"] = item
        });
    }
}


using Microsoft.EntityFrameworkCore;
using VistoriaInLoco.Context;
using VistoriaInLoco.Models;

namespace VistoriaInLoco.Views;

[QueryProperty("Item", "Item")]
public partial class VistoriaPage : ContentPage
{
	private readonly ImovelCheckDBContext imovelDBContext;
    Vistoria item;
	public Vistoria  Item
	{
		get => BindingContext as Vistoria;
		set => BindingContext = value;
	}
    VistoriaDBContext database;
    public VistoriaPage(VistoriaDBContext _database, ImovelCheckDBContext _imovelDBContext)
    {
        InitializeComponent();
        database = _database;
        imovelDBContext = _imovelDBContext;
    }

    async void OnSaveClicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(Item.InscricaoImobiliaria))
        {
            await DisplayAlert("Inscrição Imobiliária requerida", "Entre com a Inscrição", "OK");
            return;
        }

        await database.AddAsync(Item);
        await database.SaveChangesAsync();
        await Shell.Current.GoToAsync("..");
    }
    void OnEntryTextChanged(object sender, TextChangedEventArgs e)
    {
        string oldText = e.OldTextValue;
        string newText = e.NewTextValue;
        string myText = entry.Text;
    }
    async void OnEntryCompleted(object sender, EventArgs e)
    {
        List<ImovelCheck> inscricoes = await imovelDBContext.ImovelCheck.Where(i=>i.InscricaoImobiliaria==entry.Text).ToListAsync();

        string text = ((Entry)sender).Text;
    }
    async void OnDeleteClicked(object sender, EventArgs e)
    {
        if (Item.IdVistoria == 0)
            return;
        //await database.Vistorias.ExecuteDeleteAsync(Item);
        await Shell.Current.GoToAsync("..");
    }

    async void OnCancelClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}
using Microsoft.EntityFrameworkCore;
using VistoriaInLoco.Context;
using VistoriaInLoco.Models;

namespace VistoriaInLoco.Views;

[QueryProperty("Item", "Item")]
public partial class VistoriaPage : ContentPage
{
	Vistoria item;
	public Vistoria  Item
	{
		get => BindingContext as Vistoria;
		set => BindingContext = value;
	}
    VistoriaDBContext database;
    public VistoriaPage(VistoriaDBContext _database)
    {
        InitializeComponent();
        database = _database;
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
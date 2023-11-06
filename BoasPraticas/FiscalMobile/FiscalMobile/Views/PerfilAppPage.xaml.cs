using FiscalMobile.Context;
using FiscalMobile.Models;
using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore;

namespace FiscalMobile.Views;
[QueryProperty("Item", "Item")]
public partial class PerfilAppPage : ContentPage
{
    private FiscalMobileDBContext database;
    
    
   
    public PerfilApp Item
    {
        get => BindingContext as PerfilApp;
        set => BindingContext = value;
    }
    
    public PerfilAppPage(FiscalMobileDBContext fiscalMobileDB)
    {
        InitializeComponent();
        database = fiscalMobileDB;
        //BindingContext = this;

        BindingContext = new PerfilApp();
    }
    
    async void OnSaveClicked(object sender, EventArgs e)
    {
       
        if (string.IsNullOrWhiteSpace(Item.Matricula))
        {
            await DisplayAlert("Matrícula requerida", "Entre com a Matrícula", "OK");
            
            return;
        }
        try
        {
            /*Item = new Vistoria
            {
                IdVistoria = 100,
                Alvara = "2023001",
                AnoTermino = "2023",
                AreaAberta = 0,
                AreaConstruidaFechada = 100,
                AreaTotalBCI = 1000,
                Caracteristica = "Predial",
                CVCOHabitese = "2023001",
                DataVistoria = "06/11/2023",
                Email="sandrorcastro@hotmail.com",
                InscricaoImobiliaria="12345678912345",
                MatriculaFiscal="2289401",
                NotificacaoAlvara="S",
                NotificacaoCVCOHabitese="S",
                ProcessoAlvara="S",
                ProcessoCVCOHabitese = "S",
                QuantidadeQuartos=1,
                ResponsavelBCI="S",
                ResponsavelMatricula="Fulano de Tal",
                Whatsapp = "45999565299"
            };*/
            Item.IdPerfilApp = int.Parse(Item.Matricula);
            database.Add(Item);
            database.SaveChanges();
            await Shell.Current.GoToAsync("..");

        }
        catch (DbUpdateException ex)
        {
            // A exceção DbUpdateException ocorreu, então vamos examinar a exceção interna.
            if (ex.InnerException != null)
            {
                Exception innerException = ex.InnerException;
                // A exceção interna contém informações detalhadas sobre o erro.
                // Você pode registrar ou imprimir essas informações para depuração.
                Console.WriteLine($"Erro interno: {innerException.Message}");
            }
            else
            {
                // Se não houver uma exceção interna, você pode lidar com a exceção de maneira mais genérica.
                Console.WriteLine($"Erro ao salvar as alterações no banco de dados: {ex.Message}");
            }
        }
    }
    void OnEntryTextChanged(object sender, TextChangedEventArgs e)
    {
        string oldText = e.OldTextValue;
        string newText = e.NewTextValue;
        //string myText = entry.Text;
    }
    async void OnEntryCompleted(object sender, EventArgs e)
    {
        //List<ImovelCheck> inscricoes = await database.ImovelCheck.Where(i => i.InscricaoImobiliaria == entry.Text).ToListAsync();

        string text = ((Entry)sender).Text;
    }
    async void OnDeleteClicked(object sender, EventArgs e)
    {
        if (Item.IdPerfilApp == 0)
            return;
        database.PerfilApp.Remove(Item);
        database.SaveChangesAsync();
        await Shell.Current.GoToAsync("..");
    }

    async void OnCancelClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}



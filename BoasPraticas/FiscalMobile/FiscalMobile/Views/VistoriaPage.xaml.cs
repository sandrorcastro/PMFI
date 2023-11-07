using FiscalMobile.Context;
using FiscalMobile.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading;
//using Microsoft.EntityFrameworkCore;

namespace FiscalMobile.Views;
[QueryProperty("Item", "Item")]
public partial class VistoriaPage : ContentPage
{
    private FiscalMobileDBContext database;
    //private PerfilApp perfil; 
    
    public Vistoria Item
    {
        get => BindingContext as Vistoria;
        set => BindingContext = value;
    }
    
    public VistoriaPage(FiscalMobileDBContext fiscalMobileDB)
    {
        InitializeComponent();
        //database = _database;
        //imovelDBContext = _imovelDBContext;
        database = fiscalMobileDB;
        //BindingContext = this;
        PerfilApp perfil = database.PerfilApp.FirstOrDefault();
        if (perfil == null)
        {
            Shell.Current.GoToAsync("PerfilAppPage");
        }
        BindingContext = new Vistoria {IdVistoria=int.Parse(perfil.Matricula), MatriculaFiscal=perfil.Matricula, DataVistoria=DateTime.Now.ToString()};
    }
    public async void TakePhoto(object sender, EventArgs e)
    {
        if (entry.Text == null)
        {
            await DisplayAlert("Inscrição Imobiliária requerida", "Entre com a Inscrição", "OK");

        }else {    if (MediaPicker.Default.IsCaptureSupported)
                    {
                        FileResult photo = await MediaPicker.Default.CapturePhotoAsync();
                        //photo.FileName = $"{entry.Text}.jpg";
                        
                        if (photo != null)
                        {
                            // save the file into local storage
                            string localFilePath = Path.Combine(FileSystem.CacheDirectory, photo.FileName);

                            using Stream sourceStream = await photo.OpenReadAsync();
                            using FileStream localFileStream = File.OpenWrite(localFilePath);


                            await sourceStream.CopyToAsync(localFileStream);
                        }
                    }
        }

    }
    async void OnSaveClicked(object sender, EventArgs e)
    {
       
        if (string.IsNullOrWhiteSpace(Item.InscricaoImobiliaria))
        {
            await DisplayAlert("Inscrição Imobiliária requerida", "Entre com a Inscrição", "OK");
            
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
        string myText = entry.Text;
    }
    async void OnEntryCompleted(object sender, EventArgs e)
    {
        List<ImovelCheck> docencontrado = await database.ImovelCheck.Where(i => i.InscricaoImobiliaria == entry.Text).ToListAsync();
        if (docencontrado.Count > 0)
        {

            await Shell.Current.GoToAsync(nameof(ProcessoListPage), true, new Dictionary<string, object>
            {
                ["Items"] = new ProcessoListPage(docencontrado)
            }); 
        } else
        {
            await DisplayAlert(entry.Text, "Não foi encontrado Nenhum Processo!", "OK");
        }
        string text = ((Entry)sender).Text;
    }
    async void OnDeleteClicked(object sender, EventArgs e)
    {
        if (Item.IdVistoria == 0)
            return;
        //await database.Vistoria.ExecuteDeleteAsync(Item.IdVistoria);
        database.Vistoria.Remove(Item);
        database.SaveChangesAsync();
        await Shell.Current.GoToAsync("..");
    }

    async void OnCancelClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}



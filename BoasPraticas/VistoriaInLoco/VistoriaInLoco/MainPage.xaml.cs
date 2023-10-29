using VistoriaInLoco.Context;

namespace VistoriaInLoco
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        private readonly VistoriaDBContext dbContext;
        public MainPage(VistoriaDBContext _dbContext)
        {
            dbContext = _dbContext;
            InitializeComponent();
            /*   dbContext.Vistorias.Add(new Models.Vistoria
           {
               IdVistoria = 3,
               DataVistoria = DateTime.Now,
               MatriculaFiscal = "2289401",
               InscricaoImobiliaria="11111111111111001",
               ResponsávelMatricula="Fulano de Tal",
               email="sandrorcastro@hotmail.com",
               whatsapp="45999565299",
               Caracteristica="Predial",
               AreaTotalBCI=1000,
               Alvara=null,
               NotificacaoAlvara=null,
               ProcessoAlvara=null,
               CVCOHabitese=null,
               NotificacaoCVCOHabitese = null,
               ProcessoCVCOHabitese=null,
               AnoTermino="2023",
               QuantidadeQuartos=5,
               AreaAberta=500,
               AreaConstruidaFechada=200,
           }); 
           dbContext.SaveChanges();*/
            lvVistorias.ItemsSource = dbContext.Vistorias.ToList();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }
}
using FiscalMobile.Context;
using System.ComponentModel;
using System.Windows.Input;

namespace FiscalMobile.Views
{
    public partial class MainPage : ContentPage //, INotifyPropertyChanged
    {
        public ICommand NavigateCommand { get; set; }
        FiscalMobileDBContext database;
        public MainPage(FiscalMobileDBContext _dbContext)
        {
            InitializeComponent();
            database = _dbContext;
            NavigateCommand = new Command<Type>(async (Type pageType) =>
            {
                
                if(pageType.Name == "VistoriaPage")
                {

                        var page = new VistoriaPage(database);
                        //Page page = (Page)Activator.CreateInstance(pageType);
                        //Page pagev = (Page)Activator.CreateInstance(pageType);
                        await Navigation.PushAsync(page);
                }
                if (pageType.Name == "VistoriaListPage")
                {

                    var page = new VistoriaListPage(database);
                    //Page page = (Page)Activator.CreateInstance(pageType);
                    //Page pagev = (Page)Activator.CreateInstance(pageType);
                    await Navigation.PushAsync(page);
                }
                if (pageType.Name == "ProcessoListPage")
                {

                    var page = new ProcessoListPage(database);
                    //Page page = (Page)Activator.CreateInstance(pageType);
                    //Page pagev = (Page)Activator.CreateInstance(pageType);
                    await Navigation.PushAsync(page);
                }
                if (pageType.Name == "PerfilAppPage")
                {

                    var page = new PerfilAppPage(database);
                    //Page page = (Page)Activator.CreateInstance(pageType);
                    //Page pagev = (Page)Activator.CreateInstance(pageType);
                    await Navigation.PushAsync(page);
                }
            });
            BindingContext = this;

            //  BindingContext = vistoriaDBContext;
        }
    }
}
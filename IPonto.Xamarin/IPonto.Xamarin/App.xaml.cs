using System;
using IPonto.Xamarin.Data;
using IPonto.Xamarin.Views;
using Xamarin.Forms;

namespace IPonto.Xamarin
{
	public partial class App : Application
	{
	    private static IPontoDatabase _database;

	    public static IPontoDatabase Database
	    {
	        get
	        {
	            if (_database == null)
	            {
	                _database = new IPontoDatabase(DependencyService.Get<IFileHelper>().GetLocalFilePath("IPontoSQLite.db3"));
	            }

	            return _database;
	        }
	    }

		public App ()
		{
			InitializeComponent();


            MainPage = new MainPage();
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

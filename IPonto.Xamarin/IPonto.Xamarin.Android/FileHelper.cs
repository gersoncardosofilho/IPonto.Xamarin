using System;
using System.IO;
using IPonto.Xamarin.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(FileHelper))]
namespace IPonto.Xamarin.Droid
{
    public class FileHelper : Xamarin.IFileHelper
    {
        public string GetLocalFilePath(string filename)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return Path.Combine(path, filename);
        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using GreenWorld.Persistence;
using SQLite;
using Xamarin.Forms;
using Environment = System.Environment;


namespace GreenWorld.Droid.Persistence
{
    class SQLiteDB : ISQLiteDB
    {
        
        public  SQLiteAsyncConnection GetConnection()
        {
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(documentsPath, "MySQLite.db3");

            return  new SQLiteAsyncConnection(path);
        }
    }
}
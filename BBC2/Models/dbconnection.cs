using SQLite.Net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBC2.Models
{
    class dbconnection
    {
        SQLiteConnection conn;

        public dbconnection()
        {
            string path = Path.Combine(Windows.ApplicationModel.Package.Current.InstalledLocation.Path, "db", "bbc.db");
            conn = new SQLite.Net.SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), path);
        }

        public List<Article> getArticles()
        {
            var data = conn.Table<Article>();
            return data.ToList();
        }
    }
}

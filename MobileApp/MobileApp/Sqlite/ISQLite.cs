using System;
using System.Collections.Generic;
using System.Text;

namespace MobileApp.Sql_Lite
{
    public interface ISQLite
    {
        string GetDatabasePath(string filename);
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using SQLite;


namespace GreenWorld.Persistence
{
    public interface ISQLiteDB
    {
        // Had to install sql-net-pcl-Async for
        // this to work
        // ran into major issue and turned back
        //SQLiteAsyncConnection GetConnection();

        //SQLiteConnection GetConnection();
        /*^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^*/
        // Attention: all the above confusion because 
        // of installing the wrong sqlite-net-pcl package
        // there are multiple and should install only this one!!
        SQLiteAsyncConnection GetConnection();

    }
}

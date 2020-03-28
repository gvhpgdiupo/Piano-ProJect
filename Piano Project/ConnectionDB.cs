using System.Data.SQLite;
using System.IO;

namespace Piano_Project
{
    class ConnectionDB
    {
        public SQLiteConnection myCon;

        public ConnectionDB()
        {
            myCon = new SQLiteConnection("Data Source=D:/MusicKey.db3;");
            if (!File.Exists("D:/MusicKey.db3")) 
            {                
                SQLiteConnection.CreateFile("D:/MusicKey.db3");                
            }            
        }

        public void OpenCon() 
        {
            if (myCon.State != System.Data.ConnectionState.Open) 
            {
                myCon.Open();
            }
        }

        public void CloseCon() 
        {
            if (myCon.State != System.Data.ConnectionState.Closed)
            {
                myCon.Close();
            }
        }
    }
}

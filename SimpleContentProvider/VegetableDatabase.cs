using System;
using Android.Database.Sqlite;
using Android.Content;

namespace CursorTableAdapter {
    class VegetableDatabase  : SQLiteOpenHelper {
        //      const string create_table_sql =
        //          "CREATE TABLE [vegetables] ([_id] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL UNIQUE, [name] TEXT NOT NULL UNIQUE)";
        //      new const string DatabaseName = "vegetables.db";
        //const int DatabaseVersion = 1;

        new const string DatabaseName = "accesstokens8.db";
        const string DatabaseTable = "accesstokens";
        const string create_table_sql = "CREATE TABLE " + DatabaseTable + " (_id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL UNIQUE, token TEXT NOT NULL UNIQUE)";
        const int DatabaseVersion = 1;

        public VegetableDatabase(Context context) : base(context, DatabaseName, null, DatabaseVersion) 
		{
		}
        
		public override void OnCreate(SQLiteDatabase db)
        {
            //db.ExecSQL(create_table_sql);
            //// seed with data
            //db.ExecSQL("INSERT INTO vegetables (name) VALUES ('Vegetables')");
            //db.ExecSQL("INSERT INTO vegetables (name) VALUES ('Fruits')");
            //db.ExecSQL("INSERT INTO vegetables (name) VALUES ('Flower Buds')");
            //db.ExecSQL("INSERT INTO vegetables (name) VALUES ('Legumes')");
            //db.ExecSQL("INSERT INTO vegetables (name) VALUES ('Bulbs')");
            //db.ExecSQL("INSERT INTO vegetables (name) VALUES ('Tubers')");
            Android.Util.Log.Debug("Test", "Service Database Created");
            db.ExecSQL(create_table_sql);
            // seed with data
            db.ExecSQL("INSERT INTO accesstokens (token) VALUES ('token1')");
            db.ExecSQL("INSERT INTO accesstokens (token) VALUES ('token2')");
        }
        public override void OnUpgrade(SQLiteDatabase db, int oldVersion, int newVersion)
        {   // not implemented
            throw new NotImplementedException();
        }
    }
}

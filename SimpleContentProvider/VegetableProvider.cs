using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;

using Android.App;
using Android.Content;
using Android.Database;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace CursorTableAdapter
{
    [ContentProvider(new string[] { CursorTableAdapter.VegetableProvider.AUTHORITY })]
    public class VegetableProvider : ContentProvider
    {

        //      public const string AUTHORITY = "com.xamarin.sample.VegetableProvider";
        //      static string BASE_PATH = "vegetables";
        //      public static readonly Android.Net.Uri CONTENT_URI = Android.Net.Uri.Parse("content://" + AUTHORITY + "/" + BASE_PATH);

        //      // MIME types used for getting a list, or a single vegetable
        //      public const string VEGETABLES_MIME_TYPE = ContentResolver.CursorDirBaseType + "/vnd.com.xamarin.sample.Vegetables";
        //public const string VEGETABLE_MIME_TYPE = ContentResolver.CursorItemBaseType + "/vnd.com.xamarin.sample.Vegetables";
        // ServiceDB _s_DB; // implements SQLiteOpenHelper, I'll add the code bellow

        VegetableDatabase _s_DB;
        public const string AUTHORITY = "com.xamarin.sample.VegetableProvider";
        static string BASE_PATH = "accesstokens";
        static string DATABASE_TABLE = "accesstokens";
        public static Android.Net.Uri CONTENT_URI = Android.Net.Uri.Parse("content://" + AUTHORITY + "/" + BASE_PATH);
        // MIME types used for getting a list, or a single access token
        public const string MIME_TYPES = ContentResolver.CursorDirBaseType + "/vnd.com.xamarin.sample.Vegetables";
        public const string MIME_TYPE = ContentResolver.CursorItemBaseType + "/vnd.com.xamarin.sample.Vegetables";


        // Column names
        public new static class InterfaceConsts
        {
            //public const string Id = "_id";
            //public const string Name = "name";
            public const string Id = "_id";
            public const string Token = "token";
        }

        VegetableDatabase vegeDB;

        public override bool OnCreate()
        {
            vegeDB = new VegetableDatabase(Context);
            return true;
        }

        const int GET_ALL = 0; // return code when a list of Vegetables is requested
        const int GET_ONE = 1; // return code when a single Vegetable is requested
        static UriMatcher uriMatcher = BuildUriMatcher();
        static UriMatcher BuildUriMatcher()
        {
            var matcher = new UriMatcher(UriMatcher.NoMatch);

            // to get data...
            matcher.AddURI(AUTHORITY, BASE_PATH, GET_ALL); // all vegetables
            matcher.AddURI(AUTHORITY, BASE_PATH + "/#", GET_ONE); // specific vegetable by numeric ID

            return matcher;
        }
        public override Android.Database.ICursor Query(Android.Net.Uri uri, string[] projection, string selection, string[] selectionArgs, string sortOrder)
        {
            switch (uriMatcher.Match(uri))
            {
                case GET_ALL:
                    return GetFromDatabase();
                case GET_ONE:
                    //if (selectionArgs == null) {
                    //    throw new Java.Lang.IllegalArgumentException(
                    //      "selectionArgs must be provided for the Uri: " + uri);
                    //}
                    var id = uri.LastPathSegment;
                    return GetFromDatabase(id);
                //                return Search(selectionArgs[0]);
                default:
                    throw new Java.Lang.IllegalArgumentException("Unknown Uri: " + uri);
            }
        }
        Android.Database.ICursor GetFromDatabase()
        {
            return vegeDB.ReadableDatabase.RawQuery("SELECT _id, token FROM accesstokens", null);
        }
        Android.Database.ICursor GetFromDatabase(string id)
        {
            return vegeDB.ReadableDatabase.RawQuery("SELECT _id, token FROM accesstokens WHERE _id = " + id, null);
        }

        public override String GetType(Android.Net.Uri uri)
        {
            switch (uriMatcher.Match(uri))
            {
                case GET_ALL:
                    return MIME_TYPES; // list
                case GET_ONE:
                    return MIME_TYPE; // single item
                default:
                    throw new Java.Lang.IllegalArgumentException("Unknown Uri: " + uri);
            }
        }

        public override int Delete(Android.Net.Uri uri, string selection, string[] selectionArgs)
        {
            throw new NotImplementedException(); //Java.Lang.UnsupportedOperationException();
        }

        public override Android.Net.Uri Insert(Android.Net.Uri uri, ContentValues values)
        {
            Android.Util.Log.Debug("Test", "Insert");
            //---add a new book---  
            _s_DB = new VegetableDatabase(this.Context);
            var _database = _s_DB.WritableDatabase;
            _database.BeginTransaction();
            long rowID = _database.Insert(DATABASE_TABLE, "", values);

            //---if added successfully---  
            if (rowID > 0)
            {
                var _uri = ContentUris.WithAppendedId(CONTENT_URI, rowID);
                Context.ContentResolver.NotifyChange(_uri, null);
                _database.SetTransactionSuccessful();
                _database.EndTransaction();
                return _uri;
            }
            throw new SQLException("Failed to insert row into " + uri);
            //throw new NotImplementedException(); //Java.Lang.UnsupportedOperationException();
        }

        public override int Update(Android.Net.Uri uri, ContentValues values, string selection, string[] selectionArgs)
        {
            throw new NotImplementedException(); //Java.Lang.UnsupportedOperationException();
        }
    }
}
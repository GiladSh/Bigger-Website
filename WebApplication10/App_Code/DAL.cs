﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

/// <summary>
/// Summary description for DAL
/// </summary>

public class DAL
{
    private string dbPath;
    private OleDbConnection conn;
    private OleDbCommand cmd;
    private OleDbDataAdapter adapter;
    private string strQuery;
    //פעולת קישור למסד הנתונים
	public DAL( string dbPath)
	{
        this.dbPath = dbPath;
		string connectionString= string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source={0}" ,this.dbPath);
        conn=new OleDbConnection(connectionString);
        cmd=new OleDbCommand(strQuery, conn);
        adapter=new OleDbDataAdapter(cmd);
	}
    //פעולת איחזור נתונים
    public DataSet GetData(string strSql)
    {
        DataSet ds = new DataSet();
        cmd.CommandText =strSql;
        adapter.SelectCommand=cmd;
        adapter.Fill(ds);
        return ds;
    }
    public bool IsExist(string strSql)
    {
        conn.Open();
        cmd.CommandText = strSql;
        OleDbDataReader data = cmd.ExecuteReader();
        bool found;
        found = (bool)data.Read(); //אם יש נתונים לקריאה יושם אמת אחרת שקר - הערך קיים במסד הנתונים
        conn.Close();
        return found;
    }
    //פעולת הוספה למאגר
    public bool update(string strSql)
    {
        conn.Open();
        cmd.CommandText = strSql;
        int update = cmd.ExecuteNonQuery();
        conn.Close();

        if (update > 0)
            return true;
        else
            return false;


    }
    public void insert(string strSql)
    {
        conn.Open();
        cmd.CommandText = strSql;
        cmd.ExecuteNonQuery();
        conn.Close();
    }

}
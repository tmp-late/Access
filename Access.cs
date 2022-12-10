using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;



/*DEVELOPED BY (telegram:https://t.me/frozehbrian) */

/// <summary>
///  Класс Access
///  содержит команды для OleDb
/// </summary>
class Access
{
    public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=";
    private OleDbConnection myConnection;
    /// <summary>
    ///  Конструктор класса Access прнимает стркоу с названием БД,
    ///  создает соединение,
    ///  используется для выполнения запросов
    /// </summary>
    public Access(string connection)
    {
        connectString += connection + ";";
        myConnection = new OleDbConnection(connectString);
        myConnection.Open();
    }
    /// <summary>
    ///  Фунция C_Select
    ///  принимает строку с запросом,
    ///  используется для выполнения SLEECT-запросов
    /// </summary>
    public OleDbCommand C_Select(string query)
    {
        OleDbCommand command = new OleDbCommand(query, myConnection);
        return command;
    }
    /// <summary>
    ///  Функция C_MultiQuerry
    ///  предоставляет возможность исполнения любого запроса из перечисленных (INSERT, UPDATE, DELETE)
    ///  для выполнения нужно передать запрос
    /// </summary>
    public void C_MultiQuerry(string query)
    {
        C_Select(query).ExecuteNonQuery();
    }
    /// <summary>
    ///  Функция Close_Connection
    ///  закрывает соединение с базой данных
    ///  требуется вызвать в любом случае после прекращения работы
    /// </summary>
    public void Close_Connection()
    {
        myConnection.Close();
    }
}

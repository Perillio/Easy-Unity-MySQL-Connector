using System.Collections;
using UnityEngine;

public class SQLConnector : MonoBehaviour
{
    public string serverIP = "127.0.0.1";
    public string databaseName = "mydb";
    public string dbUser = "root";
    public string dbPass = "testpass";

    public static void ParseReturnedQuery(string query)
    {
        // DO YOUR OWN STUFF WITH RETURNED DATA
    }

    public void DoDB(string query)
    {
        StartCoroutine(Register(query));
    }


    IEnumerator Register(string myQuery)
    {
        WWWForm form = new WWWForm();
        form.AddField("database", databaseName);
        form.AddField("password", dbPass);
        form.AddField("username", dbUser);
        form.AddField("serverip", serverIP);
        form.AddField("query", myQuery);
        WWW www = new WWW($"http://localhost/sqlconnect/sqlconnector.php", form);
        yield return www;
        ParseReturnedQuery(www.text);
    }
}

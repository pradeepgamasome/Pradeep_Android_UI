using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Data;
using Mono.Data.SqliteClient;
using System.Collections.Generic;
using UnityEngine.UI;




public class Scence_Manager : MonoBehaviour {
	int i=2;
//	public GameObject parent_Pannel;
	public GameObject Calendarr;


	void Start () {
		
//		for (int i = 0; i < 11; i++) {
//			Inputobj.Add( Instantiate (Inputfield));
//			Inputobj [i].transform.SetParent (parent_Pannel.transform, false);
//			var input =Inputobj [i].GetComponent<InputField> ();
//			var se= new InputField.SubmitEvent();
//			se.AddListener(SubmitName);
//			input.onEndEdit = se;
//		}
		//if(File.Exists("MasterSQLite.db"))
			


//
//		string _strDBName = "URI=file:MasterSQLiteCricket.db";
//		IDbConnection _connection = new SqliteConnection(_strDBName);
//		IDbCommand _command = _connection .CreateCommand();
//		string sql;
//
//
//		_connection .Open();
//
//		//sql = "CREATE TABLE scores (name VARCHAR(20), score INT)";
//
////		sql = "CREATE TABLE scoreTest(data VARCHAR(20), shot_count VARCHAR(20),sessionid VARCHAR(20), grounded VARCHAR(20), speed VARCHAR(20),type VARCHAR(20), headbalance VARCHAR(20),closetobody VARCHAR(20), middleofbat VARCHAR(20), time VARCHAR(20), direction VARCHAR(20))";
////		_command.CommandText = sql;
////		_command.ExecuteNonQuery();
//
//		sql = "INSERT INTO scoreTest (data, shot_count,sessionid, grounded, speed,type, headbalance, closetobody, middleofbat, time, direction)values('A','B','C','D','E','F','G','H','I','J','K')";
//		_command.CommandText = sql;
//		_command.ExecuteNonQuery();
//
////		sql = "insert into highscores (name, score) values ('Myself', 6000)";
////		_command.CommandText = sql;
////		_command.ExecuteNonQuery();
////
////		sql = "insert into highscores (name, score) values ('And I', 9001)";
////		_command.CommandText = sql;
////		_command.ExecuteNonQuery();
//
//		sql = "select * from scoreTest" ;//order by sessionid desc";
//		_command.CommandText = sql;
//		IDataReader _reader = _command.ExecuteReader();
//		while (_reader.Read())
//			Debug.Log("****** data: " + _reader["data"] + "\tshot: " + _reader["shot_count"]+"\tsession: " + _reader["sessionid"] + "\tgrounded: " + _reader["grounded"] + "\tspeed: " + _reader["speed"]+"\ttype: " + _reader["type"] + "\theadbal: " + _reader["headbalance"] + "\tclose to body: " + _reader["closetobody"]+"\tmiddle of the bat: " + _reader["middleofbat"] + "\ttime: " + _reader["time"]+"\tDirection"+_reader["direction"]);
//
//		_reader.Close();
//		_reader = null;
//		_command.Dispose();
//		_command = null;
//		_connection .Close();
//		_connection = null;
//

	}
	
	// Update is called once per frame
	void Update () {


	
	}





	public void  LoadScene (string SceneName) {
		//Application.LoadLevel (SceneName);
		SceneManager.LoadScene (SceneName);
	}

	public void OnDash()
	{
		Calendarr.SetActive (true);
	}

//	private void SubmitName(string arg0)
//	{
//		Debug.Log(arg0);
//	}


}

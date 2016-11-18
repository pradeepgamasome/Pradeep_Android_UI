using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System.Data;
using Mono.Data.SqliteClient;

public class InputScriptTEst : MonoBehaviour {

	public GameObject TextInput;

	public GameObject parent_Pannel;
	public GameObject Inputfield;
	public List<GameObject> Inputobj;
	//int id=2016110009;
	// Use this for initialization


	void Start () {
		




		for (int i = 0; i < 11; i++) {
			Inputobj.Add (Instantiate (Inputfield));
			Inputobj [i].transform.SetParent (parent_Pannel.transform, false);
			var input = Inputobj [i].GetComponent<InputField> ();
			var se = new InputField.SubmitEvent ();
			se.AddListener (SubmitName);
			input.onEndEdit = se;
		}


	}
	
	// Update is called once per frame
	void Update () {
	
	}






	private void SubmitName(string arg0)
	{
		//id += 1;

		//Debug.Log(arg0);
		string _strDBName = "URI=file:MasterSQLiteCricket1.db";
		IDbConnection _connection = new SqliteConnection(_strDBName);
		IDbCommand _command = _connection .CreateCommand();
		_connection .Open();
		string sql;

		string time = System.DateTime.Now.TimeOfDay.ToString();
//		sql = "CREATE TABLE scoreTest1(data VARCHAR(20), shot_count INT,sessionid INT PRIMARY KEY  NOT NULL  UNIQUE , grounded VARCHAR(20), speed FLOAT,type VARCHAR(20), headbalance VARCHAR(20),closetobody VARCHAR(20), middleofbat VARCHAR(20), time VARCHAR(20), direction VARCHAR(20))";
//				_command.CommandText = sql;
//				_command.ExecuteNonQuery();
//		Debug.Log ("Table Created");

		sql = "INSERT INTO scoreTest1(data, shot_count,sessionid, grounded, speed,type, headbalance,closetobody, middleofbat, time, direction)VALUES('GYANI',1,19,'YES',211.5,'BATSMAN','UNBALANCEED','VERY CLOSE','JUST MIDDLE',@time,'north-east')";

		//sql = "INSERT INTO scoreTest (data) values(@arg0)";
		//SqliteCommand command = new SqliteCommand();                                //creates new sqlite command
		_command.Parameters.Add(new SqliteParameter("@time", time));     //gives @currentdate sqlite parrameter data from current date variable
		//_command.Parameters.Add(new SqliteParameter("@id", id));
//		_command.CommandText = sql;                                              // sets dbcmd.CommandText to be equal to the insert statement created above
//		_command.ExecuteNonQuery();                         
		_command.CommandText = sql;
		_command.ExecuteNonQuery();
	




		sql = "select * from scoreTest1" ;//order by sessionid desc";
		_command.CommandText = sql;
		IDataReader _reader = _command.ExecuteReader();
		while (_reader.Read ()) {
			Debug.Log ("data: " + _reader ["data"] + "\tshot_count: " + _reader ["shot_count"] + "\tsessionid: " + _reader ["sessionid"] + "\tgrounded: " + _reader ["grounded"] + "\tspeed: " + _reader ["speed"] + "\ttype: " + _reader ["type"] + "\theadbalance: " + _reader ["headbalance"] + "\tclosetobody: " + _reader ["closetobody"] + "\tmiddleofbat: " + _reader ["middleofbat"] + "\ttime" + _reader ["time"] + "\tdirection" + _reader ["direction"]);

			string str = _reader ["data"].ToString ();
			TextInput.GetComponent<Text> ().text = str;
		}
		_reader.Close();
		_reader = null;
		_command.Dispose();
		_command = null;
		_connection .Close();
		_connection = null;

		//Inputobj [0].GetComponent<Text> ().text = _reader ["data"];

	}

	public void IntoButton()
	{
		
	}
}

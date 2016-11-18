
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using System.Data;
using Mono.Data.SqliteClient;

public class Test_uniquesessionid  : MonoBehaviour {
	//public List<string> StoredData;
	public List<string> Button_Text;

	int count;
	public List<GameObject> Button_Obj;
	public GameObject parent_content;
	public GameObject button;
	int val;
	//public GameObject ScrollContent;
	public GameObject ScreenContent;

	float height;

	public int space;
	public int no_button;
	// Use this for initialization


	//Button b = new Button[no_button];
	void Start () {
		
		//string time = System.DateTime.Now.TimeOfDay.ToString ();


		//new for the instanciate 

		string _strDBName = "URI=file:MasterSQLiteCricket04.db";
		IDbConnection _connection = new SqliteConnection(_strDBName);
		IDbCommand _command = _connection .CreateCommand();
		_connection .Open();
		string sql;

				sql = "create table if not exists scoreTest12(data varchar(255), shotcount int,session varchar(20), grounded varchar(10), speed float, type varchar(10), headbalance varchar(10), closetobody varchar(10), middleofbat varchar(10), time varchar(10),direction varchar(10),date varchar(10))";

				_command.CommandText = sql;
				_command.ExecuteNonQuery();




		val = 3;
		sql = "INSERT INTO scoreTest12(session)VALUES(@val)";
		_command.Parameters.Add(new SqliteParameter("@val", val));     //gives @currentdate sqlite parrameter data from current date variable
//		sql = "create table str8bat(data varchar(255), shotcount int,session varchar(20), grounded varchar(10), speed float, type varchar(10), headbalance varchar(10), closetobody varchar(10), middleofbat varchar(10), time varchar(10),direction varchar(10),date varchar(10))";
//
		_command.CommandText = sql;
	_command.ExecuteNonQuery();
//		sql = "insert into str8bat(data,shotcount,session,grounded,speed,type, headbalance,closetobody,middleofbat,time, direction, date)values(@data,@shotcount,@session,@grounded,@speed,@type,@headbalance,@closetobody,@middleofbat,@time,@direction,@date)";
//
//
//
//		_command.Parameters.Add(new SqliteParameter("@data", data));
//		_command.Parameters.Add(new SqliteParameter("@shotcount", shotcount));
//		_command.Parameters.Add(new SqliteParameter("@session", session));
//		_command.Parameters.Add(new SqliteParameter("@grounded", grounded));
//		_command.Parameters.Add(new SqliteParameter("@speed", speed));
//		_command.Parameters.Add(new SqliteParameter("@type", type));
//		_command.Parameters.Add(new SqliteParameter("@headbalance", headbalance));
//		_command.Parameters.Add(new SqliteParameter("@closetobody", closetobody));
//		_command.Parameters.Add(new SqliteParameter("@middleofbat", middleofbat));
//		_command.Parameters.Add(new SqliteParameter("@time", time));
//		_command.Parameters.Add(new SqliteParameter("@direction", direction));
//		_command.Parameters.Add(new SqliteParameter("@date", date));
//
//		_command.CommandText = sql;
//		_command.ExecuteNonQuery();






		sql="SELECT COUNT (session) FROM scoreTest12";

		_command.CommandText = sql;
		IDataReader _reader = _command.ExecuteReader();
		while (_reader.Read ()) {
			count = _reader.GetInt32(0);
			Debug.Log ("The count value of the session " + count);
		}
		//Debug.Log ("data: " + _reader ["data"] + "\tshot_count: " + _reader ["shot_count"] + "\tsessionid: " + _reader ["sessionid"] + "\tgrounded: " + _reader ["grounded"] + "\tspeed: " + _reader ["speed"] + "\ttype: " + _reader ["type"] + "\theadbalance: " + _reader ["headbalance"] + "\tclosetobody: " + _reader ["closetobody"] + "\tmiddleofbat: " + _reader ["middleofbat"] + "\ttime" + _reader ["time"] + "\tdirection" + _reader ["direction"]);





		//old;
		RectTransform parent1 = ScreenContent.GetComponent<RectTransform> ();
		RectTransform parent = parent_content.GetComponent<RectTransform> ();
		GridLayoutGroup gridScroll = parent_content.GetComponent<GridLayoutGroup> ();
		gridScroll.cellSize = new Vector2 ((parent1.rect.width)-10,(parent.rect.height/2));



		parent_content.GetComponent<RectTransform> ().sizeDelta=new Vector2(10,space*no_button);


		for (int i = 0; i < count; i++) {


			GameObject gob =Instantiate (button)as GameObject;

			Button_Obj.Add(gob );

			Button_Obj[i].transform.SetParent(parent_content.transform, false);

			Button_Obj[i].transform.position = new Vector3 (0,-i*space,0);
			//Button_Obj[i].transform.siz


//			Button_Obj[i].GetComponentInChildren<Text>().text = Button_Text[i];



			AddListener (Button_Obj[i].GetComponent<Button>() , i);

		}

		//again new code

		sql="SELECT session FROM scoreTest12";
		_command.CommandText = sql;
		IDataReader _reader1 = _command.ExecuteReader();
		while (_reader1.Read ()) {
			//val = _reader1.GetInt32 (0);
			count = _reader1.GetInt32(0);
			//Debug.Log ("The count value of the session id" + count);
			string str =_reader1 ["session"].ToString ();
			Button_Text.Add (str);
			//Debug.Log ("this is whole sessionid"+str);
			//Button_Text.Add (str);
		}



		_reader.Close();
		_reader = null;
		_command.Dispose();
		_command = null;
		_connection .Close();
		_connection = null;
		for (int i = 0; i < count; i++) {
			
			Button_Obj[i].GetComponentInChildren<Text>().text = Button_Text[i];
		}







	}


	void AddListener(Button b, int i)
	{
		b.onClick.AddListener(() => Work_onClick(i));
	}






	void Work_onClick(int i)
	{
		//print ("button click : "+i);
		//print ("Hello this is Button Vluae " + Button_Text [i]);
		//Application.LoadLevel ("Pop_upSceen");
		//print(PlayerPrefs.GetFloat("Data"));

		switch (i) {


		case 0:
			PlayerPrefs.SetString("Coach", System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")+"Zero");

			break;
		case 1:

			PlayerPrefs.SetString("Coach", System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")+"One");
			break;
		case 2:
			PlayerPrefs.SetString("Coach", System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")+"Two");
			break;
		case 3:
			PlayerPrefs.SetString("Coach", System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")+"Three");
			break;
		case 4:
			PlayerPrefs.SetString("Coach", System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")+"Four");
			break;

			//default:
			//	PlayerPrefs.SetFloat ("Data5", 5.0f);
			//		
			//			PlayerPrefs.SetString("date", System.DateTime.Now.ToString("yyyy/MM/dd"));
			//			Debug.Log(PlayerPrefs.GetString("date"));




		}

	}

	void Date_Time()
	{


		PlayerPrefs.SetString("date time", System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
		Debug.Log(PlayerPrefs.GetString("date time"));
	}




	// Update is called once per frame
	void Update () {

	}




}

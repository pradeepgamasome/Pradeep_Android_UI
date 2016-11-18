
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Demo_Button_script2  : MonoBehaviour {

	//public List<string> String_one;
	public List<string> StoredData;
	public List<string> Button_Text;


	public List<GameObject> Button_Obj;
	public GameObject parent_content;
	public GameObject button;


	public int space;
	public int no_button;
	// Use this for initialization


	//Button b = new Button[no_button];
	void Start () {

		parent_content.GetComponent<RectTransform> ().sizeDelta=new Vector2(10,space*no_button);


		for (int i = 0; i < no_button; i++) {


			GameObject gob =Instantiate (button)as GameObject;

			Button_Obj.Add(gob );

			Button_Obj[i].transform.SetParent(parent_content.transform, false);

			Button_Obj[i].transform.position = new Vector3 (0,-i*space,0);


			Button_Obj[i].GetComponentInChildren<Text>().text = Button_Text[i];



			AddListener (Button_Obj[i].GetComponent<Button>() , i);

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
			print (PlayerPrefs.GetString ("Coach"));
					
			break;
		case 1:

			print(PlayerPrefs.GetString ("Coach"));
			break;
		case 2:
			print(PlayerPrefs.GetString ("Coach"));
			break;
		case 3:
			print(PlayerPrefs.GetString ("Coach"));
			break;
		case 4:
			print(PlayerPrefs.GetString ("Coach"));
			break;

			//default:
			//	PlayerPrefs.SetFloat ("Data5", 5.0f);
		
		}

	}




	// Update is called once per frame
	void Update () {

	}




}

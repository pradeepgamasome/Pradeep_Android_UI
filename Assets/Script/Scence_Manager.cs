using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Scence_Manager : MonoBehaviour {
	int i=2;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

//		if (Input.GetKey (KeyCode.RightArrow)) {
//
//			SceneManager.LoadScene ("Scene"+i);
//			i++;
//		}
//		if (Input.GetKey (KeyCode.LeftArrow)) {
//			--i;
//			SceneManager.LoadScene ("Scene"+i);
//
//		}
	
	}


//	public void ChangeToScence(int scene_no)
//	{
//		SceneManager.LoadScene (scene_no);
//	}

//	void Swith_scene()
//	{
//		Application.LoadLevel ();
//	}



	public void  LoadScene (string SceneName) {
		Application.LoadLevel (SceneName);
	}

}

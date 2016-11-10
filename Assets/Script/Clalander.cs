using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Globalization;
public class Clalander : MonoBehaviour {
	public string Months;

	public List<GameObject> Date_obj;
	public List<GameObject> EmptyButtonList;
	public List<GameObject> EmptyButtonList1;
	public GameObject parent_Pannel;
	public GameObject date_button;
	public GameObject EmptyButton;
	public int no_days;
	public int day;
	public int year;
	public int month;
	public Text Year_text;
	public Text Month_text;
	public Text Date_text;
	public string firstday;
	public int emptybutton;
	public int remender;
	public int remendervalue;
	public int month_incrementer=0;










	void Start()
	{


		DateTime	firstDayOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
		firstday = firstDayOfMonth.ToString ("dddd");
		no_days = System.DateTime.DaysInMonth (System.DateTime.Now.Year, System.DateTime.Now.Month);
		year = System.DateTime.Now.Year;
		month = System.DateTime.Now.Month;

	
		//Year_text.text=System.DateTime.Now.Year.ToString();
		//Month_text.text = System.DateTime.Now.Month.ToString();

		Calender_Instanciate (no_days,month,year);


		}







	void Update () 
	{




	}


	public void Calender_Instanciate(int no_days,int month, int year)
	{



		Year_text.text=year.ToString();
		Month_text.text = month.ToString();
			DateTime	firstDayOfMonth = new DateTime(year, month, 1);
	firstday = firstDayOfMonth.ToString ("dddd");

		// for empty button list

	switch(firstday)
	{
	case "Sunday":
		emptybutton = 0;
		break;
	case "Monday":
		{
			emptybutton = 1;
		}
		break;
	case "Tuesday":
		{
			emptybutton = 2;
		}
		break;
	case "Wednesday":
		{
			emptybutton = 3;

		}
		break;
	case "Thursday":
		{
			emptybutton = 4;

		}
		break;

	case "Friday":
		{
			emptybutton = 5;
		}
		break;
	case "Saturday":
		{
			emptybutton = 6;

		}
		break;

	}

		for (int i = 0; i < emptybutton; i++) {
			GameObject egob= Instantiate (EmptyButton)as GameObject;
			EmptyButtonList.Add (egob);
			EmptyButtonList[i].transform.SetParent(parent_Pannel.transform, false);
		}




	//for instanciation of the main date buttons

		for (int i = 0; i < no_days; i++) {
			GameObject gob = Instantiate (date_button) as GameObject;
			Date_obj.Add (gob);
			Date_obj [i].transform.SetParent (parent_Pannel.transform, false);
			Date_obj [i].GetComponentInChildren<Text> ().text = (i + 1).ToString ();


			AddListener (Date_obj [i].GetComponent<Button> (), i);
		}

		//empty button after generation of real dates


		remender = (no_days + emptybutton) % 7;
		remendervalue = 7 - remender;
		if (remender != 0) {
			for (int j = 0; j < remendervalue; j++) {
				GameObject egob = Instantiate (EmptyButton)as GameObject;
				EmptyButtonList1.Add (egob);
				EmptyButtonList1 [j].transform.SetParent (parent_Pannel.transform, false);

			}
		} 


	}







	 public void AddListener(Button b, int i)
	{
		b.onClick.AddListener(() => Work_onClick(i));
	}





	public void Work_onClick(int i)
	{
		//print ("button click : "+i);
		//print ("Selected Date is " + Date_obj[i].GetComponentInChildren<Text>().text+"-"+System.DateTime.Now.Month+"-"+System.DateTime.Now.Year);

		print ("Selected Date is " + Date_obj[i].GetComponentInChildren<Text>().text+"-"+month+"-"+year);
		//print(System.DateTime.MinValue.DayOfWeek)
	}





	public void Increase_year()
	{
		Delete_ExtraButtons ();
		year=year+1;
		month = month + 0;

		no_days=System.DateTime.DaysInMonth(year,month);
		print (no_days);


		Calender_Instanciate (no_days,month,year);
		print (no_days);


	}




	public void Decrease_year()
	{

		Delete_ExtraButtons ();
		year=year-1;
		month = month + 0;

		no_days=System.DateTime.DaysInMonth(year,month);
		print (no_days);


		Calender_Instanciate (no_days,month,year);
		print (no_days);
	}




	public void Increse_Month()
	{
		Delete_ExtraButtons ();

		if (month <=12) {
			month = month +1;
			year = year + 0;
		}
		if (month >12) {
			month = 1;
			year = year + 1;
		}

		no_days = System.DateTime.DaysInMonth (year, month);
		print (no_days);
		Calender_Instanciate (no_days,month,year);
	}





	public void Decrease_Month()
	{
		Delete_ExtraButtons ();

		if (month >= 1) {
			month = month - 1;
			year += 0;
		}
		if (month < 1) {
			month = 12;
			year = year - 1;
		}
		no_days = System.DateTime.DaysInMonth (year, month);
		print (no_days);
		Calender_Instanciate (no_days,month,year);
	}




	public void Check_Button()
	{

		DateTime	firstDayOfMonth = new DateTime(year, month, 1);
		firstday = firstDayOfMonth.ToString ("dddd");
		print (firstday);
	}






	public void Delete_ExtraButtons()
	{
		for (int i = 0; i < EmptyButtonList.Count; i++) {
			Destroy (EmptyButtonList [i]);
		}
		EmptyButtonList.Clear ();
		for (int i = 0; i < Date_obj.Count; i++) {
			Destroy (Date_obj [i]);
		}
		Date_obj.Clear ();

		for (int i = 0; i < EmptyButtonList1.Count; i++) {
			Destroy (EmptyButtonList1 [i]);
		}
		EmptyButtonList1.Clear ();
	}





}



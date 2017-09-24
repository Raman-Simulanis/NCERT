using UnityEngine;
using System.Collections;

public class load_level1 : MonoBehaviour {

	// Use this for initialization

	public static bool loading_status = false;// tu iski jgha prefab use kar lio
	public Texture loadingTexture; // isse tu image define karega ki kise rotate karna hai
	// tu progress baar b  lga skta hai
	public float size = 70.0f;
	public float rotAngle = 0.0f;
	public float rotSpeed = 300f;
	Vector2 centerPoint;
	AsyncOperation a;
	bool check;

	void Start () 
	{
		loading_status = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (a != null) {
			loading_status = true;  
		}
		if(loading_status){
			rotAngle += rotSpeed * Time.deltaTime;// this is for continous rotation
		}
	}

	void OnGUI()
	{
		if(loading_status){
			centerPoint =new Vector2(Screen.width/2, Screen.height/2);// yeh centerpoint pe rotate k liye hai
			GUIUtility.RotateAroundPivot(rotAngle%360,centerPoint);// yaha image ko bta rhe hai ki uske center point kaun sa hai
			GUI.DrawTexture(new Rect((Screen.width - size)/2,(Screen.height - size)/2,size,size),loadingTexture); // isse image aati hai center pe
		}
	}

	public void ar_13_3_13_4()
	{
		try
		{
			a = Application.LoadLevelAsync("13.3_&_13.4");
		}
		catch(System.Exception e)
		{
			print ("Something Wrong With Your Device");
		}
	}

	public void ar_13_5_13_12_13_6()
	{
		try
		{
			a = Application.LoadLevelAsync("13.5_&_13.12_13.6");
		}
		catch(System.Exception e)
		{
			print ("Something Wrong With Your Device");
		}
	}

	public void ar_13_9_13_10_13_11()
	{
		try
		{
			a = Application.LoadLevelAsync("13.9_&_13.10_&_13.11");
		}
		catch(System.Exception e)
		{
			print ("Something Wrong With Your Device");
		}
	}
	public void ar_13_7()
	{

		try
		{
			a = Application.LoadLevelAsync("13.7");
		}
		catch(System.Exception e)
		{
			print ("Something Wrong With Your Device");
		}
	}
	public void ar_13_15_13_19()
	{
		try
		{
			a = Application.LoadLevelAsync("13.15_&_13.19");
		}
		catch(System.Exception e)
		{
			print ("Something Wrong With Your Device");
		}
	}

	public void ar_13_20()
	{
		try
		{
			a = Application.LoadLevelAsync("13.20");
		}
		catch(System.Exception e)
		{
			print ("Something Wrong With Your Device");
		}
	}
	public void ar_13_2()
	{
		try
		{
			a = Application.LoadLevelAsync("13.2");
		}
		catch(System.Exception e)
		{
			print ("Something Wrong With Your Device");
		}
	}



	public void back_btn()
	{
		try
		{
			a = Application.LoadLevelAsync("main_menu");
		}
		catch(System.Exception e)
		{
			print ("Something Wrong With Your Device");
		}
	}
}

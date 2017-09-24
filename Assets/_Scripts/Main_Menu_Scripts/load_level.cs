using UnityEngine;
using System.Collections;

public class load_level : MonoBehaviour {

	// Use this for initialization

	//public GameObject main_can;
	public GameObject help_img;
	public static bool loading_status = false;// tu iski jgha prefab use kar lio
	public Texture loadingTexture; // isse tu image define karega ki kise rotate karna hai
	// tu progress baar b  lga skta hai
	public float size = 70.0f;
	public float rotAngle = 0.0f;
	public float rotSpeed = 300f;
	Vector2 centerPoint;
	AsyncOperation a;
	bool check;

	void Awake ()
	{
		help_img.gameObject.SetActive (false);
	}
	void Start ()
	{
		check = true;
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

	public void help_btn()
	{
		if (check == true) {
			help_img.gameObject.SetActive (true);
			check = false;

		} else if (check == false) {
			help_img.gameObject.SetActive (false);
			check = true;
		}

		//help_can.gameObject.SetActive (true);
		//main_can.gameObject.SetActive (false);
	}
	public void start_btn()
	{
		help_img.gameObject.SetActive (false);

		try
		{
			a = Application.LoadLevelAsync("menu_list");
		}
		catch(System.Exception e)
		{
			print ("Something Wrong with Your Device");
		}
	}
	public void exit_btn()
	{
		Application.Quit ();
		help_img.gameObject.SetActive (false);
	}
}

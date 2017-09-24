using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class rotates : MonoBehaviour {

    public GameObject BarMagnet;

	public static bool loading_status = false;// tu iski jgha prefab use kar lio
	public Texture loadingTexture; // isse tu image define karega ki kise rotate karna hai
	// tu progress baar b  lga skta hai
	public float size = 70.0f;
	public float rotAngle = 0.0f;
	public float rotSpeed = 300f;
	Vector2 centerPoint;
	AsyncOperation a;


    //public float speed = 300f;

	//public GameObject ElectricMotor;
	void Start () 
	{
		loading_status = false;
	}
	void Update()
	{
		if (a != null) {
			loading_status = true;  
		}
		if(loading_status){
			rotAngle += rotSpeed * Time.deltaTime;// this is for continous rotation
		}
	}
    public void Up ()
    {
        BarMagnet.GetComponent<update_rotate>().enabled = true;
    }
    public void upss ()
    {
        BarMagnet.GetComponent<update_rotate>().enabled = false;
    }
    public void down()
    {
        BarMagnet.GetComponent<Negative_rotate_update>().enabled = true;
    }
    public void downs()
    {
        BarMagnet.GetComponent<Negative_rotate_update>().enabled = false;
    }
    public void Leftss ()
    {
        BarMagnet.GetComponent<left_rotate>().enabled = true;
    }
    public void left()
    {
        BarMagnet.GetComponent<left_rotate>().enabled = false;
    }
    public void right()
    {
        BarMagnet.GetComponent<right_rotate>().enabled = true;
    }
    public void rights()
    {
        BarMagnet.GetComponent<right_rotate>().enabled = false;
    }


	/// <summary>
	/// ///////////////////////////////
	/// </summary>
	void OnGUI()
	{
		if(loading_status){
			centerPoint =new Vector2(Screen.width/2, Screen.height/2);// yeh centerpoint pe rotate k liye hai
			GUIUtility.RotateAroundPivot(rotAngle%360,centerPoint);// yaha image ko bta rhe hai ki uske center point kaun sa hai
			GUI.DrawTexture(new Rect((Screen.width - size)/2,(Screen.height - size)/2,size,size),loadingTexture); // isse image aati hai center pe
		}
	}
	/// /// <summary>
	/// ///////////////////////////////
	/// </summary>


	public void fig_13_4_vr()
    {
		try
		{
			a = Application.LoadLevelAsync("13.4_vr");
		}
		catch(System.Exception e)
		{
			print ("Something Wrong with Your Device");
		}
    }
	public void fig_13_3_vr()
	{
		try
		{
			a = Application.LoadLevelAsync("13.3_vr");
		}
		catch(System.Exception e)
		{
			print ("Something Wrong with Your Device");
		}
	}
	/// <summary>
	/// //////////////////////////////////////////////////////////////////////
	/// </summary>
	public void fig_13_15_vr()
	{
		try
		{
			a = Application.LoadLevelAsync("13.15_vr");
		}
		catch(System.Exception e)
		{
			print ("Something Wrong with Your Device");
		}
	}
	public void fig_13_19_vr()
	{
		try
		{
			a = Application.LoadLevelAsync("13.19_vr");
		}
		catch(System.Exception e)
		{
			print ("Something Wrong with Your Device");
		}
	}
	/// <summary>
	/// ///////////////////////////////////////////////////////////////////////
	/// </summary>
	public void fig_13_7_vr()
	{
		try
		{
			a = Application.LoadLevelAsync("13.7_vr");
		}
		catch(System.Exception e)
		{
			print ("Something Wrong with Your Device");
		}
	}
	/// <summary>
	/// ///////////////////////////////////////////////////////////////////////
	/// </summary>
	public void fig_13_9_vr()
	{
		try
		{
			a = Application.LoadLevelAsync("13.9_vr");
		}
		catch(System.Exception e)
		{
			print ("Something Wrong with Your Device");
		}
	}
	public void fig_13_10_vr()
	{
		try
		{
			a = Application.LoadLevelAsync("13.10_vr");
		}
		catch(System.Exception e)
		{
			print ("Something Wrong with Your Device");
		}
	}
	public void fig_13_11_vr()
	{
		try
		{
			a = Application.LoadLevelAsync("13.11_vr");
		}
		catch(System.Exception e)
		{
			print ("Something Wrong with Your Device");
		}
	}
	/// <summary>
	/// //////////////////////////////////////////////////////////////////////
	/// </summary>
	public void fig_13_5_vr()
	{
		try
		{
			a = Application.LoadLevelAsync("13.5_vr");
		}
		catch(System.Exception e)
		{
			print ("Something Wrong with Your Device");
		}
	}
	/// <summary>
	/// ///////////////////////////////////////////////////////////////////////
	/// </summary>
	public void fig_13_20_vr()
	{
		try
		{
			a = Application.LoadLevelAsync("13.20_vr");
		}
		catch(System.Exception e)
		{
			print ("Something Wrong with Your Device");
		}
	}
	/// <summary>
	/// ////////////////////////////////////////////////////////////////////////
	/// </summary>
	public void fig_13_12_vr()
	{
		try
		{
			a = Application.LoadLevelAsync("13.12_vr");
		}
		catch(System.Exception e)
		{
			print ("Something Wrong with Your Device");
		}
	}
	/// <summary>
	/// /////////////////////////////////////////////////////////////////////////
	/// </summary>
	/// 
	AsyncOperation async;
	public void fig_13_2_vr()
	{
		try
		{
			a = Application.LoadLevelAsync("13.2_vr");
		}
		catch(System.Exception e)
		{
			print ("Something Wrong with Your Device");
		}
	}
	/// <summary>
	/// ////////////////////////////////////////////////////////////////////////////
	/// </summary>
	public void fig_13_6_vr()
	{
		try
		{
			a = Application.LoadLevelAsync("13.6_vr");
		}
		catch(System.Exception e)
		{
			print ("Something Wrong with Your Device");
		}
	}
	/// <summary>
	/// ////////////////////////////////////////////////////////////////////////////
	/// </summary>
	public void back_button_scenes()
	{
		try
		{
			a = Application.LoadLevelAsync("menu_list");
		}
		catch(System.Exception e)
		{
			print ("Something Wrong with Your Device");
		}
	}

}

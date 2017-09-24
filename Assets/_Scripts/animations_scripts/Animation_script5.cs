using UnityEngine;
using System.Collections;

public class Animation_script5 : MonoBehaviour {

	
	public GameObject reset_btn;
	public GameObject sound_2;

	public GameObject fbx;
	public GameObject ani_0;
	public GameObject ani_1;
	public GameObject ani_2;
	public GameObject ani_3;
	public GameObject ani_4;
	public GameObject ani_5;
	public GameObject ani_6;
	public GameObject ani_7;
	public GameObject ani_8;

	//sound

	public GameObject marker_1;
	public GameObject marker_2;
	public GameObject marker_3;
	public GameObject marker_4;
	public GameObject marker_5;
	public GameObject marker_6;
	public GameObject marker_7;
	public GameObject marker_8;
	public GameObject marker_9;



	public GameObject whole_circle;

	static int count;

	int ani_1_check = 0;
	int ani_2_check = 0;
	int ani_3_check = 0;
	int ani_4_check = 0;
	int ani_5_check = 0;
	int ani_6_check = 0;
	int ani_7_check = 0;
	int ani_8_check = 0;
	int ani_9_check = 0;
	

	// Use this for initialization
	void Start () 
	{
		marker_1.gameObject.SetActive (false);
		marker_2.gameObject.SetActive (false);
		marker_3.gameObject.SetActive (false);
		marker_4.gameObject.SetActive (false);
		marker_5.gameObject.SetActive (false);
		marker_6.gameObject.SetActive (false);
		marker_7.gameObject.SetActive (false);
		marker_8.gameObject.SetActive (false);
		marker_9.gameObject.SetActive (false);

		whole_circle.gameObject.SetActive (false);

	}
	
	
	void Update () {
		//This is to load level 2 if all the bricks are broken
		
		int howMany = GameObject.FindGameObjectsWithTag("mark").Length;
		//Debug.Log(howMany);
		
		if(howMany == 9)
		{
			marker_1.gameObject.SetActive (false);
			marker_2.gameObject.SetActive (false);
			marker_3.gameObject.SetActive (false);
			marker_4.gameObject.SetActive (false);
			marker_5.gameObject.SetActive (false);
			marker_6.gameObject.SetActive (false);
			marker_7.gameObject.SetActive (false);
			marker_8.gameObject.SetActive (false);
			marker_9.gameObject.SetActive (false);
			
			ani_0.gameObject.SetActive(false);
			ani_1.gameObject.SetActive(false);
			ani_2.gameObject.SetActive(false);
			ani_3.gameObject.SetActive(false);
			ani_4.gameObject.SetActive(false);
			ani_5.gameObject.SetActive(false);
			ani_6.gameObject.SetActive(false);
			ani_7.gameObject.SetActive(false);
			ani_8.gameObject.SetActive(false);


			getthings ();
		}
		
	}
	// Update is called once per frame

	public void ani_1_fun()
	{
		fbx.gameObject.GetComponent<Animation> ().Play ("first");
		marker_1.gameObject.SetActive (true);
	}
	public void ani_2_fun()
	{
		int x = 0;
		fbx.gameObject.GetComponent<Animation> ().Play ("Second");
		marker_2.gameObject.SetActive (true);
	}
	public void ani_3_fun()
	{
		fbx.gameObject.GetComponent<Animation> ().Play ("third");
		marker_3.gameObject.SetActive (true);
	}
	public void ani_4_fun()
	{
		fbx.gameObject.GetComponent<Animation> ().Play ("fourth");
		marker_4.gameObject.SetActive (true);
	}
	public void ani_5_fun()
	{
		fbx.gameObject.GetComponent<Animation> ().Play ("five");
		marker_5.gameObject.SetActive (true);
	}
	public void ani_6_fun()
	{
		fbx.gameObject.GetComponent<Animation> ().Play ("six");
		marker_6.gameObject.SetActive (true);
	}
	public void ani_7_fun()
	{
		fbx.gameObject.GetComponent<Animation> ().Play ("seven");
		marker_7.gameObject.SetActive (true);
	}
	public void ani_8_fun()
	{
		fbx.gameObject.GetComponent<Animation> ().Play ("eight");
		marker_8.gameObject.SetActive (true);
	}
	public void ani_9_fun()
	{
		fbx.gameObject.GetComponent<Animation> ().Play ("nine");
		marker_9.gameObject.SetActive (true);
	}
	public void ani_full_circle_fun()
	{
		fbx.gameObject.GetComponent<Animation> ().Play ("full_circle");
	}

	public void reset()
	{
		sound_2.gameObject.GetComponent<AudioSource> ().Stop ();
		fbx.gameObject.GetComponent<AudioSource> ().Play ();
		whole_circle.gameObject.SetActive (false);
		ani_0.gameObject.SetActive(true);
		ani_1.gameObject.SetActive(true);
		ani_2.gameObject.SetActive(true);
		ani_3.gameObject.SetActive(true);
		ani_4.gameObject.SetActive(true);
		ani_5.gameObject.SetActive(true);
		ani_6.gameObject.SetActive(true);
		ani_7.gameObject.SetActive(true);
		ani_8.gameObject.SetActive(true);

		marker_1.gameObject.SetActive (false);
		marker_2.gameObject.SetActive (false);
		marker_3.gameObject.SetActive (false);
		marker_4.gameObject.SetActive (false);
		marker_5.gameObject.SetActive (false);
		marker_6.gameObject.SetActive (false);
		marker_7.gameObject.SetActive (false);
		marker_8.gameObject.SetActive (false);
		marker_9.gameObject.SetActive (false);
	}

	public void getthings ()
	{

		reset_btn.gameObject.SetActive (true);
		whole_circle.gameObject.SetActive (true);
		fbx.gameObject.GetComponent<AudioSource> ().Stop ();
		sound_2.gameObject.GetComponent<AudioSource> ().Play ();
	}
}


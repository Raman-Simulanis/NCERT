using UnityEngine;
using System.Collections;

public class Animation_script1 : MonoBehaviour {


	public GameObject fbx;

	public GameObject sound_2;
	public GameObject sound_3;

	public GameObject switch_on_btn;
	public GameObject switch_on_btn2;
	public GameObject switch_off_btn;
	public GameObject cardboard_btn;
	public GameObject steelrod_btn;
	public GameObject reset_btn;


	// Use this for initialization
	void Start () 
	{
		switch_on_btn2.gameObject.SetActive (false);
		cardboard_btn.gameObject.SetActive (false);
		steelrod_btn.gameObject.SetActive (false);
		switch_off_btn.gameObject.SetActive (false);
		reset_btn.gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	public void switch_on()
	{
		fbx.gameObject.GetComponent<AudioSource>().Stop();
		sound_2.gameObject.GetComponent<AudioSource> ().Play ();
		switch_on_btn.gameObject.SetActive (false);
		fbx.gameObject.GetComponent<Animation> ().Play ("switch_on");
		StartCoroutine ("wait_1");
	}	
	IEnumerator wait_1 ()
	{
		yield return new WaitForSeconds (1f);
		fbx.gameObject.GetComponent<Animation> ().Play ("loop_1");
		cardboard_btn.gameObject.SetActive (true);
	}
	public void cardboard()
	{
		sound_2.gameObject.GetComponent<AudioSource> ().Stop ();
		cardboard_btn.gameObject.SetActive (false);
		fbx.gameObject.GetComponent<Animation> ().Play ("cardboard");
		StartCoroutine ("wait_2");
	}
	IEnumerator wait_2 ()
	{
		yield return new WaitForSeconds (2f);
		fbx.gameObject.GetComponent<Animation> ().Play ("loop_2");
		steelrod_btn.gameObject.SetActive (true);
	}

	public void steel_rod()
	{
		steelrod_btn.gameObject.SetActive (false);
		fbx.gameObject.GetComponent<Animation> ().Play ("steel_rod");
		StartCoroutine ("wait_3");
	}
	IEnumerator wait_3 ()
	{
		yield return new WaitForSeconds (2f);
		fbx.gameObject.GetComponent<Animation> ().Play ("loop_3");
		sound_3.gameObject.GetComponent<AudioSource> ().Play ();
		switch_off_btn.gameObject.SetActive (true);
	}

	public void switch_off()
	{
		sound_3.gameObject.GetComponent<AudioSource> ().Stop ();
		switch_off_btn.gameObject.SetActive (false);
		fbx.gameObject.GetComponent<Animation> ().Play ("switch_off");
		switch_on_btn2.gameObject.SetActive (true);
	}

	public void switch_on_2()
	{
		switch_on_btn2.gameObject.SetActive (false);
		fbx.gameObject.GetComponent<Animation> ().Play ("switch_on2");
		StartCoroutine ("wait_4");
	}
	IEnumerator wait_4 ()
	{
		yield return new WaitForSeconds (1f);
		fbx.gameObject.GetComponent<Animation> ().Play ("loop_3");
		switch_off_btn.gameObject.SetActive (true);
		reset_btn.gameObject.SetActive (true);
	}
	public void reset()
	{
		reset_btn.gameObject.SetActive (false);
		switch_on_btn.gameObject.SetActive (true);
		switch_off_btn.gameObject.SetActive (false);
		fbx.gameObject.GetComponent<Animation> ().Play ("reset");
	}

}

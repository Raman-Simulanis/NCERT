using UnityEngine;
using System.Collections;

public class Animation_script6 : MonoBehaviour 
{

	public GameObject fbx;
	public GameObject sound_2;
	public GameObject sound_3;
	public GameObject switch_on_btn;
	public GameObject switch_on_btn2;
	public GameObject battery_flip_btn;
	public GameObject battery_flip_btn2;
	public GameObject switch_off_btn;
	public GameObject switch_off_btn2;

	// Use this for initialization
	void Start () 
	{
		switch_off_btn.gameObject.SetActive (false);
		battery_flip_btn.gameObject.SetActive (false);
		battery_flip_btn2.gameObject.SetActive (false);
		switch_on_btn2.gameObject.SetActive (false);
		switch_off_btn2.gameObject.SetActive (false);
	}
	

	// Update is called once per frame
	void Update () 
	{
		
	}
	public void switch_on()
	{
		fbx.gameObject.GetComponent<AudioSource> ().Stop ();
		sound_2.gameObject.GetComponent<AudioSource> ().Play ();
		switch_on_btn.gameObject.SetActive (false);
		battery_flip_btn.gameObject.SetActive (false);
		fbx.gameObject.GetComponent<Animation> ().Play ("switch_on");
		StartCoroutine ("wait_1");
	}
	IEnumerator wait_1 ()
	{
		yield return new WaitForSeconds (1f);
		fbx.gameObject.GetComponent<Animation> ().Play ("current_show");

		yield return new WaitForSeconds (2f);
		fbx.gameObject.GetComponent<Animation> ().Play ("loop_1");
		switch_off_btn.gameObject.SetActive (true);
	}

	public void switch_off()
	{
		sound_2.gameObject.GetComponent<AudioSource> ().Stop ();
		switch_off_btn.gameObject.SetActive (false);
		switch_on_btn.gameObject.SetActive (true);
		battery_flip_btn.gameObject.SetActive (true);
		fbx.gameObject.GetComponent<Animation> ().Play ("switch_off");
	}
	public void battery_flip()
	{
		battery_flip_btn.gameObject.SetActive (false);
		switch_off_btn.gameObject.SetActive (false);
		switch_on_btn.gameObject.SetActive (false);
		switch_on_btn2.gameObject.SetActive (true);
		fbx.gameObject.GetComponent<Animation> ().Play ("battery_flip");
	}

	public void switch_on2()
	{
		sound_3.gameObject.GetComponent<AudioSource> ().Play ();
		switch_on_btn2.gameObject.SetActive (false);
		battery_flip_btn2.gameObject.SetActive (false);
		fbx.gameObject.GetComponent<Animation> ().Play ("switch_on2");
		StartCoroutine ("wait_2");
	}
	IEnumerator wait_2 ()
	{
		yield return new WaitForSeconds (1f);
		fbx.gameObject.GetComponent<Animation> ().Play ("current_show2");

		yield return new WaitForSeconds (2f);
		fbx.gameObject.GetComponent<Animation> ().Play ("loop_2");
		switch_off_btn2.gameObject.SetActive (true);
	}
	public void battery_flip2()
	{
		battery_flip_btn2.gameObject.SetActive (false);
		switch_on_btn.gameObject.SetActive (true);
		switch_on_btn2.gameObject.SetActive (false);
		fbx.gameObject.GetComponent<Animation> ().Play ("battery_flip2");
	}

	public void switch_off2()
	{
		sound_3.gameObject.GetComponent<AudioSource> ().Stop ();
		switch_off_btn2.gameObject.SetActive (false);
		battery_flip_btn2.gameObject.SetActive (true);
		switch_on_btn2.gameObject.SetActive (true);
		fbx.gameObject.GetComponent<Animation> ().Play ("switch_off2");
	}
}


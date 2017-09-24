using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Animation_script11 : MonoBehaviour 
{
	public GameObject switch_on_btn;
	public GameObject switch_off_btn;
	public GameObject switch_on_btn2;
	public GameObject switch_off_btn2;
	public GameObject battery_flip_btn;
	public GameObject reset_btn;

	public GameObject iron_filling_btn;
	public GameObject paper_sheak_btn;

	public GameObject fbx;

	public GameObject sound_2;
	public GameObject sound_3;
	public GameObject sound_4;


	// Use this for initialization
	void Start () 
	{
		switch_off_btn.gameObject.SetActive (false);
		battery_flip_btn.gameObject.SetActive (false);

		switch_on_btn2.gameObject.SetActive (false);
		switch_off_btn2.gameObject.SetActive (false);

		iron_filling_btn.gameObject.SetActive (false);
		paper_sheak_btn.gameObject.SetActive (false);

		reset_btn.gameObject.SetActive (false);
	}
	

	// Update is called once per frame
	void Update () 
	{
		
	}
		
	public void switch_on()
	{
		fbx.gameObject.GetComponent<AudioSource> ().Stop ();
		switch_on_btn.gameObject.SetActive (false);
		battery_flip_btn.gameObject.SetActive (false);
		fbx.gameObject.GetComponent<Animation> ().Play ("switch_on");
		StartCoroutine ("wait_1");
	}
	IEnumerator wait_1 ()
	{
		yield return new WaitForSeconds (1f);
		fbx.gameObject.GetComponent<Animation> ().Play ("loop_1");
		sound_2.gameObject.GetComponent<AudioSource> ().Play();
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
		switch_on_btn.gameObject.SetActive (false);
		switch_on_btn2.gameObject.SetActive (true);
		fbx.gameObject.GetComponent<Animation> ().Play ("battery_flip");
	}

	public void switch_on2()
	{
		switch_on_btn2.gameObject.SetActive (false);
		fbx.gameObject.GetComponent<Animation> ().Play ("switch_on2");
		StartCoroutine ("wait_2");
	}
	IEnumerator wait_2 ()
	{
		yield return new WaitForSeconds (1f);
		fbx.gameObject.GetComponent<Animation> ().Play ("loop_2");
		iron_filling_btn.gameObject.SetActive (true);
		sound_3.gameObject.GetComponent<AudioSource> ().Play();
	}

	public void iron_filling()
	{
		sound_3.gameObject.GetComponent<AudioSource> ().Stop ();
		iron_filling_btn.gameObject.SetActive (false);
		fbx.gameObject.GetComponent<Animation> ().Play ("iron_filling");
		StartCoroutine ("wait_3");
	}
	IEnumerator wait_3 ()
	{
		yield return new WaitForSeconds (3f);
		fbx.gameObject.GetComponent<Animation> ().Play ("loop_3");
		sound_4.gameObject.GetComponent<AudioSource> ().Play();
		paper_sheak_btn.gameObject.SetActive (true);
	}
	public void paper_sheak()
	{
		sound_4.gameObject.GetComponent<AudioSource> ().Stop ();
		paper_sheak_btn.gameObject.SetActive (false);
		fbx.gameObject.GetComponent<Animation> ().Play ("paper_sheak");
		StartCoroutine ("wait_4");
	}
	IEnumerator wait_4 ()
	{
		yield return new WaitForSeconds (2.5f);
		fbx.gameObject.GetComponent<Animation> ().Play ("loop_4");
		switch_off_btn2.gameObject.SetActive (true);
	}

	public void switch_off2()
	{
		fbx.gameObject.GetComponent<Animation> ().Play ("switch_off2");
		switch_off_btn2.gameObject.SetActive (false);
		reset_btn.gameObject.SetActive (true);
	}

	public void reset()
	{
		Application.LoadLevel ("13.9_vr");
	}
}


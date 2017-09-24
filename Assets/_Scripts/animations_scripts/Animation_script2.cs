using UnityEngine;
using System.Collections;

public class Animation_script2 : MonoBehaviour {


	public GameObject fbx;
	public GameObject switch_on_btn;
	public GameObject switch_on_btn2;
	public GameObject switch_off_btn;
	public GameObject switch_off_btn2;
	public GameObject battery_flip_btn;
	public GameObject battery_flip_btn2;

	public GameObject hand_p_1;
	public GameObject hand_p_2;
	public GameObject hand_p_3;
	public GameObject hand_p_4;

	public GameObject sound_2;
	public GameObject sound_3;


	// Use this for initialization
	void Start () 
	{
		battery_flip_btn.gameObject.SetActive (false);
		switch_off_btn.gameObject.SetActive (false);
		switch_off_btn2.gameObject.SetActive (false);
		switch_on_btn2.gameObject.SetActive(false);
		battery_flip_btn2.gameObject.SetActive (false);
		hand_p_1.gameObject.SetActive (false);
		hand_p_2.gameObject.SetActive (false);
		hand_p_3.gameObject.SetActive (false);
		hand_p_4.gameObject.SetActive (false);
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
		hand_p_1.gameObject.SetActive (true);
		hand_p_2.gameObject.SetActive (true);
		fbx.gameObject.GetComponent<Animation> ().Play ("switch_on");
		StartCoroutine ("wait_1");
	}	
	IEnumerator wait_1 ()
	{
		yield return new WaitForSeconds (1f);
		switch_off_btn.gameObject.SetActive (true);
		fbx.gameObject.GetComponent<Animation> ().Play ("loop_1");
		sound_2.gameObject.GetComponent<AudioSource> ().Play ();
		yield return new WaitForSeconds (3f);
		sound_3.gameObject.GetComponent<AudioSource> ().Play ();
	}

	public void switch_off()
	{
		hand_p_1.gameObject.SetActive (false);
		hand_p_2.gameObject.SetActive (false);
		Destroy (sound_3);
		Destroy (sound_2);
		switch_off_btn.gameObject.SetActive (false);
		switch_on_btn.gameObject.SetActive (true);
		battery_flip_btn.gameObject.SetActive (true);
		fbx.gameObject.GetComponent<Animation> ().Play ("switch_off");
	}
	public void battery_flip()
	{
		fbx.gameObject.GetComponent<Animation> ().Play ("battery_flip");
		battery_flip_btn.gameObject.SetActive (false);
		switch_on_btn.gameObject.SetActive (false);	
		switch_on_btn2.gameObject.SetActive (true);
	}

	public void switch_on2()
	{
		hand_p_3.gameObject.SetActive (true);
		hand_p_4.gameObject.SetActive (true);
		switch_on_btn2.gameObject.SetActive (false);
		switch_off_btn2.gameObject.SetActive (true);
		fbx.gameObject.GetComponent<Animation> ().Play ("switch_on2");
		StartCoroutine ("wait_2");
	}
	IEnumerator wait_2 ()
	{
		yield return new WaitForSeconds (1f);
		switch_off_btn2.gameObject.SetActive (true);
		fbx.gameObject.GetComponent<Animation> ().Play ("loop_2");
	}
	public void switch_off2()
	{
		hand_p_3.gameObject.SetActive (false);
		hand_p_4.gameObject.SetActive (false);
		switch_off_btn2.gameObject.SetActive (false);
		switch_on_btn2.gameObject.SetActive (true);
		battery_flip_btn2.gameObject.SetActive (true);
		fbx.gameObject.GetComponent<Animation> ().Play ("switch_off2");
	}

	public void battery_flip2()
	{
		switch_off_btn2.gameObject.SetActive (false);
		switch_on_btn2.gameObject.SetActive (false);
		battery_flip_btn2.gameObject.SetActive (false);
		switch_on_btn.gameObject.SetActive (true);
		fbx.gameObject.GetComponent<Animation> ().Play ("reset");
	}
}

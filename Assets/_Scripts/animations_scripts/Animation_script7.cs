using UnityEngine;
using System.Collections;

public class Animation_script7 : MonoBehaviour 
{

	public GameObject fbx;
	public GameObject hand_1;
	public GameObject hand_2;

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

		hand_1.gameObject.SetActive (false);
		hand_2.gameObject.SetActive (false);
	}
	

	// Update is called once per frame
	void Update () 
	{
		
	}

	public void switch_on()
	{
		fbx.gameObject.GetComponent<AudioSource> ().Stop();
		hand_1.gameObject.SetActive (true);
		switch_on_btn.gameObject.SetActive (false);
		battery_flip_btn.gameObject.SetActive (false);
		fbx.gameObject.GetComponent<Animation> ().Play ("switch_on");
		StartCoroutine ("wait_1");
	}
	IEnumerator wait_1 ()
	{
		yield return new WaitForSeconds (1f);
		fbx.gameObject.GetComponent<Animation> ().Play ("rod_move");

		yield return new WaitForSeconds (1f);
		fbx.gameObject.GetComponent<Animation> ().Play ("loop_1");
		switch_off_btn.gameObject.SetActive (true);
		sound_2.gameObject.GetComponent<AudioSource> ().Play ();
		StartCoroutine ("Audio_3");

	}
	IEnumerator Audio_3()
	{
		yield return new WaitForSeconds (5f);
		sound_3.gameObject.GetComponent<AudioSource> ().Play ();
	}

	public void switch_off()
	{
		Destroy (sound_2);
		Destroy (sound_3);
		hand_1.gameObject.SetActive (false);
		switch_off_btn.gameObject.SetActive (false);
		switch_on_btn.gameObject.SetActive (true);
		battery_flip_btn.gameObject.SetActive (true);
		fbx.gameObject.GetComponent<Animation> ().Play ("switch_off");
		StartCoroutine ("rood_wait_1");
	}
	IEnumerator rood_wait_1 ()
	{
		yield return new WaitForSeconds (1f);
		fbx.gameObject.GetComponent<Animation> ().Play ("rod_loop_2");
	}

	public void battery_flip()
	{
		battery_flip_btn.gameObject.SetActive (false);
		switch_off_btn.gameObject.SetActive (false);
		switch_on_btn.gameObject.SetActive (false);
		switch_on_btn2.gameObject.SetActive (true);
		fbx.gameObject.GetComponent<Animation> ().Play ("battery_flip");
		StartCoroutine ("rood_wait_2");
	}
	IEnumerator rood_wait_2 ()
	{
		yield return new WaitForSeconds (1f);
		fbx.gameObject.GetComponent<Animation> ().Play ("rod_loop_1");
	}
	public void switch_on2()
	{
		hand_2.gameObject.SetActive (true);
		switch_on_btn2.gameObject.SetActive (false);
		battery_flip_btn2.gameObject.SetActive (false);
		fbx.gameObject.GetComponent<Animation> ().Play ("switch_on2");
		StartCoroutine ("wait_2");
	}
	IEnumerator wait_2 ()
	{
		yield return new WaitForSeconds (1f);
		fbx.gameObject.GetComponent<Animation> ().Play ("rod_move2");

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
		StartCoroutine ("rood_wait_3");
	}
	IEnumerator rood_wait_3 ()
	{
		yield return new WaitForSeconds (1f);
		fbx.gameObject.GetComponent<Animation> ().Play ("rod_loop_2");
	}
	public void switch_off2()
	{
		hand_2.gameObject.SetActive (false);
		switch_off_btn2.gameObject.SetActive (false);
		battery_flip_btn2.gameObject.SetActive (true);
		switch_on_btn2.gameObject.SetActive (true);
		fbx.gameObject.GetComponent<Animation> ().Play ("switch_off2");
		StartCoroutine ("rood_wait_4");
	}
	IEnumerator rood_wait_4 ()
	{
		yield return new WaitForSeconds (1f);
		fbx.gameObject.GetComponent<Animation> ().Play ("rod_loop_1");
	}
}


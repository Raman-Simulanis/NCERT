using UnityEngine;
using System.Collections;

public class Animation_script4 : MonoBehaviour {


	public GameObject fbx;
	public GameObject sound_2;
	public GameObject sound_3;
	public GameObject sound_4;

	public GameObject switch_on;
	public GameObject switch_on2;
	public GameObject switch_off;
	public GameObject switch_off2;
	public GameObject battery_flip;
	public GameObject reset;

	public GameObject arrow_1;
	public GameObject arrow_2;
	public GameObject arrow_3;
	public GameObject arrow_4;
	public GameObject arrow_5;
	public GameObject arrow_6;

	// Use this for initialization
	void Start () 
	{
		switch_on2.gameObject.SetActive (false);
		battery_flip.gameObject.SetActive (false);
		switch_off.gameObject.SetActive (false);
		switch_off2.gameObject.SetActive (false);
		reset.gameObject.SetActive (false);

		arrow_1.gameObject.SetActive (false);
		arrow_2.gameObject.SetActive (false);
		arrow_3.gameObject.SetActive (false);
		arrow_4.gameObject.SetActive (false);
		arrow_5.gameObject.SetActive (false);
		arrow_6.gameObject.SetActive (false);
		//sound call
		StartCoroutine ("sound_wait");
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	public void ani_switch_on()
	{
		fbx.gameObject.GetComponent<Animation> ().Play ("switch_on");
		sound_3.gameObject.GetComponent<AudioSource> ().Play ();
		Destroy (arrow_1);
		Destroy (arrow_2);
		Destroy (arrow_3);
		Destroy (arrow_4);
		Destroy (arrow_5);
		Destroy (arrow_6);
		Destroy (sound_2);
		switch_on.gameObject.SetActive (false);
		battery_flip.gameObject.SetActive (false);
		fbx.gameObject.GetComponent<AudioSource>().Stop();
		StartCoroutine ("wait_1");
	}
	IEnumerator wait_1 ()
	{
		yield return new WaitForSeconds (2);
		fbx.gameObject.GetComponent<Animation> ().Play ("loop_1");
		switch_off.gameObject.SetActive (true);
	}

	public void ani_switch_off()
	{
		sound_3.gameObject.GetComponent<AudioSource> ().Stop ();
		switch_off.gameObject.SetActive (false);
		switch_on.gameObject.SetActive (true);
		fbx.gameObject.GetComponent<Animation> ().Play ("switch_off");
		battery_flip.gameObject.SetActive (true);
	}
	public void ani_battery_flip()
	{
		battery_flip.gameObject.SetActive (false);
		switch_on.gameObject.SetActive (false);
		switch_on2.gameObject.SetActive (true);
		fbx.gameObject.GetComponent<Animation> ().Play ("battery_flip");
	}
	public void switch_on2_fun()
	{
		sound_3.gameObject.GetComponent<AudioSource> ().Play ();
		switch_on2.gameObject.SetActive (false);
		reset.gameObject.SetActive (false);
		fbx.gameObject.GetComponent<Animation> ().Play ("switch_on");
		StartCoroutine ("wait_3");
	}

	IEnumerator wait_3 ()
	{
		yield return new WaitForSeconds (2);
		fbx.gameObject.GetComponent<Animation> ().Play ("loop_2");
		switch_off2.gameObject.SetActive (true);
	}

	public void switch_off2_fun()
	{
		switch_on2.gameObject.SetActive (true);
		fbx.gameObject.GetComponent<Animation> ().Play ("switch_off");
		switch_off2.gameObject.SetActive (false);
		reset.gameObject.SetActive (true);
	}

	public void ani_reset()
	{
		reset.gameObject.SetActive (false);
		fbx.gameObject.GetComponent<Animation> ().Play ("reset");
		switch_on.gameObject.SetActive (true);
		switch_on2.gameObject.SetActive (false);
		switch_off2.gameObject.SetActive (false);
	}

	//sound waiting

	IEnumerator sound_wait ()
	{
		yield return new WaitForSeconds (8);
		arrow_1.gameObject.SetActive (true);
		yield return new WaitForSeconds (4);
		arrow_1.gameObject.SetActive (false);
		yield return new WaitForSeconds (1);
		arrow_2.gameObject.SetActive (true);
		yield return new WaitForSeconds (1);
		arrow_2.gameObject.SetActive (false);
		arrow_3.gameObject.SetActive (true);
		yield return new WaitForSeconds (1);
		arrow_3.gameObject.SetActive (false);
		arrow_2.gameObject.SetActive (true);
		yield return new WaitForSeconds (1);
		arrow_2.gameObject.SetActive (false);
		arrow_3.gameObject.SetActive (true);
		yield return new WaitForSeconds (1);
		arrow_3.gameObject.SetActive (false);
		yield return new WaitForSeconds (4);
		arrow_4.gameObject.SetActive (true);
		yield return new WaitForSeconds (2);
		arrow_4.gameObject.SetActive (false);
		yield return new WaitForSeconds (3);
		arrow_5.gameObject.SetActive (true);
		yield return new WaitForSeconds (1);
		arrow_5.gameObject.SetActive (false);
		arrow_6.gameObject.SetActive (true);
		yield return new WaitForSeconds (1);
		arrow_6.gameObject.SetActive (false);
		yield return new WaitForSeconds (1);
		arrow_1.gameObject.SetActive (true);
		yield return new WaitForSeconds (1);
		arrow_1.gameObject.SetActive (false);
		sound_2.gameObject.GetComponent<AudioSource> ().Play ();
	}

}

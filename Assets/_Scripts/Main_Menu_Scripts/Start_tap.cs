using UnityEngine;
using System.Collections;

public class Start_tap : MonoBehaviour {

	public GameObject ElectricGenerator;
	public GameObject start_btn;
	public GameObject slider;

	public GameObject sound_2;
	public GameObject sound_3;
	public GameObject sound_4;


	// Use this for initialization
	void Start () {
	
		slider.gameObject.SetActive (false);
		StartCoroutine ("wait");
	}
	IEnumerator wait ()
	{
		yield return new WaitForSeconds (9);
		sound_2.gameObject.GetComponent<AudioSource> ().Play ();
	}
	// Update is called once per frame
	void Update () {
	
	}
	public void StartTap ()
	{
		sound_3.gameObject.GetComponent<AudioSource> ().Play ();
		Destroy (sound_2);
		ElectricGenerator.gameObject.GetComponent<AudioSource> ().Stop ();
		StartCoroutine("startAnim");
	//	ElectricGenerator.gameObject.GetComponent<Animation> ().Play ("Start");
	}

	IEnumerator startAnim ()
	{
		ElectricGenerator.gameObject.GetComponent<Animation> ().Play ("start");
		start_btn.gameObject.SetActive (false);
		slider.gameObject.SetActive (true);
		yield return new WaitForSeconds (0.35f);
		ElectricGenerator.gameObject.GetComponent<Animation> ().Play ("loop_1");
		yield return new WaitForSeconds (21.5f);
		sound_4.gameObject.GetComponent<AudioSource> ().Play ();
	}
}

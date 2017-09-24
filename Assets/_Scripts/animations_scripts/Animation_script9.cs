using UnityEngine;
using System.Collections;
using Vuforia;
public class Animation_script9 : MonoBehaviour 
{

	public GameObject fbx;
	public GameObject glass;
	public GameObject transparent_btn;
	public GameObject iron_filing_btn;
	public GameObject reset_btn;
	public GameObject arrow;
	public GameObject tap_btn;

	public GameObject sound_2;
	public GameObject sound_3;
	public GameObject sound_4;



	// Use this for initialization
	void Start () 
	{
		arrow.gameObject.SetActive (false);
		tap_btn.gameObject.SetActive (false);
		iron_filing_btn.gameObject.SetActive (false);
		reset_btn.gameObject.SetActive (false);
	}
	

	// Update is called once per frame
	void Update () 
	{
		
	}

	public void transparent_sheet()
	{
		fbx.gameObject.GetComponent<AudioSource> ().Stop ();
		sound_2.gameObject.GetComponent<AudioSource> ().Play ();
		glass.gameObject.SetActive (true);
		transparent_btn.gameObject.SetActive (false);
		iron_filing_btn.gameObject.SetActive (true);
		fbx.gameObject.GetComponent<Animation> ().Play ("paper_in");

	}
	public void iron_filing_fun ()
	{
		sound_2.gameObject.GetComponent<AudioSource> ().Stop ();
		iron_filing_btn.gameObject.SetActive (false);
		fbx.gameObject.GetComponent<Animation> ().Play ("iron");
		StartCoroutine ("wait_1");
	}
	IEnumerator wait_1 ()
	{
		yield return new WaitForSeconds (10.5f);
		sound_3.gameObject.GetComponent<AudioSource> ().Play ();
		glass.gameObject.SetActive (false);
		yield return new WaitForSeconds (1f);
		arrow.gameObject.SetActive (true);
		tap_btn.gameObject.SetActive (true);
	}

	public void tap_btn_fun()
	{
		fbx.gameObject.GetComponent<AudioSource> ().Stop ();
		sound_3.gameObject.GetComponent<AudioSource> ().Stop ();
		sound_4.gameObject.GetComponent<AudioSource> ().Play ();
		arrow.gameObject.SetActive (false);
		tap_btn.gameObject.SetActive (false);
		fbx.gameObject.GetComponent<Animation> ().Play ("last");
		StartCoroutine ("wait_2");
	}
	IEnumerator wait_2 ()
	{
		yield return new WaitForSeconds (1f);
		reset_btn.gameObject.SetActive (true);
	}

	public void reset_fun()
	{
		Application.LoadLevel ("13.2_vr");
	}

}


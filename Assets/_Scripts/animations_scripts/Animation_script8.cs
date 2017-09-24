using UnityEngine;
using System.Collections;

public class Animation_script8 : MonoBehaviour 
{



	public GameObject fbx;
	public GameObject fbx2;
	public GameObject glow_bulb;
	public GameObject switch_on_btn;
	public GameObject switch_on_btn2;
	public GameObject switch_off_btn;
	public GameObject switch_off_btn2;

	// Use this for initialization
	void Start () 
	{
		switch_off_btn.gameObject.SetActive (false);
		switch_off_btn2.gameObject.SetActive (false);
		glow_bulb.gameObject.SetActive (false);
	}
	

	// Update is called once per frame
	void Update () 
	{
		
	}

	public void switch_on()
	{
		switch_on_btn.gameObject.SetActive (false);
		switch_off_btn.gameObject.SetActive (true);
		fbx.gameObject.GetComponent<Animation> ().Play ("switch_on_fan");
		StartCoroutine ("wait_1");
	}

	IEnumerator wait_1 ()
	{
		yield return new WaitForSeconds (0.5f);
		fbx.gameObject.GetComponent<Animation> ().Play ("fan_loop_1");
	}

	public void switch_off()
	{
		switch_off_btn.gameObject.SetActive (false);
		switch_on_btn.gameObject.SetActive (true);
		fbx.gameObject.GetComponent<Animation> ().Play ("switch_off_fan");
	}

	public void switch_on2()
	{
		switch_on_btn2.gameObject.SetActive (false);
		glow_bulb.gameObject.SetActive (true);
		switch_off_btn2.gameObject.SetActive (true);
		fbx2.gameObject.GetComponent<Animation> ().Play ("switch_on");
	}
	public void switch_off2()
	{
		switch_on_btn2.gameObject.SetActive (true);
		glow_bulb.gameObject.SetActive (false);
		switch_off_btn2.gameObject.SetActive (false);
		fbx2.gameObject.GetComponent<Animation> ().Play ("switch_off");
	}
}


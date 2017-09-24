using UnityEngine;
using System.Collections;

public class Animation_script3 : MonoBehaviour {


	public GameObject fbx;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
		
	public void start_current()
	{
		fbx.gameObject.GetComponent<Animation> ().Play ("start_current");
		fbx.gameObject.GetComponent<AudioSource> ().Play ();
		StartCoroutine ("wait_1");
	}
	IEnumerator wait_1 ()
	{
		yield return new WaitForSeconds (6.0f);
		fbx.gameObject.GetComponent<Animation> ().Play ("loop_1");
	}
}

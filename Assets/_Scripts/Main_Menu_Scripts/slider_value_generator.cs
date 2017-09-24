using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class slider_value_generator : MonoBehaviour {

	public Slider sliderChange;
	public GameObject Fbx; 

	public GameObject sound_3;
	public GameObject sound_4;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void sliderchange ()
	{
		if (sliderChange.value == 1) 
		{
			sound_3.gameObject.GetComponent<AudioSource> ().Stop ();
			Destroy (sound_4);
			Fbx.gameObject.GetComponent<Animation> ().Play ("loop_2");
			//StartCoroutine ("SliderFirst");
		} else if (sliderChange.value == 2) {
			Fbx.gameObject.GetComponent<Animation> ().Play ("loop_3");
		} else if (sliderChange.value == 3) {
			Fbx.gameObject.GetComponent<Animation> ().Play ("loop_4");
		}

	}


}

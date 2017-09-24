using UnityEngine;
using System.Collections;

public class update_rotate : MonoBehaviour {
    public GameObject BarMagnet;
    private float speed = 80f;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        BarMagnet.transform.Rotate(Vector3.left, speed * Time.deltaTime);
    }
}

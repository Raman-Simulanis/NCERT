using UnityEngine;
using System.Collections;

public class Negative_rotate_update : MonoBehaviour {

    public GameObject BarMagnet;
    private float speed = 80f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        BarMagnet.transform.Rotate(-Vector3.left, speed * Time.deltaTime);
    }
}

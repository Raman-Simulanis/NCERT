using UnityEngine;

// This script will rotate and scale the GameObject based on finger gestures
public class simple_rotate_limit: MonoBehaviour
{
	public GameObject fbx;

	protected virtual void LateUpdate()
	{
		
		// This will rotate the current transform based on a multi finger twist gesture
		Lean.LeanTouch.RotateObject(transform, Lean.LeanTouch.TwistDegrees);

		if (fbx.GetComponent<Transform> ().localScale.x > 10) {
			fbx.gameObject.transform.localScale = new Vector3 (10f, 10f, 10f);
		}
		else if(fbx.GetComponent<Transform> ().localScale.x < 2)
		{
			fbx.gameObject.transform.localScale = new Vector3 (2.0f, 2.0f, 2.0f);
		}

	}
}
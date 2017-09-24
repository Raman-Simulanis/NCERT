using UnityEngine;
using System.Collections;
using Vuforia;

public class AutoFocus : MonoBehaviour {
	
	// Contains the currently set auto focus mode.
	public CameraDevice.FocusMode mFocusMode = CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO;
	
	void Update() {
		CameraDevice.Instance.SetFocusMode(mFocusMode);
	}
}
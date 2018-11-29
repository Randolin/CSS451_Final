using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour {

	public Environment Environment;

	public bool Controller = true;
	public bool PS4 = false;

	void Update() {
		if (Controller) {
			ControllerInputCheck();
		}
		KeyboardInputCheck();
	}

	///////////////////////////////////////////////////////////////////////////
	// Controller Input Detection
	///////////////////////////////////////////////////////////////////////////
	void ControllerInputCheck() {

		if (PS4) {
			// Right U/D Axis
			if (Input.GetAxis("PS4RightVertical") != 0) {
				RightUDAxis(Input.GetAxis("PS4RightVertical"));
			}

			// Right L/R Axis
			if (Input.GetAxis("PS4RightHorizontal") != 0) {
				RightLRAxis(Input.GetAxis("PS4RightHorizontal"));
			}

			// Left U/D Axis
			if (Input.GetAxis("ControllerLeftVertical") != 0) {
				LeftUDAxis(Input.GetAxis("ControllerLeftVertical"));
			}

			// Left L/R Axis
			if (Input.GetAxis("ControllerLeftHorizontal") != 0) {
				LeftLRAxis(Input.GetAxis("ControllerLeftHorizontal"));
			}

			// Right Trigger Axis
			if ((Input.GetAxis("PS4RightTrigger") + 1) != 0) {
				RightTriggerAxis((Input.GetAxis("PS4RightTrigger") + 1) / 2);
			}

			// Left Trigger Axis
			if ((Input.GetAxis("PS4LeftTrigger") + 1) != 0) {
				LeftTriggerAxis((Input.GetAxis("PS4LeftTrigger") + 1) / 2);
			}
		} else {
			// Right U/D Axis
			if (Input.GetAxis("XBoxRightVertical") != 0) {
				RightUDAxis(Input.GetAxis("XBoxRightVertical"));
			}

			// Right L/R Axis
			if (Input.GetAxis("XBoxRightHorizontal") != 0) {
				RightLRAxis(Input.GetAxis("XBoxRightHorizontal"));
			}

			// Left U/D Axis
			if (Input.GetAxis("ControllerLeftVertical") != 0) {
				LeftUDAxis(Input.GetAxis("ControllerLeftVertical"));
			}

			// Left L/R Axis
			if (Input.GetAxis("ControllerLeftHorizontal") != 0) {
				LeftLRAxis(Input.GetAxis("ControllerLeftHorizontal"));
			}

			// Right Trigger Axis
			if (Input.GetAxis("XBoxRightTrigger") != 0) {
				RightTriggerAxis(Input.GetAxis("XBoxRightTrigger"));
			}

			// Left Trigger Axis
			if (Input.GetAxis("XBoxLeftTrigger") != 0) {
				LeftTriggerAxis(Input.GetAxis("XBoxLeftTrigger"));
			}
		}

	}

	///////////////////////////////////////////////////////////////////////////
	// Keyboard Input Detection
	///////////////////////////////////////////////////////////////////////////
	void KeyboardInputCheck() {

		// Right U/D Axis
		if (Input.GetKey(KeyCode.UpArrow)) {
			RightUDAxis(1f);
		} else if (Input.GetKey(KeyCode.DownArrow)) {
			RightUDAxis(-1f);
		}

		// Right L/R Axis
		if (Input.GetKey(KeyCode.RightArrow)) {
			RightLRAxis(1f);
		} else if (Input.GetKey(KeyCode.LeftArrow)) {
			RightLRAxis(-1f);
		}

		// Left U/D Axis
		if (Input.GetKey(KeyCode.W)) {
			LeftUDAxis(1f);
		} else if (Input.GetKey(KeyCode.S)) {
			LeftUDAxis(-1f);
		}

		// Left L/R Axis
		if (Input.GetKey(KeyCode.D)) {
			LeftLRAxis(1f);
		} else if (Input.GetKey(KeyCode.A)) {
			LeftLRAxis(-1f);
		}

		// Right Trigger Axis
		if (Input.GetKey(KeyCode.E)) {
			RightTriggerAxis(1f);
		}

		// Left Trigger Axis
		if (Input.GetKey(KeyCode.Q)) {
			LeftTriggerAxis(1f);
		}

	}

	///////////////////////////////////////////////////////////////////////////
	// Axis Output Methods
	///////////////////////////////////////////////////////////////////////////
	void RightUDAxis(float value) {
		// Debug.Log("InputController.cs | RightUDAxis: " + value);
		Environment.RotateLeaf(value);
	}

	void RightLRAxis(float value) {
		// Debug.Log("InputController.cs | RightLRAxis: " + value);
		Environment.TranslateLeaf(value);
	}

	void LeftUDAxis(float value) {
		// Debug.Log("InputController.cs | LeftUDAxis: " + value);
		Environment.TranslateParent(value);
	}

	void LeftLRAxis(float value) {
		// Debug.Log("InputController.cs | LeftLRAxis: " + value);
		Environment.RotateGrandparent(value);
	}

	void RightTriggerAxis(float value) {
		// Debug.Log("InputController.cs | RightTriggerAxis: " + value);
		Environment.Attract(value);
	}

	void LeftTriggerAxis(float value) {
		// Debug.Log("InputController.cs | LeftTriggerAxis: " + value);
		Environment.Repel(value);
	}

}

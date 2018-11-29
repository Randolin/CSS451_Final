using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class VRInputController : MonoBehaviour {

	public VRTK_ControllerEvents leftCtrl;
	public VRTK_ControllerEvents rightCtrl;

	private void OnEnable()
	{
		// Setup Left Controller Event Listeners
		///////////////////////////////////////////////////////////////////////
		leftCtrl.TriggerPressed += DoLeftTriggerPressed;
		leftCtrl.TriggerReleased += DoLeftTriggerReleased;
		leftCtrl.TriggerTouchStart += DoLeftTriggerTouchStart;
		leftCtrl.TriggerTouchEnd += DoLeftTriggerTouchEnd;
		leftCtrl.TriggerHairlineStart += DoLeftTriggerHairlineStart;
		leftCtrl.TriggerHairlineEnd += DoLeftTriggerHairlineEnd;
		leftCtrl.TriggerClicked += DoLeftTriggerClicked;
		leftCtrl.TriggerUnclicked += DoLeftTriggerUnclicked;
		leftCtrl.TriggerAxisChanged += DoLeftTriggerAxisChanged;
		leftCtrl.TriggerSenseAxisChanged += DoLeftTriggerSenseAxisChanged;

		leftCtrl.GripPressed += DoLeftGripPressed;
		leftCtrl.GripReleased += DoLeftGripReleased;
		leftCtrl.GripTouchStart += DoLeftGripTouchStart;
		leftCtrl.GripTouchEnd += DoLeftGripTouchEnd;
		leftCtrl.GripHairlineStart += DoLeftGripHairlineStart;
		leftCtrl.GripHairlineEnd += DoLeftGripHairlineEnd;
		leftCtrl.GripClicked += DoLeftGripClicked;
		leftCtrl.GripUnclicked += DoLeftGripUnclicked;
		leftCtrl.GripAxisChanged += DoLeftGripAxisChanged;

		leftCtrl.TouchpadPressed += DoLeftTouchpadPressed;
		leftCtrl.TouchpadReleased += DoLeftTouchpadReleased;
		leftCtrl.TouchpadTouchStart += DoLeftTouchpadTouchStart;
		leftCtrl.TouchpadTouchEnd += DoLeftTouchpadTouchEnd;
		leftCtrl.TouchpadAxisChanged += DoLeftTouchpadAxisChanged;
		leftCtrl.TouchpadTwoPressed += DoLeftTouchpadTwoPressed;
		leftCtrl.TouchpadTwoReleased += DoLeftTouchpadTwoReleased;
		leftCtrl.TouchpadTwoTouchStart += DoLeftTouchpadTwoTouchStart;
		leftCtrl.TouchpadTwoTouchEnd += DoLeftTouchpadTwoTouchEnd;
		leftCtrl.TouchpadTwoAxisChanged += DoLeftTouchpadTwoAxisChanged;
		leftCtrl.TouchpadSenseAxisChanged += DoLeftTouchpadSenseAxisChanged;

		leftCtrl.ButtonOnePressed += DoLeftButtonOnePressed;
		leftCtrl.ButtonOneReleased += DoLeftButtonOneReleased;
		leftCtrl.ButtonOneTouchStart += DoLeftButtonOneTouchStart;
		leftCtrl.ButtonOneTouchEnd += DoLeftButtonOneTouchEnd;

		leftCtrl.ButtonTwoPressed += DoLeftButtonTwoPressed;
		leftCtrl.ButtonTwoReleased += DoLeftButtonTwoReleased;
		leftCtrl.ButtonTwoTouchStart += DoLeftButtonTwoTouchStart;
		leftCtrl.ButtonTwoTouchEnd += DoLeftButtonTwoTouchEnd;

		leftCtrl.StartMenuPressed += DoLeftStartMenuPressed;
		leftCtrl.StartMenuReleased += DoLeftStartMenuReleased;

		leftCtrl.ControllerEnabled += DoLeftControllerEnabled;
		leftCtrl.ControllerDisabled += DoLeftControllerDisabled;
		leftCtrl.ControllerIndexChanged += DoLeftControllerIndexChanged;

		leftCtrl.MiddleFingerSenseAxisChanged += DoLeftMiddleFingerSenseAxisChanged;
		leftCtrl.RingFingerSenseAxisChanged += DoLeftRingFingerSenseAxisChanged;
		leftCtrl.PinkyFingerSenseAxisChanged += DoLeftPinkyFingerSenseAxisChanged;

		// Setup Right Controller Event Listeners
		///////////////////////////////////////////////////////////////////////
		rightCtrl.TriggerPressed += DoRightTriggerPressed;
		rightCtrl.TriggerReleased += DoRightTriggerReleased;
		rightCtrl.TriggerTouchStart += DoRightTriggerTouchStart;
		rightCtrl.TriggerTouchEnd += DoRightTriggerTouchEnd;
		rightCtrl.TriggerHairlineStart += DoRightTriggerHairlineStart;
		rightCtrl.TriggerHairlineEnd += DoRightTriggerHairlineEnd;
		rightCtrl.TriggerClicked += DoRightTriggerClicked;
		rightCtrl.TriggerUnclicked += DoRightTriggerUnclicked;
		rightCtrl.TriggerAxisChanged += DoRightTriggerAxisChanged;
		rightCtrl.TriggerSenseAxisChanged += DoRightTriggerSenseAxisChanged;

		rightCtrl.GripPressed += DoRightGripPressed;
		rightCtrl.GripReleased += DoRightGripReleased;
		rightCtrl.GripTouchStart += DoRightGripTouchStart;
		rightCtrl.GripTouchEnd += DoRightGripTouchEnd;
		rightCtrl.GripHairlineStart += DoRightGripHairlineStart;
		rightCtrl.GripHairlineEnd += DoRightGripHairlineEnd;
		rightCtrl.GripClicked += DoRightGripClicked;
		rightCtrl.GripUnclicked += DoRightGripUnclicked;
		rightCtrl.GripAxisChanged += DoRightGripAxisChanged;

		rightCtrl.TouchpadPressed += DoRightTouchpadPressed;
		rightCtrl.TouchpadReleased += DoRightTouchpadReleased;
		rightCtrl.TouchpadTouchStart += DoRightTouchpadTouchStart;
		rightCtrl.TouchpadTouchEnd += DoRightTouchpadTouchEnd;
		rightCtrl.TouchpadAxisChanged += DoRightTouchpadAxisChanged;
		rightCtrl.TouchpadTwoPressed += DoRightTouchpadTwoPressed;
		rightCtrl.TouchpadTwoReleased += DoRightTouchpadTwoReleased;
		rightCtrl.TouchpadTwoTouchStart += DoRightTouchpadTwoTouchStart;
		rightCtrl.TouchpadTwoTouchEnd += DoRightTouchpadTwoTouchEnd;
		rightCtrl.TouchpadTwoAxisChanged += DoRightTouchpadTwoAxisChanged;
		rightCtrl.TouchpadSenseAxisChanged += DoRightTouchpadSenseAxisChanged;

		rightCtrl.ButtonOnePressed += DoRightButtonOnePressed;
		rightCtrl.ButtonOneReleased += DoRightButtonOneReleased;
		rightCtrl.ButtonOneTouchStart += DoRightButtonOneTouchStart;
		rightCtrl.ButtonOneTouchEnd += DoRightButtonOneTouchEnd;

		rightCtrl.ButtonTwoPressed += DoRightButtonTwoPressed;
		rightCtrl.ButtonTwoReleased += DoRightButtonTwoReleased;
		rightCtrl.ButtonTwoTouchStart += DoRightButtonTwoTouchStart;
		rightCtrl.ButtonTwoTouchEnd += DoRightButtonTwoTouchEnd;

		rightCtrl.StartMenuPressed += DoRightStartMenuPressed;
		rightCtrl.StartMenuReleased += DoRightStartMenuReleased;

		rightCtrl.ControllerEnabled += DoRightControllerEnabled;
		rightCtrl.ControllerDisabled += DoRightControllerDisabled;
		rightCtrl.ControllerIndexChanged += DoRightControllerIndexChanged;

		rightCtrl.MiddleFingerSenseAxisChanged += DoRightMiddleFingerSenseAxisChanged;
		rightCtrl.RingFingerSenseAxisChanged += DoRightRingFingerSenseAxisChanged;
		rightCtrl.PinkyFingerSenseAxisChanged += DoRightPinkyFingerSenseAxisChanged;
	}

	private void OnDisable()
	{
		if (leftCtrl != null)
		{
			leftCtrl.TriggerPressed -= DoLeftTriggerPressed;
			leftCtrl.TriggerReleased -= DoLeftTriggerReleased;
			leftCtrl.TriggerTouchStart -= DoLeftTriggerTouchStart;
			leftCtrl.TriggerTouchEnd -= DoLeftTriggerTouchEnd;
			leftCtrl.TriggerHairlineStart -= DoLeftTriggerHairlineStart;
			leftCtrl.TriggerHairlineEnd -= DoLeftTriggerHairlineEnd;
			leftCtrl.TriggerClicked -= DoLeftTriggerClicked;
			leftCtrl.TriggerUnclicked -= DoLeftTriggerUnclicked;
			leftCtrl.TriggerAxisChanged -= DoLeftTriggerAxisChanged;
			leftCtrl.TriggerSenseAxisChanged -= DoLeftTriggerSenseAxisChanged;

			leftCtrl.GripPressed -= DoLeftGripPressed;
			leftCtrl.GripReleased -= DoLeftGripReleased;
			leftCtrl.GripTouchStart -= DoLeftGripTouchStart;
			leftCtrl.GripTouchEnd -= DoLeftGripTouchEnd;
			leftCtrl.GripHairlineStart -= DoLeftGripHairlineStart;
			leftCtrl.GripHairlineEnd -= DoLeftGripHairlineEnd;
			leftCtrl.GripClicked -= DoLeftGripClicked;
			leftCtrl.GripUnclicked -= DoLeftGripUnclicked;
			leftCtrl.GripAxisChanged -= DoLeftGripAxisChanged;

			leftCtrl.TouchpadPressed -= DoLeftTouchpadPressed;
			leftCtrl.TouchpadReleased -= DoLeftTouchpadReleased;
			leftCtrl.TouchpadTouchStart -= DoLeftTouchpadTouchStart;
			leftCtrl.TouchpadTouchEnd -= DoLeftTouchpadTouchEnd;
			leftCtrl.TouchpadAxisChanged -= DoLeftTouchpadAxisChanged;
			leftCtrl.TouchpadTwoPressed -= DoLeftTouchpadTwoPressed;
			leftCtrl.TouchpadTwoReleased -= DoLeftTouchpadTwoReleased;
			leftCtrl.TouchpadTwoTouchStart -= DoLeftTouchpadTwoTouchStart;
			leftCtrl.TouchpadTwoTouchEnd -= DoLeftTouchpadTwoTouchEnd;
			leftCtrl.TouchpadTwoAxisChanged -= DoLeftTouchpadTwoAxisChanged;
			leftCtrl.TouchpadSenseAxisChanged -= DoLeftTouchpadSenseAxisChanged;

			leftCtrl.ButtonOnePressed -= DoLeftButtonOnePressed;
			leftCtrl.ButtonOneReleased -= DoLeftButtonOneReleased;
			leftCtrl.ButtonOneTouchStart -= DoLeftButtonOneTouchStart;
			leftCtrl.ButtonOneTouchEnd -= DoLeftButtonOneTouchEnd;

			leftCtrl.ButtonTwoPressed -= DoLeftButtonTwoPressed;
			leftCtrl.ButtonTwoReleased -= DoLeftButtonTwoReleased;
			leftCtrl.ButtonTwoTouchStart -= DoLeftButtonTwoTouchStart;
			leftCtrl.ButtonTwoTouchEnd -= DoLeftButtonTwoTouchEnd;

			leftCtrl.StartMenuPressed -= DoLeftStartMenuPressed;
			leftCtrl.StartMenuReleased -= DoLeftStartMenuReleased;

			leftCtrl.ControllerEnabled -= DoLeftControllerEnabled;
			leftCtrl.ControllerDisabled -= DoLeftControllerDisabled;
			leftCtrl.ControllerIndexChanged -= DoLeftControllerIndexChanged;

			leftCtrl.MiddleFingerSenseAxisChanged -= DoLeftMiddleFingerSenseAxisChanged;
			leftCtrl.RingFingerSenseAxisChanged -= DoLeftRingFingerSenseAxisChanged;
			leftCtrl.PinkyFingerSenseAxisChanged -= DoLeftPinkyFingerSenseAxisChanged;
		}

		if (rightCtrl != null)
		{
			rightCtrl.TriggerPressed -= DoRightTriggerPressed;
			rightCtrl.TriggerReleased -= DoRightTriggerReleased;
			rightCtrl.TriggerTouchStart -= DoRightTriggerTouchStart;
			rightCtrl.TriggerTouchEnd -= DoRightTriggerTouchEnd;
			rightCtrl.TriggerHairlineStart -= DoRightTriggerHairlineStart;
			rightCtrl.TriggerHairlineEnd -= DoRightTriggerHairlineEnd;
			rightCtrl.TriggerClicked -= DoRightTriggerClicked;
			rightCtrl.TriggerUnclicked -= DoRightTriggerUnclicked;
			rightCtrl.TriggerAxisChanged -= DoRightTriggerAxisChanged;
			rightCtrl.TriggerSenseAxisChanged -= DoRightTriggerSenseAxisChanged;

			rightCtrl.GripPressed -= DoRightGripPressed;
			rightCtrl.GripReleased -= DoRightGripReleased;
			rightCtrl.GripTouchStart -= DoRightGripTouchStart;
			rightCtrl.GripTouchEnd -= DoRightGripTouchEnd;
			rightCtrl.GripHairlineStart -= DoRightGripHairlineStart;
			rightCtrl.GripHairlineEnd -= DoRightGripHairlineEnd;
			rightCtrl.GripClicked -= DoRightGripClicked;
			rightCtrl.GripUnclicked -= DoRightGripUnclicked;
			rightCtrl.GripAxisChanged -= DoRightGripAxisChanged;

			rightCtrl.TouchpadPressed -= DoRightTouchpadPressed;
			rightCtrl.TouchpadReleased -= DoRightTouchpadReleased;
			rightCtrl.TouchpadTouchStart -= DoRightTouchpadTouchStart;
			rightCtrl.TouchpadTouchEnd -= DoRightTouchpadTouchEnd;
			rightCtrl.TouchpadAxisChanged -= DoRightTouchpadAxisChanged;
			rightCtrl.TouchpadTwoPressed -= DoRightTouchpadTwoPressed;
			rightCtrl.TouchpadTwoReleased -= DoRightTouchpadTwoReleased;
			rightCtrl.TouchpadTwoTouchStart -= DoRightTouchpadTwoTouchStart;
			rightCtrl.TouchpadTwoTouchEnd -= DoRightTouchpadTwoTouchEnd;
			rightCtrl.TouchpadTwoAxisChanged -= DoRightTouchpadTwoAxisChanged;
			rightCtrl.TouchpadSenseAxisChanged -= DoRightTouchpadSenseAxisChanged;

			rightCtrl.ButtonOnePressed -= DoRightButtonOnePressed;
			rightCtrl.ButtonOneReleased -= DoRightButtonOneReleased;
			rightCtrl.ButtonOneTouchStart -= DoRightButtonOneTouchStart;
			rightCtrl.ButtonOneTouchEnd -= DoRightButtonOneTouchEnd;

			rightCtrl.ButtonTwoPressed -= DoRightButtonTwoPressed;
			rightCtrl.ButtonTwoReleased -= DoRightButtonTwoReleased;
			rightCtrl.ButtonTwoTouchStart -= DoRightButtonTwoTouchStart;
			rightCtrl.ButtonTwoTouchEnd -= DoRightButtonTwoTouchEnd;

			rightCtrl.StartMenuPressed -= DoRightStartMenuPressed;
			rightCtrl.StartMenuReleased -= DoRightStartMenuReleased;

			rightCtrl.ControllerEnabled -= DoRightControllerEnabled;
			rightCtrl.ControllerDisabled -= DoRightControllerDisabled;
			rightCtrl.ControllerIndexChanged -= DoRightControllerIndexChanged;

			rightCtrl.MiddleFingerSenseAxisChanged -= DoRightMiddleFingerSenseAxisChanged;
			rightCtrl.RingFingerSenseAxisChanged -= DoRightRingFingerSenseAxisChanged;
			rightCtrl.PinkyFingerSenseAxisChanged -= DoRightPinkyFingerSenseAxisChanged;
		}
	}

	private void DoLeftTriggerPressed(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoLeftTriggerReleased(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoLeftTriggerTouchStart(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoLeftTriggerTouchEnd(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoLeftTriggerHairlineStart(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoLeftTriggerHairlineEnd(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoLeftTriggerClicked(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoLeftTriggerUnclicked(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoLeftTriggerAxisChanged(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoLeftTriggerSenseAxisChanged(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoLeftGripPressed(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoLeftGripReleased(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoLeftGripTouchStart(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoLeftGripTouchEnd(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoLeftGripHairlineStart(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoLeftGripHairlineEnd(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoLeftGripClicked(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoLeftGripUnclicked(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoLeftGripAxisChanged(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoLeftTouchpadPressed(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoLeftTouchpadReleased(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoLeftTouchpadTouchStart(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoLeftTouchpadTouchEnd(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoLeftTouchpadAxisChanged(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoLeftTouchpadTwoPressed(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoLeftTouchpadTwoReleased(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoLeftTouchpadTwoTouchStart(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoLeftTouchpadTwoTouchEnd(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoLeftTouchpadTwoAxisChanged(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoLeftTouchpadSenseAxisChanged(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoLeftButtonOnePressed(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoLeftButtonOneReleased(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoLeftButtonOneTouchStart(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoLeftButtonOneTouchEnd(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoLeftButtonTwoPressed(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoLeftButtonTwoReleased(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoLeftButtonTwoTouchStart(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoLeftButtonTwoTouchEnd(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoLeftStartMenuPressed(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoLeftStartMenuReleased(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoLeftControllerEnabled(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoLeftControllerDisabled(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoLeftControllerIndexChanged(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoLeftMiddleFingerSenseAxisChanged(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoLeftRingFingerSenseAxisChanged(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoLeftPinkyFingerSenseAxisChanged(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoRightTriggerPressed(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoRightTriggerReleased(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoRightTriggerTouchStart(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoRightTriggerTouchEnd(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoRightTriggerHairlineStart(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoRightTriggerHairlineEnd(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoRightTriggerClicked(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoRightTriggerUnclicked(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoRightTriggerAxisChanged(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoRightTriggerSenseAxisChanged(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoRightGripPressed(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoRightGripReleased(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoRightGripTouchStart(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoRightGripTouchEnd(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoRightGripHairlineStart(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoRightGripHairlineEnd(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoRightGripClicked(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoRightGripUnclicked(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoRightGripAxisChanged(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoRightTouchpadPressed(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoRightTouchpadReleased(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoRightTouchpadTouchStart(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoRightTouchpadTouchEnd(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoRightTouchpadAxisChanged(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoRightTouchpadTwoPressed(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoRightTouchpadTwoReleased(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoRightTouchpadTwoTouchStart(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoRightTouchpadTwoTouchEnd(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoRightTouchpadTwoAxisChanged(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoRightTouchpadSenseAxisChanged(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoRightButtonOnePressed(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoRightButtonOneReleased(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoRightButtonOneTouchStart(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoRightButtonOneTouchEnd(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoRightButtonTwoPressed(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoRightButtonTwoReleased(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoRightButtonTwoTouchStart(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoRightButtonTwoTouchEnd(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoRightStartMenuPressed(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoRightStartMenuReleased(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoRightControllerEnabled(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoRightControllerDisabled(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoRightControllerIndexChanged(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoRightMiddleFingerSenseAxisChanged(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoRightRingFingerSenseAxisChanged(object sender, ControllerInteractionEventArgs e) {

	}

	private void DoRightPinkyFingerSenseAxisChanged(object sender, ControllerInteractionEventArgs e) {

	}

}

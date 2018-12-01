using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using VRTK.Controllables;

// Now we're cooking with enums.
public enum EnvAxis { RotateGrandparent, TranslateParent, TranslateLeaf, RotateLeaf }

public class LeverBehavior : MonoBehaviour {

	public Environment Environment;
	public EnvAxis axis = EnvAxis.RotateGrandparent;
	public VRTK_BaseControllable controllable;
	public Text valueText;

	private bool leverActive = false;
	private float leverValue;

	// Output lever value to Environment if lever is active.
	void Update() {
		if (leverActive && Environment != null) {
			switch(axis) {	// This lever's action depends on the axis selected.
				case EnvAxis.RotateGrandparent:
					Environment.RotateGrandparent(leverValue);
					break;
				case EnvAxis.TranslateParent:
					Environment.TranslateParent(leverValue);
					break;
				case EnvAxis.TranslateLeaf:
					Environment.TranslateLeaf(leverValue);
					break;
				case EnvAxis.RotateLeaf:
					Environment.RotateLeaf(leverValue);
					break;
				default:
					break;
			}
		}
	}

	protected virtual void OnEnable()
	{
		// Set up event callbacks.
		controllable = (controllable == null ? GetComponent<VRTK_BaseControllable>() : controllable);
		controllable.ValueChanged += ValueChanged;
		// controllable.RestingPointReached += RestingPointReached;


		// Might Want These Later
		///////////////////////////////////////////////////////////////////////

		// controllable.MaxLimitReached += MaxLimitReached;
		// controllable.MinLimitReached += MinLimitReached;
	}

	// Any time the lever's value is changed.
	protected virtual void ValueChanged(object sender, ControllableEventArgs e)
	{
		// Update Text on UI Element
		if (valueText != null)
		{
			valueText.text = e.value.ToString("F1");
		}

		// If the lever is outside a deadzone, send value on update.
		if (Math.Abs(e.value) >= 0.2) {
			leverValue = e.value;
			leverActive = true;
		} else {
			leverActive = false;
		}
	}

	// protected virtual void RestingPointReached(object sender, ControllableEventArgs e)
	// {
	// 	leverActive = false;
	// }


	// Might Want These Later
	///////////////////////////////////////////////////////////////////////////

	// protected virtual void MaxLimitReached(object sender, ControllableEventArgs e)
	// {
	// 	if (outputOnMax != "")
	// 	{
	// 		Debug.Log(outputOnMax);
	// 	}
	// }

	// protected virtual void MinLimitReached(object sender, ControllableEventArgs e)
	// {
	// 	if (outputOnMin != "")
	// 	{
	// 		Debug.Log(outputOnMin);
	// 	}
	// }

}

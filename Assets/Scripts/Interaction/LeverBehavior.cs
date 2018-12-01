using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using VRTK.Controllables;

public enum EnvAxis { RotateGrandparent, TranslateParent, TranslateLeaf, RotateLeaf }

public class LeverBehavior : MonoBehaviour {

	public Environment Environment;
	public EnvAxis axis = EnvAxis.RotateGrandparent;
	public VRTK_BaseControllable controllable;
	public Text valueText;

	private bool leverActive = false;
	private float leverValue;

	void Update() {
		if (leverActive && Environment != null) {
			switch(axis) {
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
		controllable = (controllable == null ? GetComponent<VRTK_BaseControllable>() : controllable);
		controllable.ValueChanged += ValueChanged;
		controllable.RestingPointReached += RestingPointReached;

		// controllable.MaxLimitReached += MaxLimitReached;
		// controllable.MinLimitReached += MinLimitReached;
	}

	protected virtual void ValueChanged(object sender, ControllableEventArgs e)
	{
		if (valueText != null)
		{
			valueText.text = e.value.ToString("F1");
		}
		if (Math.Abs(e.value) >= 0.1) {
			leverValue = e.value;
			leverActive = true;
		}
	}

	protected virtual void RestingPointReached(object sender, ControllableEventArgs e)
	{
		leverActive = false;
	}

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

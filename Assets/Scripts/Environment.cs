using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Environment : MonoBehaviour {

	///////////////////////////////////////////////////////////////////////////
	// Control Response Methods
	///////////////////////////////////////////////////////////////////////////

	// Rotates Heirarchy Grandparent with Input [-1 to 1]
	public void RotateGrandparent(float value) {
		Debug.Log("Environment.cs | RotateGrandparent: " + value);
	}

	// Moves Heirarchy Parent In/Out with Input [-1 to 1]
	public void TranslateParent(float value) {
		Debug.Log("Environment.cs | TranslateParent: " + value);
	}

	// Moves Heirarchy Leaf Up/Down with Input [-1 to 1]
	public void TranslateLeaf(float value) {
		Debug.Log("Environment.cs | TranslateLeaf: " + value);
	}

	// Rotates Heirarchy Leaf with Input [-1 to 1]
	public void RotateLeaf(float value) {
		Debug.Log("Environment.cs | RotateLeaf: " + value);
	}

	// Triggers Magnetic Attract with Input [0 to 1]
	public void Attract(float value) {
		Debug.Log("Environment.cs | Attract: " + value);
	}

	// Triggers Magnetic Repel with Input [0 to 1]
	public void Repel(float value) {
		Debug.Log("Environment.cs | Repel: " + value);
	}

}

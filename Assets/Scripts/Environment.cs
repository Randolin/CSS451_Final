// Author(s): Kyla NeSmith
// last edited: Dec. 2, 2018

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Environment : MonoBehaviour {

    public SceneNode RootNode_Crane;
    public SceneNode Cart_Node;
    public SceneNode Claw_Node;
    public float CraneRotateSpeed = .25f;
    public float CartTranslateSpeed = .25f;
    public float ClawTranslateSpeed = .1f;
    public float CartNegLimit = 5;
    public float CartPosLimit = 45;
    public float ClawNegLimit = -15;
    public float ClawPosLimit = -3;

    public MagneticBehavior Magnet;

    void Update()
    {
        Matrix4x4 m = Matrix4x4.identity;
        RootNode_Crane.CompositeXform(ref m);
    }
	///////////////////////////////////////////////////////////////////////////
	// Control Response Methods
	///////////////////////////////////////////////////////////////////////////

	// Rotates Heirarchy Grandparent with Input [-1 to 1]
	public void RotateGrandparent(float value) {
		Debug.Log("Environment.cs | RotateGrandparent: " + value);
        RootNode_Crane.transform.localRotation *= Quaternion.Euler(0, CraneRotateSpeed * value, 0);

    }

	// Moves Heirarchy Parent In/Out with Input [-1 to 1]
	public void TranslateParent(float value) {
		Debug.Log("Environment.cs | TranslateParent: " + value);
        if ((Cart_Node.transform.localPosition.z > CartNegLimit && value < 0) || (Cart_Node.transform.localPosition.z < CartPosLimit && value > 0)){
            Cart_Node.transform.localPosition += new Vector3(0, 0, value * CartTranslateSpeed);
        }

	}

	// Moves Heirarchy Leaf Up/Down with Input [-1 to 1]
	public void TranslateLeaf(float value) {
		Debug.Log("Environment.cs | TranslateLeaf: " + value);
        if ((Claw_Node.transform.localPosition.y > ClawNegLimit && value < 0) || (Claw_Node.transform.localPosition.y < ClawPosLimit && value > 0))
        {
            Claw_Node.transform.localPosition += new Vector3(0, ClawTranslateSpeed * value, 0);
        }
	}

	// Rotates Heirarchy Leaf with Input [-1 to 1]
	public void RotateLeaf(float value) {
		Debug.Log("Environment.cs | RotateLeaf: " + value);
	}

	// Triggers Magnetic Attract with Input [0 to 1]
	public void Attract(float value) {
		Debug.Log("Environment.cs | Attract: " + value);
        Magnet.MagneticPull(value);
	}

	// Triggers Magnetic Repel with Input [0 to 1]
	public void Repel(float value) {
		Debug.Log("Environment.cs | Repel: " + value);
        Magnet.MagneticPush(value);
	}

}

// Author(s): Kyla NeSmith
// last edited: Dec. 2, 2018

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Environment : MonoBehaviour {

    public SceneNode RootNode_Crane;
    public SceneNode Cart_Node;
    public SceneNode Claw_Node;
    public GameObject Claw_Obj;
    public GameObject rope;
    public GameObject CockpitPivot;
    public GameObject floor;
    public float CraneRotateSpeed = .25f;
    public float CartTranslateSpeed = .25f;
    public float ClawTranslateSpeed = .1f;
    public float ClawRotateSpeed = .25f;
    public float CartNegLimit = 5;
    public float CartPosLimit = 45;
    public float ClawNegLimit = -15;
    public float ClawPosLimit = -3;

    GameObject shadow;
    
    public MagneticBehavior Magnet;
    void Start()
    {
        shadow = Instantiate(Resources.Load("shadow")) as GameObject;
    }
    void Update()
    {
        // (Kyla) so can test magnet in separate scene
        if (RootNode_Crane != null)
        {
            Matrix4x4 m = Matrix4x4.identity;
            RootNode_Crane.CompositeXform(ref m);
        }
        CastClawShadow();
        PositionClawObj();
    }
	///////////////////////////////////////////////////////////////////////////
	// Control Response Methods
	///////////////////////////////////////////////////////////////////////////

	// Rotates Heirarchy Grandparent with Input [-1 to 1]
	public void RotateGrandparent(float value) {
		Debug.Log("Environment.cs | RotateGrandparent: " + value);
        RootNode_Crane.transform.localRotation *= Quaternion.AngleAxis(CraneRotateSpeed * value, Vector3.up);
        CockpitPivot.transform.localRotation *= Quaternion.AngleAxis(CraneRotateSpeed * value, Vector3.up);
       
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
        Claw_Node.transform.localRotation *= Quaternion.AngleAxis(ClawRotateSpeed * value, Vector3.up);
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
    void PositionClawObj()
    {
        Claw_Obj.transform.position =  Claw_Node.retPosition();
        Vector3 dist = Cart_Node.retPosition() - Claw_Obj.transform.position;
        rope.transform.position = Claw_Obj.transform.position + dist * .5f;
        Vector3 tempScale = rope.transform.localScale;
        tempScale.y = dist.magnitude * .5f;
        rope.transform.localScale = tempScale;

        Quaternion q = Claw_Node.getRot();

        Claw_Obj.transform.localRotation = q;
    }
    void CastClawShadow()
    {
        Vector3 N = -floor.transform.forward;
        Vector3 P = Claw_Node.retPosition();
        Vector3 O = floor.transform.position;
        Vector3 OP = P - O;
        float d = Vector3.Dot(OP, N);
        Quaternion q = Quaternion.FromToRotation(shadow.transform.forward, N);
        shadow.transform.up = N;
        Vector3 onPlane = P - d * N;
        shadow.transform.position = onPlane + N * .1f;

    }

}

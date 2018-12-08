using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SceneNode : MonoBehaviour {

    protected Matrix4x4 mCombinedParentXform;
    
    public Vector3 NodeOrigin = Vector3.zero;
    public List<NodePrimitive> PrimitiveList;

	// Use this for initialization
	protected void Start () {
        InitializeSceneNode();
        // Debug.Log("PrimitiveList:" + PrimitiveList.Count);
	}
	
	// Update is called once per frame
	void Update () {
	}

    private void InitializeSceneNode()
    {
        mCombinedParentXform = Matrix4x4.identity;
    }

    // This must be called _BEFORE_ each draw!! 
    public void CompositeXform(ref Matrix4x4 parentXform)
    {
        Matrix4x4 orgT = Matrix4x4.Translate(NodeOrigin);
        Matrix4x4 trs = Matrix4x4.TRS(transform.localPosition, transform.localRotation, transform.localScale);
        
        mCombinedParentXform = parentXform * orgT * trs;

        // propagate to all children
        foreach (Transform child in transform)
        {
            SceneNode cn = child.GetComponent<SceneNode>();
            if (cn != null)
            {
                cn.CompositeXform(ref mCombinedParentXform);
            }
        }
        
        // disenminate to primitives
        foreach (NodePrimitive p in PrimitiveList)
        {
            p.LoadShaderMatrix(ref mCombinedParentXform);
        }

    }

    public Vector3 retPosition()
    {
        Matrix4x4 m = PrimitiveList[0].m;
        Vector3 r;
        r.x = m.m03;
        r.y = m.m13;
        r.z = m.m23;
        return r;

    }

    public Quaternion getRot()
    {
        Matrix4x4 myTRS = Matrix4x4.TRS(transform.localPosition, transform.localRotation, transform.localScale);
        //Matrix4x4 concatMatrix = mCombinedParentXform * myTRS;
        Matrix4x4 concatMatrix = PrimitiveList[0].m;
        Vector3 x = concatMatrix.GetColumn(0);
        Vector3 y = concatMatrix.GetColumn(1);
        Vector3 z = concatMatrix.GetColumn(2);
        Vector3 size = new Vector3(x.magnitude, y.magnitude, z.magnitude);
        Quaternion q = Quaternion.LookRotation(z / size.z, y / size.y);
        return q;
    }
}
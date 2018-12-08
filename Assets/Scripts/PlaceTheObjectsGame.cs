// MiniGame by Nicholas Lewis

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceTheObjectsGame : MonoBehaviour {
    public List<GameObject> Items;
    public GameObject target;
    public float radius;
    public float maxVertDist;

    //temp var for testing
    public GameObject win;

	// Use this for initialization
	void Start ()
    {
        win.SetActive(false);

    }
	
	// Update is called once per frame
	void Update () {
        if (GameOver())
        {
            win.SetActive(true);
        }else
        {
            win.SetActive(false);
        }
	}

    bool GameOver()
    {
        bool won = true;
        foreach (GameObject item in Items){
            Vector3 N = target.transform.up;
            Vector3 P = item.transform.localPosition;
            Vector3 O = target.transform.localPosition;
            Vector3 OP = P - O;
            float d = Vector3.Dot(OP, N);
            Vector3 onPlane = P - d * N;

            Vector3 dist = O - onPlane;
            if(dist.magnitude < radius)
            {
                Vector3 vertDist = P - onPlane;
                if (vertDist.magnitude < maxVertDist)
                {

                }
                else
                {
                    won = false;
                }
            }
            else
            {
                won = false;
            }
        }
        return won;
        
    }
}

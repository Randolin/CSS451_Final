using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BayColor { Blue, Red, Yellow, White }

public class BayBehavior : MonoBehaviour {

	public PlaceContainersGameV2 game;
	public BayColor color = BayColor.Blue;

	private void OnTriggerEnter(Collider other)
    {
		if ((other.gameObject.tag == "BlueContainer" && color == BayColor.Blue) ||
			(other.gameObject.tag == "RedContainer" && color == BayColor.Red) ||
			(other.gameObject.tag == "YellowContainer" && color == BayColor.Yellow) ||
			(other.gameObject.tag == "WhiteContainer" && color == BayColor.White)) {
				game.AddContainer(other.gameObject);
			}
    }

    private void OnTriggerExit(Collider other)
    {
		if ((other.gameObject.tag == "BlueContainer" && color == BayColor.Blue) ||
			(other.gameObject.tag == "RedContainer" && color == BayColor.Red) ||
			(other.gameObject.tag == "YellowContainer" && color == BayColor.Yellow) ||
			(other.gameObject.tag == "WhiteContainer" && color == BayColor.White)) {
				game.RemoveContainer(other.gameObject);
			}
    }

}

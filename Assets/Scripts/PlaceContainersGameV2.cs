using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaceContainersGameV2 : MonoBehaviour {

	public Text timerText;
	public Text blueText;
	public Text redText;
	public Text yellowText;
	public Text whiteText;

	private List<GameObject> blueBay = new List<GameObject>();
	private List<GameObject> redBay = new List<GameObject>();
	private List<GameObject> yellowBay = new List<GameObject>();
	private List<GameObject> whiteBay = new List<GameObject>();

	private int blueNum;
	private int redNum;
	private int yellowNum;
	private int whiteNum;

	private bool win = false;
	private float time;

	void Start () {
		blueNum = GameObject.FindGameObjectsWithTag("BlueContainer").Length;
		redNum = GameObject.FindGameObjectsWithTag("RedContainer").Length;
		yellowNum = GameObject.FindGameObjectsWithTag("YellowContainer").Length;
		whiteNum = GameObject.FindGameObjectsWithTag("WhiteContainer").Length;

		UpdateCounts();
	}

	void Update () {
		// Ref: https://answers.unity.com/questions/905990/how-can-i-make-a-timer-with-the-new-ui-system.html
		time += Time.deltaTime;

		var minutes = time / 60;
		var seconds = time % 60;

        timerText.text = string.Format ("{0:00} : {1:00}", minutes, seconds);
	}

	void UpdateCounts() {
		blueText.text = blueBay.Count + "/" + blueNum;
		redText.text = redBay.Count + "/" + redNum;
		yellowText.text = yellowBay.Count + "/" + yellowNum;
		whiteText.text = whiteBay.Count + "/" + whiteNum;

		if (blueBay.Count >= blueNum && redBay.Count >= redNum &&
			yellowBay.Count >= yellowNum && whiteBay.Count >= whiteNum) {
				win = true;
				WinGame();
			}
	}

	void WinGame() {
		// Do Win Game Stuff Here
		Debug.Log("Game Over, Player Wins!");
	}

	public void AddContainer(GameObject container) {
		switch(container.tag) {
			case "BlueContainer":
				if(!blueBay.Contains(container)) {
					blueBay.Add(container);
					Debug.Log("PlaceContainersGameV2 | Added Blue Container to Bay List");
				}
				break;
			case "RedContainer":
				if(!redBay.Contains(container)) {
					redBay.Add(container);
					Debug.Log("PlaceContainersGameV2 | Added Red Container to Bay List");
				}
				break;
			case "YellowContainer":
				if(!yellowBay.Contains(container)) {
					yellowBay.Add(container);
					Debug.Log("PlaceContainersGameV2 | Added Yellow Container to Bay List");
				}
				break;
			case "WhiteContainer":
				if(!whiteBay.Contains(container)) {
					whiteBay.Add(container);
					Debug.Log("PlaceContainersGameV2 | Added White Container to Bay List");
				}
				break;
			default:
				break;
		}

		UpdateCounts();
	}

	public void RemoveContainer(GameObject container) {
		switch(container.tag) {
			case "BlueContainer":
				blueBay.Remove(container);
				Debug.Log("PlaceContainersGameV2 | Removed Blue Container from Bay List");
				break;
			case "RedContainer":
				redBay.Remove(container);
				Debug.Log("PlaceContainersGameV2 | Removed Red Container from Bay List");
				break;
			case "YellowContainer":
				yellowBay.Remove(container);
				Debug.Log("PlaceContainersGameV2 | Removed Yellow Container from Bay List");
				break;
			case "WhiteContainer":
				whiteBay.Remove(container);
				Debug.Log("PlaceContainersGameV2 | Removed White Container from Bay List");
				break;
			default:
				break;
		}

		UpdateCounts();
	}

}

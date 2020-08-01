using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameController : MonoBehaviour {
	
	public static Transform[] boardSquares;
	public Transform[] setBoardSquares;

	public static GameObject player;
	public static GameObject[] chanceCards;
	public GameObject[] setChanceCards;

	public static int boardSquaresIndex = 0;
	public static int playerPosition = 0;
	public static int dieNumber;
	public static bool dieRollAllowed = true;
	public static bool allowPlayerMovement = false;
	public static bool showEventUI = false;
	public static bool showChanceUI = false;
	public static bool showOutcomeUI = false;
	public static bool showTakeLoanUI = false;
	public static bool showWinUI = false;

	public static Chance choosenChance;

	// Use this for initialization
	void Start () {
		boardSquares = setBoardSquares;
		chanceCards = setChanceCards;

		player = GameObject.FindGameObjectWithTag ("Player");
		allowPlayerMovement = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (boardSquaresIndex > playerPosition + dieNumber || (boardSquaresIndex != 0 && boardSquares [boardSquaresIndex - 1].GetComponent<Event> ().isMilestone == true)) {
			allowPlayerMovement = false;
			playerPosition = boardSquaresIndex - 1;

			if (boardSquares [playerPosition].GetComponent<Event> ().isChance == true) {
				choosenChance = chanceCards [Random.Range (0, chanceCards.Length)].GetComponent<Chance> ();
				showChanceUI = true;
				choosenChance.ActivateChance ();
			} else {
				showEventUI = true;
				boardSquares [playerPosition].GetComponent<Event> ().ActivateEvent ();
			}

			// dieRollAllowed = true;
			boardSquares [playerPosition].GetComponent<Event> ().isMilestone = false;
			// Debug.Log ("showChanceUI: " + showChanceUI);
		}

		if (boardSquares.Length == playerPosition + 1) {
			// Debug.Log ("Player Position: " + playerPosition);
			allowPlayerMovement = false;
			showWinUI = true;
		}
	}

	public static void MovePlayer () {
		allowPlayerMovement = true;
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameController : MonoBehaviour {
	
	public static Transform[] boardSquares;
	public Transform[] setBoardSquares;

	public static GameObject player;
	public static GameObject[] chanceCards;
	public GameObject[] setChanceCards;

	public static int boardSquaresIndex;
	public static int playerPosition;
	public static int dieNumber;
	public static bool dieRollAllowed;
	public static bool allowPlayerMovement;
	public static bool showEventUI;
	public static bool showChanceUI;
	public static bool showOutcomeUI;
	public static bool showTakeLoanUI;
	public static bool showWinUI;
	public static bool onMilestoneSqure;

	public static Chance choosenChance;

	void Awake () {
		boardSquaresIndex = 0;
		playerPosition = 0;
		dieRollAllowed = true;
		allowPlayerMovement = false;
		showEventUI = false;
		showChanceUI = false;
		showOutcomeUI = false;
		showTakeLoanUI = false;
		showWinUI = false;
		onMilestoneSqure = false;
	}

	// Use this for initialization
	void Start () {
		boardSquares = setBoardSquares;
		chanceCards = setChanceCards;

		showWinUI = false;

		player = GameObject.FindGameObjectWithTag ("Player");
		allowPlayerMovement = false;
	}
	
	// Update is called once per frame
	void Update () {
		bool milestoneSquare = boardSquares [boardSquaresIndex - 1].GetComponent<Event> ().isMilestone;
		if (boardSquaresIndex > playerPosition + dieNumber || (boardSquaresIndex != 0 && milestoneSquare == true)) {
			allowPlayerMovement = false;
			playerPosition = boardSquaresIndex - 1;

			if (boardSquares [playerPosition].GetComponent<Event> ().isChance == true) {
				choosenChance = chanceCards [Random.Range (0, chanceCards.Length)].GetComponent<Chance> ();
				showChanceUI = true;
				choosenChance.ActivateChance ();
			} else {
				showEventUI = true;
				if (milestoneSquare == true) {
					onMilestoneSqure = true;
				} else {
					onMilestoneSqure = false;
				}
				boardSquares [playerPosition].GetComponent<Event> ().ActivateEvent ();
			}
				
			// dieRollAllowed = true;
			boardSquares [playerPosition].GetComponent<Event> ().isMilestone = false;
			// Debug.Log ("showChanceUI: " + showChanceUI);
		}
	}

	public static void MovePlayer () {
		allowPlayerMovement = true;
	}
}

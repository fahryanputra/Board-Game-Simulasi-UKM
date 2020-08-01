using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Event : MonoBehaviour {

	public string eventName;
	public string eventOutcome;

	public bool isMilestone;
	public bool isChance;

	protected playerStats stat;
	protected gameMenuController gameMenu;
	protected string eventDesc;
	protected bool square21Visited = false;
	protected int rollSquare85 = 0;

	void Start () {
		stat = GameObject.Find ("Player").GetComponent<playerStats> ();
		gameMenu = GameObject.Find ("Game Menu Controller").GetComponent<gameMenuController> ();
	}

	void Update () {
		if (gameController.playerPosition == 21) {
			square21Visited = true;
		}
	}

	protected void SetEventMenuText () {
		gameMenu.eventDescriptionText.text = eventDesc;
		gameMenu.outcomeText.text = eventOutcome;
	}

	protected void AddValue (ref int stat, int value) {
		stat += value;
	}

	protected void RemoveValue (ref int stat, int value) {
		stat -= value;
	}

	public abstract void ActivateEvent ();
}
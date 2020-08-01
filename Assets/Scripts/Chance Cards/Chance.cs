using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Chance : MonoBehaviour {

	public string option1Desc;
	public string option2Desc;
	public string chanceName;
	public string chanceDesc;
	public string chanceOutcome;

	public bool hasOptions = false;

	protected bool square90Visited = false;
	protected bool loanPaid = false;

	protected playerStats stat;
	protected gameMenuController gameMenu;

	void Start () {
		stat = GameObject.Find ("Player").GetComponent<playerStats> ();
		gameMenu = GameObject.Find ("Game Menu Controller").GetComponent<gameMenuController> ();
	}

	void Update () {
		if (gameController.playerPosition >= 90) {
			square90Visited = true;
		}
		// eventDescText.text = eventDesc;
		if (square90Visited == true && loanPaid != true) {
			// uang berkurang sesuai jumlah pinjaman + bunga
			loanPaid = true;
		}
	}

	protected void SetChanceMenuText () {
		if (hasOptions == true) {
			gameMenu.chanceOptionNameText.text = chanceName;
			gameMenu.chanceOptionDescText.text = chanceDesc;
			gameMenu.chanceOption1Text.text = option1Desc;
			gameMenu.chanceOption2Text.text = option2Desc;
		} else {
			gameMenu.chanceNoOptionNameText.text = chanceName;
			gameMenu.chanceNoOptionDescText.text = chanceDesc;
		}
	}

	protected void SetChanceOutcomeText () {
		gameMenu.outcomeText.text = chanceOutcome;
	}

	protected void AddCash (int value) {
		stat.cash += value;
	}

	protected void RemoveCash (int value) {
		stat.cash -= value;
	}

	protected int PercentCash (int percent) {
		return (percent * stat.cash) / 100;
	}

	public abstract void ActivateChance ();

	public virtual void Option1 () {

		//displayOptions = false;
	}

	public virtual void Option2 () {

		//displayOptions = false;
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameUIButtonScript : MonoBehaviour {

	private Text loanOutcomeText;
	protected playerStats stat;

	void Start () {
		loanOutcomeText = GameObject.Find ("Game Menu Controller").GetComponent<gameMenuController> ().outcomeText;
		stat = GameObject.Find ("Player").GetComponent<playerStats> ();
	}

	public void DismissEventUI () {
		gameController.showEventUI = false;
		gameController.showOutcomeUI = true;
	}

	public void DismisChanceUI () {
		gameController.showChanceUI = false;
		gameController.showOutcomeUI = true;
	}

	public void DismissOutcomeUI () {
		gameController.showOutcomeUI = false;
		gameController.dieRollAllowed = true;
	}

	public void DismissTakeLoanUI () {
		gameController.showTakeLoanUI = false;
		gameController.showOutcomeUI = true;
	}

	public void TakeLoan10 () {
		loanOutcomeText.text = ("Anda mengambil pinjaman sebesar Rp10.000.000");
		DismissTakeLoanUI ();
		stat.cash += 10000000;
		Debug.Log ("You take 10M Loan");
	}

	public void TakeLoan20 () {
		loanOutcomeText.text = ("Anda mengambil pinjaman sebesar Rp20.000.000");
		DismissTakeLoanUI ();
		stat.cash += 20000000;
		Debug.Log ("You take 20M Loan");
	}

	public void TakeLoan50 () {
		loanOutcomeText.text = ("Anda mengambil pinjaman sebesar Rp50.000.000");
		DismissTakeLoanUI ();
		stat.cash += 50000000;
		Debug.Log ("You take 50M Loan");
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameMenuController : MonoBehaviour {

	public GameObject eventMenu;
	public Text eventDescriptionText;

	public GameObject eventMilestoneFlag;
	public GameObject outcomeMilestoneFlag;

	public GameObject chanceNoOptionMenu;
	public Text chanceNoOptionNameText;
	public Text chanceNoOptionDescText;

	public GameObject chanceOptionMenu;
	public Text chanceOptionNameText;
	public Text chanceOptionDescText;
	public Text chanceOption1Text;
	public Text chanceOption2Text;

	public GameObject outcomeMenu;
	public Text outcomeText;

	public GameObject takeLoanMenu;
	public GameObject winMenu;
	public GameObject wheelMenu;
	
	void Update () {
		if (gameController.showEventUI == true) {
			EnableEventUI ();
		} else {
			DisableEventUI ();
		}

		if (gameController.showChanceUI == true) {
			EnableChanceUI ();
		} else {
			DisableChanceUI ();
		}

		if (gameController.showOutcomeUI == true) {
			EnableOutcomeUI ();
		} else {
			DisableOutcomeUI ();
		}

		if (gameController.showTakeLoanUI == true) {
			EnableTakeLoanUI ();
		} else {
			DisableTakeLoanUI ();
		}

		if (gameController.showWinUI == true) {
			EnableWinUI ();
		} else {
			DisableWinUI ();
		}

		if (gameController.showWheelUI == true) {
			EnableWheelUI ();
		} else {
			DisableWheelUI ();
		}
	}

	void EnableEventUI () {
		eventMenu.SetActive (true);
		if (gameController.onMilestoneSqure == true) {
			eventMilestoneFlag.SetActive (true);
		} else {
			eventMilestoneFlag.SetActive (false);
		}
		gameController.dieRollAllowed = false;
	}

	void DisableEventUI () {
		eventMenu.SetActive (false);
	}
		
	void EnableChanceUI () {
		if (gameController.choosenChance.hasOptions == true) {
			chanceOptionMenu.SetActive (true);
			gameController.dieRollAllowed = false;
		} else {
			chanceNoOptionMenu.SetActive (true);
			gameController.dieRollAllowed = false;
		}
	}

	void DisableChanceUI () {
		chanceOptionMenu.SetActive (false);
		chanceNoOptionMenu.SetActive (false);
	}

	void EnableOutcomeUI () {
		outcomeMenu.SetActive (true);
		if (gameController.onMilestoneSqure == true) {
			outcomeMilestoneFlag.SetActive (true);
		} else {
			outcomeMilestoneFlag.SetActive (false);
		}
		gameController.dieRollAllowed = false;
	}

	void DisableOutcomeUI () {
		outcomeMenu.SetActive (false);
	}

	void EnableTakeLoanUI () {
		takeLoanMenu.SetActive (true);
		gameController.dieRollAllowed = false;
	}

	void DisableTakeLoanUI () {
		takeLoanMenu.SetActive (false);
	}

	void EnableWinUI () {
		winMenu.SetActive (true);
		gameController.dieRollAllowed = false;
	}

	void DisableWinUI () {
		winMenu.SetActive (false);
	}

	void EnableWheelUI () {
		wheelMenu.SetActive (true);
	}

	void DisableWheelUI () {
		wheelMenu.SetActive (false);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class optionButtons : MonoBehaviour {

	public void Option1 () {
		gameController.choosenChance.Option1 ();
		gameController.showChanceUI = false; //temporary
		gameController.showOutcomeUI = true;
	}

	public void Option2 () {
		gameController.choosenChance.Option2 ();
		gameController.showChanceUI = false; //temporary
		gameController.showOutcomeUI = true;
	}
}

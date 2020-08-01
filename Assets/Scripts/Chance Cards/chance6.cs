using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chance6 : Chance {

	public override void ActivateChance() {
		hasOptions = false;
		int value = PercentCash (8);
		AddCash (value);

		chanceName = ("Mendapatkan Bunga Bank");
		chanceDesc = ("Anda mendapatkan bunga bank dari deposito berjangka anda." +
			"Besarnya bunga adalah 8% dari kekayaan anda");
		chanceOutcome = ("Uang: -" + value);
		SetChanceMenuText ();
	}
}

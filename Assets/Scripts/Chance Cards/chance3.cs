using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chance3 : Chance {

	public override void ActivateChance() {
		hasOptions = false;
		int value = PercentCash (10);
		RemoveCash (value);

		chanceName = ("Pajak");
		chanceDesc = ("Bayar pajak 10% dari kekayaan anda");
		chanceOutcome = ("Uang: -" + value);
		SetChanceMenuText ();
	}
}

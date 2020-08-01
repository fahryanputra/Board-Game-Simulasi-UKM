using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chance2 : Chance {

	public override void ActivateChance() {
		int value = 200000 * gameController.dieNumber;
		hasOptions = false;
		RemoveCash (value);

		chanceName = ("Tagihan Listrik");
		chanceDesc = ("Bayar tagihan listrik 200 ribu dikali jumlah mata dadu");
		chanceOutcome = ("Uang: -" + value);
		SetChanceMenuText ();
		SetChanceOutcomeText ();
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chance5 : Chance {

	public override void ActivateChance() {
		hasOptions = false;
		int value = 100000 * gameController.dieNumber;
		RemoveCash (value);

		chanceName = ("Denda Bank");
		chanceDesc = ("Anda terlambat membayar tagihan kartu kredit anda." +
			"Anda harus membayar denda kepada bank sebesar 100 ribu x jumlah mata dadu");
		chanceOutcome = ("Uang: -" + value);
		SetChanceMenuText ();
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chance7 : Chance {

	public override void ActivateChance() {
		hasOptions = false;
		int value = 1000000 * gameController.dieNumber;
		RemoveCash (value);

		chanceName = ("Bayar Uang Sekolah");
		chanceDesc = ("Anak anda masuk sekolah dasar." +
			" Anda harus membayar biaya gedung dan uang pangkal sebesar" +
			" 1 juta x jumlah mata dadu");
		chanceOutcome = ("Uang: -" + value);
		SetChanceMenuText ();
		SetChanceOutcomeText ();
	}
}

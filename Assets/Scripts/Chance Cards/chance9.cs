using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chance9 : Chance {

	public override void ActivateChance() {
		hasOptions = false;
		int value = 500000 * gameController.dieNumber;
		RemoveCash (value);

		chanceName = ("Biaya Dokter");
		chanceDesc = ("Anda jatuh sakit dan memerlukan perawatan." +
			" Bayar tagihan dokter dan rumah sakit sebesar 500 ribu x jumlah mata dadu");
		chanceOutcome = ("Uang: -" + value);
		SetChanceMenuText ();
	}
}

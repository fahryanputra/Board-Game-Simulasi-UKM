using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chance14 : Chance {

	public override void ActivateChance() {
		hasOptions = true;
		chanceName = ("Pinjaman Bank");

		chanceDesc = ("Anda dapat tawaran pinjaman dari bank dengan bunga 10%. Pinjaman tersedia dalam nominal 10, 20, dan 50jt. " +
			"Pinjaman dibayarkan pada tile ke 90 beserta bunga");
		option1Desc = ("Ambil Pinjaman");
		option2Desc = ("Tolak pinjaman");
		SetChanceMenuText ();
	}

	public override void Option1 () {
		gameController.showChanceUI = false;
		gameController.showTakeLoanUI = true;
	}

	public override void Option2 () {
		chanceOutcome = ("Anda tidak menerima tawaran pinjaman dari bank");
		SetChanceOutcomeText ();
	}
}

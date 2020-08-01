using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chance19 : Chance {

	public override void ActivateChance() {
		hasOptions = true;
		chanceName = ("Orang tua sakit");

		chanceDesc = ("Saatnya musim sibuk untuk toko anda. Di musim ini akan ada lebih banyak pelanggan yang datang ke toko anda. " +
			"Namun tiba-tiba, Ibu anda masuk ke rumah sakit dan akan dirawat inap untuk beberapa hari");
		option1Desc = ("Tutup toko anda untuk beberapa hari untuk menemani ibu anda di rumah sakit");
		option2Desc = ("Tetap membuka toko anda dan tidak menjenguk ibu anda");
		SetChanceMenuText ();
	}

	public override void Option1 () {
		RemoveCash (10000000);
		chanceOutcome = ("Uang: -10000000");
		SetChanceOutcomeText ();
	}

	public override void Option2 () {
		AddCash (10000000);
		chanceOutcome = ("Uang: +10000000");
		SetChanceOutcomeText ();
	}
}

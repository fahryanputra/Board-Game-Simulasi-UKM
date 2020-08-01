using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chance17 : Chance {

	public override void ActivateChance() {
		hasOptions = true;
		chanceName = ("Hari Pelanggan");

		chanceDesc = ("Hari ini adalah hari pelanggan nasional! Tim anda berdiskusi untuk membuat event loyalty bagi pelanggan setia anda " +
			"namun banyak hal yang harus dipertimbangkan seperti terbatasnya biaya dan lain-lain");
		option1Desc = ("Adakan event untuk pelanggan setia anda dengan memberi diskon dan hadiah");
		option2Desc = ("Tidak ada event");
		SetChanceMenuText ();
	}

	public override void Option1 () {
		RemoveCash (500000);
		stat.quality += 2;
		chanceOutcome = ("Uang: -500000, Kualitas: +2");
		SetChanceOutcomeText ();
	}

	public override void Option2 () {
		stat.quality -= 1;
		chanceOutcome = ("Kualitas: -1");
		SetChanceOutcomeText ();
	}
}

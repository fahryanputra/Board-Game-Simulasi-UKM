using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chance8 : Chance {

	public override void ActivateChance() {
		hasOptions = false;
		int value = 1000000 * gameController.dieNumber;
		AddCash (value);

		chanceName = ("Dapat Uang dari Orang Tua");
		chanceDesc = ("Orang tua anda memberikan anda uang untuk membantu jalannya bisnis anda" +
			" sebesar 1 juta x jumlah mata dadu");
		chanceOutcome = ("Uang: +" + value);
		SetChanceMenuText ();
		SetChanceOutcomeText ();
	}
}

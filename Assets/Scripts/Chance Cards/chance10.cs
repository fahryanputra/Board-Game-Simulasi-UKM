using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chance10 : Chance {

	public override void ActivateChance() {
		hasOptions = false;
		RemoveCash (5000000);

		chanceName = ("Asuransi");
		chanceDesc = ("Hari ini adalah tanggal jatuh tempo Asuransi Jiwa dan Kesehatan anda." +
			" Silahkan lunasi premi anda sebesar 5 juta");
		chanceOutcome = ("Uang: -" + 5000000);
		SetChanceMenuText ();
		SetChanceOutcomeText ();
	}
}

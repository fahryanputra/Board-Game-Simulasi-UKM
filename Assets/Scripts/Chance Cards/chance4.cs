using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chance4 : Chance {

	public override void ActivateChance() {
		hasOptions = false;
		RemoveCash (1000000);

		chanceName = ("Biaya perbaikan jalan");
		chanceDesc = ("Jalanan di sekitar toko anda mengalami kerusakan yang cukup parah." +
			"kepala RW mengumpulkan iuran sebesar 1 juta per orang dari warga-warga di daerah " +
			"sekitar untuk melakukan perbaikan");
		chanceOutcome = ("Uang: -1000000");
		SetChanceMenuText ();
		SetChanceOutcomeText ();
	}
}

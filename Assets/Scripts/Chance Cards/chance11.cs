using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chance11 : Chance {

	public override void ActivateChance () {
		hasOptions = false;
		int value = 2000000 * gameController.dieNumber;
		if (stat.businessLicense == true) {
			AddCash (value);
			chanceOutcome = ("Uang: -" + value);
			SetChanceOutcomeText ();
		} else {
			stat.businessLicense = true;
			chanceOutcome = ("Anda membuat Surat Izin Usaha");
			SetChanceOutcomeText ();
		}

		chanceName = ("Dapat Modal Pemerintah");
		chanceDesc = ("Pemerintah sedang berusaha menigkatkan jumlah UKM di Indonesia, " +
			"salah satunya dengan membagikan bantuan modal bagi para pengusaha. " +
			"Syarat mendapatkannya adalah memiliki Surat Izin Usaha.");
		SetChanceMenuText ();
	}
}

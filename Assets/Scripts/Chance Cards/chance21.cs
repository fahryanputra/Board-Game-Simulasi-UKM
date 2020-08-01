using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chance21 : Chance {

	public override void ActivateChance() {
		hasOptions = true;
		chanceName = ("Beli Mobil Baru");

		chanceDesc = ("Mobil anda mogok di tengah jalan! " +
			"Montir anda bilang bahwa mobil anda sudah terlalu tua dan tidak memiliki kemungkinan untuk diperbaiki lagi");
		option1Desc = ("Anda menjual mobil lama dan membeli mobil baru");
		option2Desc = ("Anda menjual mobil lama dan memilih untuk menggunakan transportasi umum untuk kegiatan sehari hari");
		SetChanceMenuText ();
	}

	public override void Option1 () {
		if (stat.communication >= 5) {	
			RemoveCash (50000000);
			chanceOutcome = ("Uang: -50000000");
		} else {
			RemoveCash (100000000);
			chanceOutcome = ("Uang: -100000000");
		}
		SetChanceOutcomeText ();
	}

	public override void Option2 () {
		if (stat.communication >= 5) {	
			AddCash (50000000);
			chanceOutcome = ("Uang: +50000000");
		} else {
			AddCash (25000000);
			chanceOutcome = ("Uang: +25000000");
		}
		SetChanceOutcomeText ();
	}
}

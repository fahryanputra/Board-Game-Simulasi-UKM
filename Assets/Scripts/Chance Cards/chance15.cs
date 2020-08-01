using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chance15 : Chance {

	public override void ActivateChance() {
		hasOptions = true;
		chanceName = ("Penipuan");

		chanceDesc = ("Anda mendapat sebuah pesan dari nomor yang tidak anda ketahui yang berkata bahwa anda akan diberikan sebuah pinjaman sebesar 50 juta jika anda memberi sebuah jaminan berupa BPKB mobil");
		option1Desc = ("Anda setuju dengan pesan tersebut dan memberikan BPKB mobil");
		option2Desc = ("Anda tidak setuju dengan pesan tersebut dan membiarkannya");
		SetChanceMenuText ();
	}

	public override void Option1 () {
		if (stat.intelligence < 5) {
			RemoveCash (500000);
			chanceOutcome = ("Uang: -500000");
		} else {
			chanceOutcome = ("Tidak ada yang terjadi");
		}
		SetChanceOutcomeText ();
	}

	public override void Option2 () {
		chanceOutcome = ("Tidak ada yang terjadi");
		SetChanceOutcomeText ();
	}
}

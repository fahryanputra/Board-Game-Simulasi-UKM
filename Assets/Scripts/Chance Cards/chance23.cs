using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chance23 : Chance {

	public override void ActivateChance() {
		hasOptions = true;
		chanceName = ("Liburan");

		chanceDesc = ("Waktu liburan telah tiba! " +
			"Apakah anda akan menggunakan waktu ini untuk liburan bersama keluarga anda atau terus bekerja?");
		option1Desc = ("Anda memilih berlibur bersama keluarga anda");
		option2Desc = ("Anda memilih untuk terus bekerja");
		SetChanceMenuText ();
	}

	public override void Option1 () {
		RemoveCash (20000000);
		chanceOutcome = ("Uang: -20000000");
		SetChanceOutcomeText ();
	}

	public override void Option2 () {
		AddCash (20000000);
		chanceOutcome = ("Uang: +20000000");
		SetChanceOutcomeText ();
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chance22 : Chance {

	public override void ActivateChance() {
		hasOptions = true;
		chanceName = ("Ikut Training");

		chanceDesc = ("Anda mendengar dari teman anda bahwa akan diadakan training entrepreneur. " +
			"Mengikuti training ini akan membantu bisnis anda namun akan ada biaya masuk untuk mengikuti training");
		option1Desc = ("Anda memilih untuk mengikuti training tersebut");
		option2Desc = ("Anda memilih untuk tidak mengikuti training tersebut");
		SetChanceMenuText ();
	}

	public override void Option1 () {
		RemoveCash (1000000);
		stat.quality += 2;
		chanceOutcome = ("Uang: -1000000, Kualitas: +2");
		SetChanceOutcomeText ();
	}

	public override void Option2 () {
		chanceOutcome = ("Tidak ada yang terjadi");
		SetChanceOutcomeText ();
	}
}

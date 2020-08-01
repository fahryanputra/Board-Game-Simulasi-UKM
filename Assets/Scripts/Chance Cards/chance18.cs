using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chance18 : Chance {

	public override void ActivateChance() {
		hasOptions = true;
		chanceName = ("Festival");

		chanceDesc = ("Sebuah festival besar akan diadakan! Membuka stand di festival ini adalah kesempatan sempurna untuk menyebarkan produk anda");
		option1Desc = ("Anda memilih untuk membuka stand di festival tersebut");
		option2Desc = ("Anda memilih untuk tidak membuka stand di festival tersebut");
		SetChanceMenuText ();
	}

	public override void Option1 () {
		RemoveCash (10000000);
		stat.quality += 2;
		chanceOutcome = ("Uang: -10000000, Kualitas: +2");
		SetChanceOutcomeText ();
	}

	public override void Option2 () {
		chanceOutcome = ("Tidak ada yang terjadi");
		SetChanceOutcomeText ();
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chance24 : Chance {

	public override void ActivateChance() {
		hasOptions = true;
		chanceName = ("Kompetitor");

		chanceDesc = ("Beberapa blok dari toko anda buka toko baru yang menjual produk mirip dengan produk anda");
		option1Desc = ("Anda mencoba melakukan marketing push secara agresif agar tidak tertinggal dengan toko tersebut");
		option2Desc = ("Anda percaya diri bahwa produk anda lebih baik dan tidak merespons");
		SetChanceMenuText ();
	}

	public override void Option1 () {
		RemoveCash (5000000);
		stat.quality += 2;
		chanceOutcome = ("Uang: -5000000, Kualitas: +2");
		SetChanceOutcomeText ();
	}

	public override void Option2 () {
		stat.quality -= 2;
		chanceOutcome = ("Kualitas: -2");
		SetChanceOutcomeText ();
	}
}

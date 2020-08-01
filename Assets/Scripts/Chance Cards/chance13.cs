using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chance13 : Chance {

	public override void ActivateChance() {
		hasOptions = true;
		chanceName = ("Konstruksi kantor/toko");

		chanceDesc = ("Setelah musim hujan yang panjang terdapat beberapa kerusakan dalam toko anda");
		option1Desc = ("Anda memilih untuk menghemat biaya dan tidak memperbaiki kerusakan-kerusakan yang terjadi");
		option2Desc = ("Anda memilih untuk memperbaiki kerusakan-kerusakan yang terjadi");
		SetChanceMenuText ();
	}

	public override void Option1 () {
		stat.quality -= 2;
		chanceOutcome = ("Kualitas: -" + 2);
		SetChanceOutcomeText ();
	}

	public override void Option2 () {
		RemoveCash (2000000);
		chanceOutcome = ("Uang: -2000000");
		SetChanceOutcomeText ();
	}
}

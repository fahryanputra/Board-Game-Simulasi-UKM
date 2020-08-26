using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chance20 : Chance {

	public override void ActivateChance() {
		hasOptions = true;
		chanceName = ("Renovasi");

		chanceDesc = ("Salah satu karyawan anda berkata pada anda bahwa jika anda merenovasi toko agar toko anda akan lebih banyak didatangi pelanggan");
		option1Desc = ("Anda memilih untuk mendengarkan karyawan anda dan merenovasi toko anda");
		option2Desc = ("Anda memilih untuk tidak merenovasi toko anda");
		SetChanceMenuText ();
	}

	public override void Option1 () {
		if (stat.creativity >= 7) {	
			RemoveCash (10000000);
			stat.quality += 3;
		} else {
			RemoveCash (10000000);
			stat.quality += 1;
		}
		SetChanceOutcomeText ();
	}

	public override void Option2 () {
		chanceOutcome = ("Tidak ada yang terjadi");
		SetChanceOutcomeText ();
	}
}

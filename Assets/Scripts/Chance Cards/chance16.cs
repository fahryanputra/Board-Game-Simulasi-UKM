using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chance16 : Chance {

	public override void ActivateChance() {
		hasOptions = true;
		chanceName = ("Endorsement");

		chanceDesc = ("Salah satu cara menyebarkan produk anda adalah untuk bekerja sama dengan seorang influencer, " +
			"kebetulan seorang influencer mengontak anda untuk menawarkan endorsement");
		option1Desc = ("Ambil kesempatan tersebut untuk secara resmi bekerja sama dengan influencer tersebut");
		option2Desc = ("Anda tidak memilih untuk bekerja sama dengan influencer tersebut");
		SetChanceMenuText ();
	}

	public override void Option1 () {
		if (stat.communication >= 5) {
			RemoveCash (5000000);
			stat.quality += 2;
			chanceOutcome = ("Uang: -5000000, Kualitas: +2");
		} else {
			RemoveCash (10000000);
			stat.quality += 2;
			chanceOutcome = ("Uang: -10000000, Kualitas: +2");
		}
		SetChanceOutcomeText ();
	}

	public override void Option2 () {
		chanceOutcome = ("Tidak ada yang terjadi");
		SetChanceOutcomeText ();
	}
}

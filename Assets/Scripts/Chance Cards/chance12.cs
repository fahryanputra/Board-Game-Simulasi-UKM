using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chance12 : Chance {

	public override void ActivateChance() {
		hasOptions = false;
		int value = 2000000 * gameController.dieNumber;
		AddCash (value);

		chanceName = ("Investasi");
		chanceDesc = ("Seorang kerabat mengontak andadan menawarkan uang investasi untuk membantu bisnis anda sebesar " +
			"2 juta x dadu");
		chanceOutcome = ("Uang: +" + value);
		SetChanceMenuText ();
		SetChanceOutcomeText ();
	}
}

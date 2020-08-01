using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class revenueEvent: Event {

	public override void ActivateEvent() {
		int value = (gameController.dieNumber + stat.quality) * 2000000;
		AddValue (ref stat.cash, value);

		eventDesc = ("Revenue");
		eventOutcome = ("Uang: +" + value);
		SetEventMenuText ();
	}
}

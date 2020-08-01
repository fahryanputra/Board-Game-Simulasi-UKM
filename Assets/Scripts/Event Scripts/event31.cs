using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class event31 : Event {

	public override void ActivateEvent() {
		int value = (gameController.dieNumber + stat.quality) * 2000000;
		AddValue (ref stat.cash, value);
		if (square21Visited == true) {
			AddValue (ref stat.cash, 10000000);
			eventOutcome = ("Uang: +" + value + ", Bonus: +10000000");
			Debug.Log ("Requirement met!");
		} else {
			eventOutcome = ("Uang: +" + value);
		}

		eventDesc = ("Revenue");
		SetEventMenuText ();
	}
}

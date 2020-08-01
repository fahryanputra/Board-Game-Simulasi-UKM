using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class event17 : Event {

	public override void ActivateEvent() {
		RemoveValue (ref stat.cash, 500000);

		eventDesc = ("Bekerja berlebihan dan masuk IGD");
		eventOutcome = ("Uang: -500000");
		SetEventMenuText ();
	}
}

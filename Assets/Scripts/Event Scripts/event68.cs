using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class event68 : Event {

	public override void ActivateEvent() {
		RemoveValue (ref stat.cash, 10000000);
		if (stat.communication >= 5) {
			AddValue (ref stat.quality, 1);
			eventOutcome = ("Uang: -10000000, Kualitas: +1");
		} else {
			eventOutcome = ("Uang: -10000000");
		}

		eventDesc = ("Outing karyawan");
		SetEventMenuText ();
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class event60 : Event {

	public override void ActivateEvent() {
		if (stat.intelligence < 5) {
			RemoveValue (ref stat.cash, 200000);
			eventOutcome = ("Uang: -200000");
		} else {
			eventOutcome = ("Tidak ada yang terjadi");
		}

		eventDesc = ("Terkena penipuan order fiktif");
		SetEventMenuText ();
	}
}

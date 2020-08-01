using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class event36 : Event {

	public override void ActivateEvent() {
		if (stat.intelligence >= 5) {
			AddValue (ref stat.cash, 5000000);
			eventOutcome = ("Uang: +5000000");
		} else {
			eventOutcome = ("Tidak ada yang terjadi");
		}

		eventDesc = ("Apply bantuan modal");
		SetEventMenuText ();
	}
}

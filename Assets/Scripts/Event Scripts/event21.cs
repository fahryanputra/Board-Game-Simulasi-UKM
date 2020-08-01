using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class event21 : Event {

	public override void ActivateEvent() {
		if (stat.creativity + stat.communication > 6) {
			AddValue (ref stat.cash, 10000000);
			eventOutcome = ("Uang: +10000000");
		} else {
			eventOutcome = ("Tidak ada yang terjadi");
		}

		eventDesc = ("Crowd Funding");
		SetEventMenuText ();
	}
}

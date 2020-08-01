using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class event72 : Event {

	public override void ActivateEvent() {
		if (stat.creativity >= 5) {
			AddValue (ref stat.quality, 1);
			eventOutcome = ("Kualitas: +1");
		} else {
			eventOutcome = ("Tidak ada yang terjadi");
		}

		eventDesc = ("Job posting");
		SetEventMenuText ();
	}
}

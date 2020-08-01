using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class event87 : Event {

	public override void ActivateEvent() {
		RemoveValue (ref stat.cash, 2000000);
		if (stat.creativity >= 5) {
			AddValue (ref stat.quality, 1);
			eventOutcome = ("Uang: -2000000, Kualitas: +1");
		} else {
			eventOutcome = ("Tidak ada yang terjadi");
		}

		eventDesc = ("Promosi cabang baru");
		SetEventMenuText ();
	}
}

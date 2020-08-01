using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class event29 : Event {

	public override void ActivateEvent() {
		if (stat.creativity >= 4) {
			AddValue (ref stat.quality, 1);
			eventOutcome = ("Kualitas: +1");
		} else {
			eventOutcome = ("Tidak ada yang terjadi");
		}

		eventDesc = ("Buat iklan");
		SetEventMenuText ();
	}
}

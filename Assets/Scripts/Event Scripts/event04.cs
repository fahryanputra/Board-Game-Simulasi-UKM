using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class event04 : Event {

	public override void ActivateEvent() {
		if (stat.intelligence >= 4) {
			AddValue (ref stat.quality, 1);
			eventOutcome = ("Kualitas: +1");
		} else {
			eventOutcome = ("Tidak ada yang terjadi");
		}

		eventDesc = ("Survey tempat");
		SetEventMenuText ();
		Debug.Log (eventDesc);
	}
}

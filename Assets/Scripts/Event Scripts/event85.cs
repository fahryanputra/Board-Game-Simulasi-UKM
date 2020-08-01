using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class event85 : Event {

	public override void ActivateEvent() {
		if (rollSquare85 > 4) {
			AddValue (ref stat.quality, 3);
			eventOutcome = ("Kualitas: +3");
		} else {
			AddValue (ref stat.quality, 1);
			eventOutcome = ("Kualitas: +1");
		}

		eventDesc = ("Pembukaan cabang");
		SetEventMenuText ();
	}
}

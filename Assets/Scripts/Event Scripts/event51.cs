using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class event51 : Event {

	public override void ActivateEvent() {
		RemoveValue (ref stat.cash, 10000000);

		eventDesc = ("Alat operasional rusak");
		eventOutcome = ("Uang: -10000000");
		SetEventMenuText ();
	}
}

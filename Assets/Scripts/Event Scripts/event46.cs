using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class event46 : Event {

	public override void ActivateEvent() {
		RemoveValue (ref stat.cash, 5000000);

		eventDesc = ("Terkena banjir");
		eventOutcome = ("Uang: -5000000");
		SetEventMenuText ();
	}
}

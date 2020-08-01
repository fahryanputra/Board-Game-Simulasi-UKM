using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class event73 : Event {

	public override void ActivateEvent() {
		RemoveValue (ref stat.quality, 1);
		RemoveValue (ref stat.cash, 5000000);

		eventDesc = ("Website down");
		eventOutcome = ("Kualitas: -1, Uang: -5000000");
		SetEventMenuText ();
	}
}

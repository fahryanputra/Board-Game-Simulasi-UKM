using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class event65 : Event {

	public override void ActivateEvent() {
		AddValue (ref stat.quality, 1);
		RemoveValue (ref stat.cash, 5000000);

		eventDesc = ("Endorsement");
		eventOutcome = ("Kualitas: +1, Uang: -5000000");
		SetEventMenuText ();
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class event95 : Event {

	public override void ActivateEvent() {
		RemoveValue (ref stat.quality, 1);
		RemoveValue (ref stat.cash, 5000000);

		eventDesc = ("Sistem down");
		eventOutcome = ("Kualitas: -1, uang: -5000000");
		SetEventMenuText ();
	}
}

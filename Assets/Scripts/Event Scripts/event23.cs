using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class event23 : Event {

	public override void ActivateEvent() {
		RemoveValue (ref stat.cash, 2000000);
		AddValue (ref stat.quality, 1);

		eventDesc = ("Promosi soft opening");
		eventOutcome = ("Uang: -2000000, Kualitas: +1");
		SetEventMenuText ();
	}
}

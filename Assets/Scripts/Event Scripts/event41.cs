using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class event41 : Event {

	public override void ActivateEvent() {
		RemoveValue (ref stat.cash, 500000);
		AddValue (ref stat.communication, 1);

		eventDesc = ("Ikut Komunitas");
		eventOutcome = ("Uang: -500000, Komunikasi: +1");
		SetEventMenuText ();
	}
}

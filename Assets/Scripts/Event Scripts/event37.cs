using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class event37 : Event {

	public override void ActivateEvent() {
		RemoveValue (ref stat.cash, 300000);
		AddValue (ref stat.quality, 1);
		AddValue (ref stat.communication, 1);

		eventDesc = ("Workshop");
		eventOutcome = ("Uang: -300000, Kualitas: +1, Komunikasi: +1");
		SetEventMenuText ();
	}
}

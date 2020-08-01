using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class event77 : Event {

	public override void ActivateEvent() {
		AddValue (ref stat.quality, 1);
		RemoveValue (ref stat.cash, 10000000);

		eventDesc = ("Konstruksi cabang");
		eventOutcome = ("Kualitas: +1, Uang: -10000000");
		SetEventMenuText ();
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class event20 : Event {

	public override void ActivateEvent() {
		AddValue (ref stat.quality, 1);
		RemoveValue (ref stat.cash, 2000000);

		eventDesc = ("Mempekerjakan desainer grafis");
		eventOutcome = ("Kualitas: +1, Uang: -2000000");
		SetEventMenuText ();
	}
}

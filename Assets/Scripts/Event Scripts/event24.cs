using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class event24 : Event {

	public override void ActivateEvent() {
		RemoveValue (ref stat.cash, 500000);
		RemoveValue (ref stat.quality, 1);

		eventDesc = ("Anda jatuh sakit");
		eventOutcome = ("Uang: -500000, Kualitas: -1");
		SetEventMenuText ();
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class event08 : Event {

	public override void ActivateEvent() {
		int value = 10000000 - (1000000 * gameController.dieNumber);
		RemoveValue (ref stat.cash, value);

		eventDesc = ("Membeli/Menyewa properti pertama");
		eventOutcome = ("Uang: -" + value);
		SetEventMenuText ();
		Debug.Log (eventDesc);
	}
}

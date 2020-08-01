using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class event13 : Event {

	public override void ActivateEvent() {
		if (stat.intelligence < 5) {
			RemoveValue (ref stat.cash, 1000000);
			eventOutcome = ("Uang: -1000000");
		} else {
			eventOutcome = ("Tidak ada yang terjadi");
		}

		eventDesc = ("Tertipu vendor");
		SetEventMenuText ();
		Debug.Log (eventDesc);
	}
}

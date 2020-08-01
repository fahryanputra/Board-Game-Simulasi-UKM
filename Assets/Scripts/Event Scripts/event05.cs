using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class event05 : Event {

	public override void ActivateEvent() {
		if (stat.intelligence < 4) {
			RemoveValue (ref stat.cash, 2000000);
			eventOutcome = ("Uang: -2000000");
		} else {
			eventOutcome = ("Tidak ada yang terjadi");
		}

		eventDesc = ("Terkena penipuan");
		SetEventMenuText ();
		Debug.Log (eventDesc);
	}
}

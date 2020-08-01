using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class event19 : Event {

	public override void ActivateEvent() {
		RemoveValue (ref stat.cash, 500000);

		eventDesc = ("Salah pembukuan, rugi");
		eventOutcome = ("Uang: -500000");
		SetEventMenuText ();
	}
}

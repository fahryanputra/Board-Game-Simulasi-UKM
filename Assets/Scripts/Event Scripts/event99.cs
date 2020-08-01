using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class event99 : Event {

	public override void ActivateEvent() {
		AddValue (ref stat.cash, 10000000);

		eventDesc = ("Jual franchise");
		eventOutcome = ("Uang: +10000000");
		SetEventMenuText ();
	}
}

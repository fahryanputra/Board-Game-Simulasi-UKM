using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class event98 : Event {

	public override void ActivateEvent() {
		AddValue (ref stat.quality, 1);

		eventDesc = ("Penghargaan entrepreneurship");
		eventOutcome = ("Kualitas: +1");
		SetEventMenuText ();
	}
}

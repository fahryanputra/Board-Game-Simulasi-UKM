using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class event33 : Event {

	public override void ActivateEvent() {
		RemoveValue (ref stat.quality, 1);

		eventDesc = ("Kompetitor inovasi");
		eventOutcome = ("Kualitas: -1");
		SetEventMenuText ();
	}
}

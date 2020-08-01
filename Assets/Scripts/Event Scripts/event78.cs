using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class event78 : Event {

	public override void ActivateEvent() {
		RemoveValue (ref stat.quality, 1);

		eventDesc = ("Bad review");
		eventOutcome = ("Kualitas: +1");
		SetEventMenuText ();
	}
}

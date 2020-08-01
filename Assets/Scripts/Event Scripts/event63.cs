using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class event63 : Event {

	public override void ActivateEvent() {
		AddValue (ref stat.quality, 1);

		eventDesc = ("Merekrut admin media sosial");
		eventOutcome = ("Kualitas: +1");
		SetEventMenuText ();
	}
}

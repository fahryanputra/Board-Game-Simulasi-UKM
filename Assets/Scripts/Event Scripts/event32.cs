using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class event32 : Event {

	public override void ActivateEvent() {
		AddValue (ref stat.intelligence, 1);

		eventDesc = ("Konsultasi hukum");
		eventOutcome = ("Kecerdasan: +1");
		SetEventMenuText ();
	}
}

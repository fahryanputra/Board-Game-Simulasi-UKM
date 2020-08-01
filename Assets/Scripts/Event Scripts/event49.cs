using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class event49 : Event {

	public override void ActivateEvent() {
		AddValue (ref stat.intelligence, 1);
		AddValue (ref stat.quality, 1);

		eventDesc = ("Membuat SOP");
		eventOutcome = ("Kecerdasan: +1, Kualitas: +1");
		SetEventMenuText ();
	}
}

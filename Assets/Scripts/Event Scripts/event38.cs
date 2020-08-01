using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class event38 : Event {

	public override void ActivateEvent() {
		AddValue (ref stat.quality, 1);
		AddValue (ref stat.creativity, 1);

		eventDesc = ("Ikut Pameran");
		eventOutcome = ("Kualitas: +1, Kreatifitas: +1");
		SetEventMenuText ();
	}
}

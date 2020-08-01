using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class event96 : Event {

	public override void ActivateEvent() {
		AddValue (ref stat.quality, 1);

		eventDesc = ("Usaha diliput artikel");
		eventOutcome = ("Kualitas: +1");
		SetEventMenuText ();
	}
}

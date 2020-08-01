using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class event42 : Event {

	public override void ActivateEvent() {
		RemoveValue (ref stat.cash, 1000000);
		RemoveValue (ref stat.quality, 1);

		eventDesc = ("Kendaraan operasional rusak");
		eventOutcome = ("Uang: -1000000, Kualitas: -1");
		SetEventMenuText ();
	}
}

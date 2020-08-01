using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class event25 : Event {

	public override void ActivateEvent() {
		RemoveValue (ref stat.cash, 15000000);
		AddValue (ref stat.quality, 1);

		eventDesc = ("Beli kendaraan operasional");
		eventOutcome = ("Uang: -15000000, Kualitas: +1");
		SetEventMenuText ();
	}
}

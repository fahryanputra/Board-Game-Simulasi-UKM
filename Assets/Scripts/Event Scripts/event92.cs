using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class event92 : Event {

	public override void ActivateEvent() {
		RemoveValue (ref stat.cash, 10000000);
		RemoveValue (ref stat.quality, 1);

		eventDesc = ("Banjir tutup toko");
		eventOutcome = ("Uang: -10000000, Kualitas: -1");
		SetEventMenuText ();
	}
}

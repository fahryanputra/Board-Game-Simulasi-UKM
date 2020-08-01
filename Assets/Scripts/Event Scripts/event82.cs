using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class event82 : Event {

	public override void ActivateEvent() {
		RemoveValue (ref stat.quality, 1);
		RemoveValue (ref stat.cash, 2000000);

		eventDesc = ("Kerugian barang rusak di gudang");
		eventOutcome = ("Kualitas: -1, Uang: -2000000");
		SetEventMenuText ();
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class event18 : Event {

	public override void ActivateEvent() {
		AddValue (ref stat.quality, 1);
		RemoveValue (ref stat.cash, 1000000);

		eventDesc = ("Membuat produk");
		eventOutcome = ("Kualitas: +1, Uang: -1000000");
		SetEventMenuText ();
	}
}

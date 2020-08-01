using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class event55 : Event {

	public override void ActivateEvent() {
		AddValue (ref stat.quality, 1);

		eventDesc = ("Jualan di ecommerce/online");
		eventOutcome = ("Kualitas: +1");
		SetEventMenuText ();
	}
}

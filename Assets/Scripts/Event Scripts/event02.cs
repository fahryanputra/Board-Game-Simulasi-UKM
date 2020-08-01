using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class event02 : Event {

	public override void ActivateEvent() {
		AddValue (ref stat.intelligence, 1);

		eventDesc = ("Belajar entrepreneurship dari buku!");
		eventOutcome = ("Kecerdasan: +1");
		SetEventMenuText ();
		Debug.Log (eventDesc);
	}
}

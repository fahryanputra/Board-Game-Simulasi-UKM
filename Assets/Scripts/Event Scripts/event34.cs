using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class event34 : Event {

	public override void ActivateEvent() {
		AddValue (ref stat.quality, 1);

		eventDesc = ("Buat surat izin usaha");
		eventOutcome = ("Kualitas: +1");
		SetEventMenuText ();
	}
}

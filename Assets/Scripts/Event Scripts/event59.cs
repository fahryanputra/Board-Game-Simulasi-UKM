﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class event59 : Event {

	public override void ActivateEvent() {
		AddValue (ref stat.quality, 1);

		eventDesc = ("Membuat website");
		eventOutcome = ("Kualitas: +1");
		SetEventMenuText ();
	}
}

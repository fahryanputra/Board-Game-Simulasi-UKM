using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finish : Event {

	public override void ActivateEvent() {
		gameController.showWinUI = true;
	}
}

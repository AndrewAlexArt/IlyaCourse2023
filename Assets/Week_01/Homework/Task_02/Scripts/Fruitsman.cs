using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruitsman : Vendor, ITradeType {

    private void Awake() {
        Initialize(this, 5);
    }

    public void Trade() {
        Debug.Log("Открываю лавку с фруктами");
    }
}

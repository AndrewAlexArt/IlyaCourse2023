using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armorer : Vendor, ITradeType {


    private void Awake() {
        Initialize(this, 12);
    }


    public void Trade() {
        Debug.Log("Открываю лавку мастера по броне");
    }
}

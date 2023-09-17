using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Coin : MonoBehaviour {
    private void OnTriggerEnter(Collider other) {
        if (other.TryGetComponent(out ICoinPicker coinPicker)) {
            Debug.Log("Проигрывыется музыка подбора монетки");
            Debug.Log("Проигрывыется агимация подбора монетки");

            AddCoins(coinPicker);
            Destroy(gameObject);
        }
    }

    protected abstract void AddCoins(ICoinPicker coinPicker);


}

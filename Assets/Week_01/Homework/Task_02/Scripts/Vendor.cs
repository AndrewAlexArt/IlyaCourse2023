using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Vendor : MonoBehaviour {

    private ITradeType _tradeType;
    private int _reputationAllow;

    public void Initialize(ITradeType tradeType, int reputationAllow) {
        _tradeType = tradeType;
        _reputationAllow = reputationAllow;
    }

    public void StartTrade() {
        _tradeType.Trade();
    }

    private void OnTriggerEnter(Collider other) {
        if (other.TryGetComponent(out PlayerHomework player)) {
            if (player.Reputation >= _reputationAllow) {
                StartTrade();
            }
            else {
                TradeDenied(player.Reputation);
            }
        }
    }

    private void TradeDenied(int reputationTest) {
        Debug.Log("Пшел отсюда! С такими как ты не торгую.");
        Debug.Log($"Уровень репутации игрока {reputationTest}. Для взаимодействия необходимо {_reputationAllow} и выше");


    }

    private void OnTriggerExit(Collider other) {
        if (other.TryGetComponent(out PlayerHomework player)) Debug.Log("Ухожу...");
    }
}

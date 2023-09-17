using System.Collections.Generic;

using UnityEngine;

public class AllDestroyedWin : IRule {

    private List<Ball> _allBalls;
    private bool _gameWin;

    public AllDestroyedWin(List<Ball> allBalls) {
        Debug.Log("Выбрано условие уничтожить все шарики");
        _allBalls = allBalls;
    }

    public void CheckWinCondition() {
        if (_allBalls.Count < 1) {
            _gameWin = true;
            Debug.Log("Вы выйграли!");
        }
    }

    public bool IsGameWin() {
        return _gameWin;
    }
}

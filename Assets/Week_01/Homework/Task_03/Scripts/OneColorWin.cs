using System.Collections.Generic;
using UnityEngine;

public class OneColorWin : IRule {

    private List<Ball> _redBalls;
    private List<Ball> _whiteBalls;
    private List<Ball> _greenBalls;

    private bool _gameWin;
    public OneColorWin(List<Ball> redBalls, List<Ball> whiteBalls, List<Ball> greenBalls) {
        Debug.Log("Выбрано условие уничтожить шарики одного цвета");
        _redBalls = redBalls;
        _whiteBalls = whiteBalls;
        _greenBalls = greenBalls;
    }

    public void CheckWinCondition() {
        //  Debug.Log("Reds: " + _redBalls.Count + "Whites: " + _whiteBalls.Count + "Greens: " + _greenBalls.Count);
        if (_redBalls.Count < 1 || _whiteBalls.Count < 1 || _greenBalls.Count < 1) {
            Debug.Log("Вы выйграли!");
            _gameWin = true;
        }
    }

    public bool IsGameWin() {
        return _gameWin;
    }
}

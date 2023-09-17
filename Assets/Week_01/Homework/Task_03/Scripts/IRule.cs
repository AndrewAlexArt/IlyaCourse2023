using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IRule {
    void CheckWinCondition();
    bool IsGameWin();
}

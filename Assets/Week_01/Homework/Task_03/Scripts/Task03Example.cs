using System.Collections.Generic;
using UnityEngine;

public class Task03Example : MonoBehaviour {

    private Ball _selectedBall;
    private Ball[] _allBallsArray;
    [SerializeField] private List<Ball> _allBallsList;

    [SerializeField] private List<Ball> _redBallsList;
    [SerializeField] private List<Ball> _whiteBallsList;
    [SerializeField] private List<Ball> _greenBallsList;

    private Ball[] _redBallsArray;
    private Ball[] _whiteBallsArray;
    private Ball[] _greenBallsArray;

    private IRule _rules;
    private void Awake() {
        //  _rules = new AllDestroyedWin(_allBalls);
        Debug.Log("Выберите условие победы:");
        Debug.Log("Клавиша \"1\" - уничтожить все шарики");

        Debug.Log("Клавиша \"2\"- уничтожить шарики одного цвета");

        _allBallsArray = FindObjectsOfType<Ball>();
        _allBallsList.AddRange(_allBallsArray);

        _redBallsArray = FindObjectsOfType<RedBall>();
        _greenBallsArray = FindObjectsOfType<GreenBall>();
        _whiteBallsArray = FindObjectsOfType<WhiteBall>();

        _redBallsList.AddRange(_redBallsArray);
        _greenBallsList.AddRange(_greenBallsArray);
        _whiteBallsList.AddRange(_whiteBallsArray);
    }


    private void Update() {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit)) {
            var hitObject = hit.collider.gameObject;
            if (hitObject.TryGetComponent(out Ball ball))
                _selectedBall = ball;
        }

        if (Input.GetMouseButtonDown(0)) {
            if (_selectedBall != null && _rules != null && !_rules.IsGameWin()) {
                if (_selectedBall.GetComponent<RedBall>())
                    _redBallsList.Remove(_selectedBall);
                else if (_selectedBall.GetComponent<GreenBall>())
                    _greenBallsList.Remove(_selectedBall);
                else if (_selectedBall.GetComponent<WhiteBall>())
                    _whiteBallsList.Remove(_selectedBall);

                Destroy(_selectedBall.gameObject);
                _allBallsList.Remove(_selectedBall);
                _selectedBall = null;
                _rules.CheckWinCondition();
            }

            if (_rules == null)
                Debug.Log("Сначала выберите условие победы");
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
            _rules = new AllDestroyedWin(_allBallsList);

        else if (Input.GetKeyDown(KeyCode.Alpha2))
            _rules = new OneColorWin(_redBallsList, _whiteBallsList, _greenBallsList);

    }



}

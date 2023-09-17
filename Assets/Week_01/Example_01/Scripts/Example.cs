using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Example : MonoBehaviour {
    [SerializeField] private Sherif _sherif;

    [SerializeField] private Transform _target;

    [SerializeField] private List<Transform> _patrolPoints;

    private IMover _currentMover;

    private void Awake() {
        _sherif.Initialize(new NoMovePattern());
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Q)) {

            _sherif.SetMover(new NoMovePattern());
            Debug.Log("Everything is fine.");
        }
        if (Input.GetKeyDown(KeyCode.W)) {

            var newMover = new PointByPointMover(_sherif, _patrolPoints.Select(point => point.position));
            _sherif.SetMover(newMover);
            Debug.Log("Patroling...");
        }
        if (Input.GetKeyDown(KeyCode.E)) {
            _sherif.SetMover(new MoveToTargetPattern(_target, _sherif));
            Debug.Log("Chasing!..");
        }


    }
}

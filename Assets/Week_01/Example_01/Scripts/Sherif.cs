using System;
using TMPro;
using UnityEngine;

public class Sherif : MonoBehaviour, IMovable {

    [SerializeField] private float _speed;

    private IMover _mover;

    private bool _isInit;

    public float Speed => _speed;

    public Transform Transform => this.transform;

    public void Initialize(IMover mover) {
        SetMover(mover);
        _isInit = true;
    }

    private void Update() {
        if (_isInit == false)
            throw new InvalidOperationException(nameof(_isInit));

        _mover.Update(Time.deltaTime);
    }

    public void SetMover(IMover mover) {
        _mover?.StopMove();
        _mover = mover;
        _mover.StartMove();
    }


}

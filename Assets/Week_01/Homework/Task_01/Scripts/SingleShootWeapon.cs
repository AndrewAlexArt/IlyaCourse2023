using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleShootWeapon : IWeapon {
    private int _ammo;
    private int _maxAmmo;

    public SingleShootWeapon(int maxAmmo) {
        _maxAmmo = maxAmmo;
        _ammo = maxAmmo;

        if (_ammo < 0)
            throw new ArgumentOutOfRangeException(nameof(_ammo));
        Debug.Log($"������ ����� ���������� ����������. ���������� ��������: {_ammo}");
    }

    public void Reload() {
        _ammo = _maxAmmo;
        Debug.Log($"�����������...");
    }

    public void Shoot() {

        if (_ammo > 0) {
            _ammo--;
            Debug.Log($"������� ����������. ���������� ��������: {_ammo}");
        }
        else Debug.Log("������������ ��������");
    }
}

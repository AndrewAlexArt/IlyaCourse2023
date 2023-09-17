using System;
using UnityEngine;


public class MassShootWeapon : IWeapon {

    private int _ammo;
    private int _maxAmmo;
    private int _ammoPerShoot = 3;

    public MassShootWeapon(int ammo, int ammoPerShoot) {
        _ammo = ammo;
        _maxAmmo = ammo;
        _ammoPerShoot = ammoPerShoot;
        Debug.Log($"������ ����� ���� �������� � {ammoPerShoot} ��������� �� �������");
    }

    public void Reload() {
        _ammo = _maxAmmo;
        Debug.Log($"�����������...");
    }

    public void Shoot() {
        if (_ammo < 0)
            throw new ArgumentOutOfRangeException(nameof(_ammo));

        if (_ammo > _ammoPerShoot) {
            _ammo -= _ammoPerShoot;
            Debug.Log($"������� �� {_ammoPerShoot} �������. ���������� ��������: {_ammo}");
        }
        else Debug.Log("������������ ��������");
    }
}
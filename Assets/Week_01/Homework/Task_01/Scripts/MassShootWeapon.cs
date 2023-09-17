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
        Debug.Log($"Выбран режим масс стрельбы с {ammoPerShoot} патронами за выстрел");
    }

    public void Reload() {
        _ammo = _maxAmmo;
        Debug.Log($"Перезарядка...");
    }

    public void Shoot() {
        if (_ammo < 0)
            throw new ArgumentOutOfRangeException(nameof(_ammo));

        if (_ammo > _ammoPerShoot) {
            _ammo -= _ammoPerShoot;
            Debug.Log($"Стреляю по {_ammoPerShoot} патрона. Количество патронов: {_ammo}");
        }
        else Debug.Log("Недостаточно патронов");
    }
}
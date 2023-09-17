using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfinityShotWeapon : IWeapon {
    public InfinityShotWeapon() {
        Debug.Log("выбран режим бесконечных патронов");
    }

    public void Shoot() {
        Debug.Log("Стреляю из оружия с бесконечными патронами");
    }

    public void Reload() {

    }


}

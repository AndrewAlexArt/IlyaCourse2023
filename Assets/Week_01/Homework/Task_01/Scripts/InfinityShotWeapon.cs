using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfinityShotWeapon : IWeapon {
    public InfinityShotWeapon() {
        Debug.Log("������ ����� ����������� ��������");
    }

    public void Shoot() {
        Debug.Log("������� �� ������ � ������������ ���������");
    }

    public void Reload() {

    }


}

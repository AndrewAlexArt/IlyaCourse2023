using UnityEngine;

public class Task01Example : MonoBehaviour {

    private IWeapon _weapon;
    private void Awake() {
        //   _weapon = new SingleShootWeapon(10);
        Debug.Log($"1,2,3 - ����� ������ ��������.  R - �����������.  ��� - �������� ");
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Alpha1)) _weapon = new SingleShootWeapon(10);

        else if (Input.GetKeyDown(KeyCode.Alpha2)) _weapon = new InfinityShotWeapon();

        else if (Input.GetKeyDown(KeyCode.Alpha3)) _weapon = new MassShootWeapon(10, 3);


        if (Input.GetMouseButtonDown(0)) {
            if (_weapon == null) {
                Debug.Log("������� �������� ����� �������� (������� 1, 2 ��� 3)");
            }
            _weapon?.Shoot();
        }

        if (Input.GetKeyDown(KeyCode.R)) {
            _weapon?.Reload();  //����� ����������� �� �����������, ��� ��� �� ������ ����� �������� ����� NEW. �� ������ �� �� ��������)
        }

    }
}

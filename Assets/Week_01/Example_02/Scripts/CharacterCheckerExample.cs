using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCheckerExample : MonoBehaviour {
    [SerializeField] private Orc _orc;
    [SerializeField] private List<Human> _humans;

    private void Awake() {
        foreach (Human human in _humans)
            human.Initialize(new NoViewPattern(), character => character is Human);

        _orc.Initialize(new SearchAroundPattern(_orc.transform, 5f), character => character is Orc);
    }

    private void OnDrawGizmos() {
        Gizmos.color = Color.yellow;
        Gizmos.DrawRay(_orc.transform.position + Vector3.up, _orc.transform.forward * 5);
        Gizmos.DrawWireSphere(_orc.transform.position, 5f);
    }
}

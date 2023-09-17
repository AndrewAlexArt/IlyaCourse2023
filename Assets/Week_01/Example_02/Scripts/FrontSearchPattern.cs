using System.Collections.Generic;
using UnityEngine;

public class FrontSearchPattern : ICharacterFinder {

    private float _viewingRange;
    private Transform _center;

    public FrontSearchPattern(Transform center, float viewingRange) {
        _viewingRange = viewingRange;
        _center = center;
    }

    public IEnumerable<Character> Find() {

        RaycastHit[] hits = Physics.RaycastAll(new Ray(_center.position + Vector3.up, _center.forward), _viewingRange);
        List<Character> findedCharacters = new List<Character>();

        foreach (RaycastHit hit in hits) {
            if (hit.transform.parent.TryGetComponent(out Character character))
                if (character.transform != _center)
                    findedCharacters.Add(character);


        }

        return findedCharacters;
    }
}

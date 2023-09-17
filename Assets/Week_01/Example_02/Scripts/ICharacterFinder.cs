using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICharacterFinder {
    IEnumerable<Character> Find();
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharactersHandler
{
    public List<GameObject> characters = new List<GameObject>();

    public static CharactersHandler _instance;
    public static CharactersHandler Instance {
        get {
            if (_instance == null){
                _instance = new CharactersHandler();

                
            }

            return _instance;
        }
    }

    public void AddCharacter(GameObject gameObject) {
        characters.Add(gameObject);
    }
}

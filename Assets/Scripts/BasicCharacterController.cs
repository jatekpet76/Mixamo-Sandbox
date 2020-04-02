using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicCharacterController : MonoBehaviour
{
    string _animesLst = "Boxing,Cheering,DancingRunningMan,Defeated,Jumping,OrcWalk,Patting,Running,SalsaDancing,SambaDancing,Walking";
    string[] _animes;

    // Start is called before the first frame update
    void Start()
    {
        _animes = _animesLst.Split(',');

        CharactersHandler.Instance.AddCharacter(gameObject);
    }



    // $ ls -1 | grep -v meta | sed 's/\.anim//' | tr '\n' ','
    

    // Update is called once per frame
    void Update()
    {
        
    }
}

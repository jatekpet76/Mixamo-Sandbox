using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimComposer : MonoBehaviour
{
    string _animesLst = "Boxing,Cheering,DancingRunningMan,Defeated,Jumping,OrcWalk,Patting,Running,SalsaDancing,SambaDancing,Walking";
    string[] _animes;

    void Start()
    {
        _animes = _animesLst.Split(',');

        StartCoroutine(DirectingCharacters());
    }

    IEnumerator DirectingCharacters()
    {
        while (true)
        {
            yield return new WaitForSeconds(5);

            foreach (GameObject character in CharactersHandler.Instance.characters) {

                var animator = character.GetComponent<Animator>();

                var animPos = Random.Range(0, _animes.Length);

                animator.Play(_animes[animPos]);
            }
        }

    }
}

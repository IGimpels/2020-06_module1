using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationEvents : MonoBehaviour
{
    Character character;

    // Start is called before the first frame update
    void Start()
    {
        character = GetComponentInParent<Character>();
    }

    void AttackEnd()
    {
        character.SetState(Character.State.RunningFromEnemy);
    }

    void MeleeHit()
    {
        character.target.GetComponentInParent<Character>().SetState(Character.State.BeginDie);
    }


    void ShootEnd()
    {
        character.target.GetComponentInParent<Character>().SetState(Character.State.BeginDie);
        character.SetState(Character.State.Idle);
    }
}

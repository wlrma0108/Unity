using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{
    public enum AttackDirection{
        left,right
    }
    public Collider2D Collider;
    public float damage = 3;
    Vector2 rightAttackOffset;
    public AttackDirection attackDirection;

    private void Start() {
        rightAttackOffset = transform.position;
    }
    public void Attack(){
        switch(attackDirection){
            case AttackDirection.left:
                AttackLeft();
                break;
            case AttackDirection.right:
                AttackRight();
                break;
        }
    }

    public void AttackRight() {
        Collider.enabled = true;
        transform.localPosition = rightAttackOffset;
    }
    
    public void AttackLeft() {
        Collider.enabled = true;
        transform.localPosition = new Vector3(rightAttackOffset.x * -1, rightAttackOffset.y);
    }

    public void StopAttack() {
        Collider.enabled = false;
    }

   
}

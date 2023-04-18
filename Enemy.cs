using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int MaxHp;
    public int Hp;
    public int AttackDamage;
    public string AttackName;
    public string tagObject;
    public float AttackCollDawn;
    public float AttackCollDawnForUnity;
    private Health health;
    private Animator anim;
    public Transform item;



    void Start()
    {
        Hp = MaxHp;

    }

    public void TakeDamage( int damage ){
        
        Hp -= damage;
        if (Hp <= 0){
            Die();
        }
    }
    void Die(){
        Destroy(gameObject);
        if (tagObject == "Enemy"){
            Instantiate(item, transform.position, transform.rotation);
            Debug.Log("Enemy Die");

        }
        else if (tagObject == "Chest")
        {
            Instantiate(item, transform.position, transform.rotation);
            Debug.Log("Chest Die");
        }
    }
    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == AttackName )
        {   
             AttackCollDawnForUnity = AttackCollDawn;
             Health health = coll.gameObject.GetComponent<Health>();
             health.TakeHit(AttackDamage);
        }   


    }    
}

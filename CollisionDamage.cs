using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDamage : MonoBehaviour
{
    public int collisionDamage = 10;
    public string collisionTag;
    public string collisionTagSecond;

    private void OnCollisionEnter2D(Collision2D coll)
    {
        //Если тег объекта коллайдер которого столкнулся с коллайдером нашего объекта - Player
        if (coll.gameObject.tag == collisionTag || coll.gameObject.tag == collisionTagSecond)
        {
            //Берём у этого объекта компонент Health (Скрипт который на нём висит)
            Health health = coll.gameObject.GetComponent<Health>();

            health.TakeHit(collisionDamage);
        }
    }
}

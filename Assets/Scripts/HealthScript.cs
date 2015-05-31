using UnityEngine;
using System.Collections;

public class HealthScript : MonoBehaviour
{

    public static float hp = 5f;
    public Animation anim;
   // public GameObject Player;
    public void Start()
    {
        this.anim = this.GetComponent<Animation>();
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            if (anim.IsPlaying("PlayerHit"))  // trqbva mi proverka dali isplaying animation e playerhit za PLAYER-a, A NE ZA KOETO I DA E
            {

                Destroy(collision.gameObject);
                Debug.Log("collision");
                
            }
            else hp -= 1f;
            if (hp <= 0f) Application.LoadLevel("DeadScene");
        }
    }

    /* void onTriggerEnter2D(Collider2D collider)
     {
         shotScript shot = collider.gameObject.GetComponent<shotScript>();
         if (shot != null)
         {
             if (shot.isEnemyShot != isEnemy)
             {
                 hp -= shot.damage;
                 Destroy(shot.gameObject);
                 if (hp <= 0) { Destroy(gameObject); }
             }
         }
     } */
}


using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour
{

    public Vector2 speed = new Vector2(4, 8);
    public Vector2 direction = new Vector2(-1, 0);
  //  public Collider2D collider;
    //public void Start() { this.collider = this.GetComponent<Collider2D>(); }
    public Animation anim;
    public void Start()
    {
        this.anim = this.GetComponent<Animation>();
    }
    public void Update()
    {
        Vector3 movement = new Vector3(speed.x * direction.x, speed.y * direction.y, 0);
        movement *= Time.deltaTime / 2;
        transform.Translate(movement);
        

    }
    public void OnTriggerEnter2D(Collider2D collider) 
    {
        if (collider.gameObject.tag == "Player")
        {
            if (anim.IsPlaying("PlayerHit"))  
            {

                Destroy(gameObject);
             
            }
            //if (collider.gameObject.animation("PlayerHit"))
            else Destroy(collider.gameObject);
        }
    }

}

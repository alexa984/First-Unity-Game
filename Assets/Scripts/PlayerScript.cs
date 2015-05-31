//using UnityEngine;
//using System.Collections;

//public class PlayerScript : MonoBehaviour
//{ 
//    public Vector2 speed = new Vector2(4, 8);
//    public Animator anim;
   
//    public void Start()
//    {
//        this.anim = GetComponent<Animator>();
//    }
        
//    public void Update()
//    {   
        
//            float inputX = Input.GetAxis("Horizontal");
//            float inputY = Input.GetAxis("Vertical");
//            anim.SetInteger("PlayerRunning", 1);
//            // anim.Play("PlayerRunning");
//            Vector3 movement = new Vector3(speed.x * inputX, speed.y * inputY, 0);
//            movement *= Time.deltaTime;
//            transform.Translate(movement);


using UnityEngine;
public class PlayerScript : MonoBehaviour
{
    public float speed = 2f;
    private Animator animator;

 

   // public GameObject enemy;
    public void Start()
    {
        this.animator = this.GetComponent<Animator>();
    }
    public void Update()
    {
        animator.SetInteger("PlayerState", 0);
        

       
        if (Input.anyKey)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                animator.Play("PlayerHit");

            }
            if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
            {
                animator.SetInteger("PlayerState", 3);


                Vector2 myPosition = new Vector2(this.transform.position.x, this.transform.position.y);
                Mathf.Clamp(myPosition.y, 0.644f, 1f);
                myPosition += Vector2.up;
                this.transform.position = myPosition;

            }

            if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
            {
                animator.SetInteger("PlayerState", 1);
                var scale = transform.localScale;
                var sign = 1;

                if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
                {
                    // left
                    if (scale.x < 0)
                    {
                        scale.x *= -1;
                    }
                  //  sign = -1;
                }

                else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
                {
                    // right
                    if (scale.x > 0)
                    {
                        scale.x *= -1;
                    }
                       sign = -1;
                }

                this.transform.localScale = scale;

                transform.position = new Vector3(transform.position.x + (speed * Time.deltaTime * sign), transform.position.y, 0);

            }
        }
    }
}
         

//    }

    
//}

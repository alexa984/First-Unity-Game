using UnityEngine;
using System.Collections;

public class BKGCollideScript : MonoBehaviour {
    public void OnTriggerEnter2D(Collider2D collider) {

        if (collider.CompareTag("Background")) 
        {
            var background = collider.gameObject;
            var bgPosition = background.transform.position;
            bgPosition.x += 22f;
            background.transform.position = bgPosition;
        }
        if (collider.CompareTag("Ground")) 
        {
            var ground = collider.gameObject;
            var grPosition = ground.transform.position;
            grPosition.x += 22f;
            ground.transform.position = grPosition;
        }
        if (collider.CompareTag("Cloud"))
        {
            var cloud = collider.gameObject;
            var clPosition = cloud.transform.position;
            clPosition.x += 21.5f;
            cloud.transform.position = clPosition;
        }
        if (collider.CompareTag("Coin"))
        {
            Debug.Log("collision");
            var coin = collider.gameObject;
            var coPosition = coin.transform.position;
            coPosition.x += 13.4f;
            coin.transform.position = coPosition;
           // Destroy(collider.gameObject);
        }
    
    }
}

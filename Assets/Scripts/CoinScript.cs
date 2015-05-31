using UnityEngine;
public class CoinScript : MonoBehaviour
{
    private float totalScore = 0f;
    string scoreText;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            totalScore += 10;
            scoreText = "Score: " + totalScore;
            
            Debug.Log(totalScore);

            //Destroy(collision.gameObject);
    
            var coin = collision.gameObject;
            var coPosition = coin.transform.position;
            coPosition.x += 18.8f;
            coin.transform.position = coPosition;
        }
    }
    public void OnGUI() {
        GUI.color = Color.black;
        GUI.Label( new Rect(10, 10, 100, 20), scoreText); }


}

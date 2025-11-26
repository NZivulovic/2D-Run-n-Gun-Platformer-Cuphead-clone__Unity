using UnityEngine;

public class enemyFollow : MonoBehaviour
{
    private Rigidbody2D rb;
    private GameObject player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");

        
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(player != null)
        {
        Vector3 playerPos = player.transform.position - transform.position;
        rb.linearVelocity = new Vector2(playerPos.x, playerPos.y + 20);
        }
    }
}

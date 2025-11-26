using UnityEngine;

public class followBossHands : MonoBehaviour
{
    private Rigidbody2D rb;
    public GameObject enemy;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 enemyPos = enemy.transform.position - transform.position;
        rb.linearVelocity = new Vector2(enemyPos.x, enemyPos.y);
    }
}

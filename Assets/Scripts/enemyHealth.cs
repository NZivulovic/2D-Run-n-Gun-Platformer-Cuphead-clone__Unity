using UnityEngine;

public class enemyHealth : MonoBehaviour
{
    public int maxHealth;
    public int health;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        health += maxHealth;
    }
    void Start()
    {
        
    }

    public void takeDamageEnemy(int damage)
    {
        health -= damage;
        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }
}

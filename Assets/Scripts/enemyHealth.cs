using UnityEngine;

public class enemyHealth : MonoBehaviour
{
    public int maxHealth;
    private int health;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health += maxHealth;
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

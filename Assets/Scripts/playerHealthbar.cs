using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class playerHealthbar : MonoBehaviour
{
    private GameObject player;
    private float playerHealthMax;
    private float playerHealth;
    private Slider Slider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerHealthMax = player.GetComponent<playerHealth>().maxHealth;
        playerHealth = player.GetComponent<playerHealth>().health;
        Slider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        if(player != null)
        {
            playerHealthMax = player.GetComponent<playerHealth>().maxHealth;
            playerHealth = player.GetComponent<playerHealth>().health;
            Slider.value = playerHealth / playerHealthMax;
        }
        if(player == null)
        {
            Slider.value = 0;
            return;
        }
    }
}

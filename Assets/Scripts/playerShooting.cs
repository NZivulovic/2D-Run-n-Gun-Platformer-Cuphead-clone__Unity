using Unity.Mathematics;
using UnityEngine;

public class playerShooting : MonoBehaviour
{
    public GameObject projectile;
    public RectTransform projectileStartPosX;
    public RectTransform projectileStartPosYleft;
    public RectTransform projectileStartPosYright;

    private float timer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > .5){
        shoot();
        }
    }
    private void shoot()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Instantiate(projectile, projectileStartPosX.position, quaternion.identity);
            timer = 0;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Instantiate(projectile, projectileStartPosYleft.position, quaternion.identity);
            timer = 0;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Instantiate(projectile, projectileStartPosYright.position, quaternion.identity);
            timer = 0;
        }
        
    }
}

using UnityEngine;

public class firepointScript : MonoBehaviour
{
    public playerMovement playerMovement;
    public float lastDirection;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponentInParent<playerMovement>();
        lastDirection = playerMovement.direction;
    }

    // Update is called once per frame
    void Update()
    {   
        if (playerMovement.direction == 1)
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 0f); // Facing right
        }
        else if (playerMovement.direction == -1)
        {
            transform.rotation = Quaternion.Euler(0f, 180f, 0f); // Facing left
        }
    }
}

using UnityEngine;

public class bulletScript : MonoBehaviour
{
    public float speed = 20f;
    public int dmg = 25;
    public Rigidbody2D rb;

    private void FixedUpdate()
    {
        rb.linearVelocity = transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        enemyScript enemy = hitInfo.GetComponent<enemyScript>();
        if (enemy != null) {
            enemy.TakeDamage(dmg);
        }
        gameObject.SetActive(false);
    }
}

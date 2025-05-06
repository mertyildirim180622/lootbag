using UnityEngine;

public class enemyScript : MonoBehaviour
{
    public int hp = 100;

    public void TakeDamage (int dmg) {
        hp -= dmg;

        if (hp <= 0) {
            Die();
        }
    }

    void Die () {
        GameManager.instance.AddScore(1);
        Destroy(gameObject);
    }
}

using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform FirePoint;
    public GameObject bulletPrefab;

    // Update is called once per frame
    void Update()
    {
       if (Input.GetButtonDown("Fire1")) {
            Debug.Log("Mouse click detected");
            Shoot();
       } 
    }

    void Shoot() {
        Debug.Log("Trying to shoot");
             GameObject bullet = ObjectPool.instance.GetPooledObject();

        if (bullet != null) {
            bullet.transform.position = FirePoint.position;
            bullet.SetActive(true);
        }
    }
}

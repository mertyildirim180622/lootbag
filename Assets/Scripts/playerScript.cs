using UnityEngine;

public class playerScript : MonoBehaviour
{
    Animator anmtr;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anmtr = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")) {
            anmtr.Play("Player_shoot");
        }
    }
}

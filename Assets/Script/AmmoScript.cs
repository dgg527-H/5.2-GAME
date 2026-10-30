using UnityEngine;

public class AmmoScript : MonoBehaviour
{
    public float ammo = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "AmmoBox")
        {
            ammo = ammo + 20;
            other.gameObject.SetActive(false);

        }
    }
}

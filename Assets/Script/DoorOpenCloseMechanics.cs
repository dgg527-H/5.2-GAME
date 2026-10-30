using UnityEngine;

public class DoorOpenCloseMechanics : MonoBehaviour
{

    //public float max = 12.0f;


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
        GameObject parent = transform.parent.gameObject;       
        Animation animation = parent.GetComponent<Animation>();       
        animation.Play("OpenDoor");
    }
}

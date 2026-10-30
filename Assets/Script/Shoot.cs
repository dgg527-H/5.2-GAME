using UnityEngine;

public class Shoot : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0)) {
            Ray ray =  Camera.main.ViewportPointToRay(new Vector3(0.5f ,0.5f ,0.0f));
        }
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Target")
        {
            other.gameObject.SetActive(false);

        }
    }


    


    // On mouse down we create a raycast
    // If the raycast hits the target (RaycastHit result;)
    //      Move draebridge down
}

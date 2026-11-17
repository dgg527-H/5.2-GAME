using UnityEngine;


public class MonsterRunning : MonoBehaviour
{

    public float min=2f;
	public float max=100f;
    public bool reachEnd = false;
    public AudioSource otherClip;
    AudioSource scream;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        min=transform.position.x;
		max=transform.position.x+30;
        scream = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position =new Vector3(Mathf.PingPong(Time.time*2,max-min)+min, transform.position.y, transform.position.z);


        if (Mathf.Abs(transform.position.x - max) <= 0.5f){
            reachEnd = true;
            scream.clip = otherClip;
            scream.play();
            
        }
        else{
            reachEnd = false;
            
        }
    }
}

using UnityEngine;
using System.Collections;

public class Badger : MonoBehaviour
{
    public AnimationClip anim;
    public float speed;

	// Use this for initialization
	void Start ()
    {
        speed = 5;
	}
	
	// Update is called once per frame
	void Update ()
    {
        Move();
	}

    void Move()
    {
        float move = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            
            transform.Translate(move, 0, 0);
        }
    }
}

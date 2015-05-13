using UnityEngine;
using System.Collections;

public class CameraSettings : MonoBehaviour
{
    public float orthographicSize; // pitäis tulostaa kameran koko / 2

    public float speed;

	// Use this for initialization
	void Start ()
    {
        
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	    
	}

    private void FixedUpdate()
    {
        MoveCamera();
    }

    private void MoveCamera()
    {
        Vector3 move = new Vector3(speed * Time.deltaTime, 0);
        transform.Translate(move);
    }
}

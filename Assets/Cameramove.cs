using UnityEngine;
using System.Collections;

public class Cameramove : MonoBehaviour 
{
    public Transform Target;
    public Vector3 OffSet;
    public float speed = 5;
	// Use this for initialization

	
	// Update is called once per frame
	void Update () 
    {
        transform.position = Vector3.Lerp(transform.position, Target.position, speed * Time.deltaTime);
        transform.rotation = Quaternion.Lerp(transform.rotation, Target.rotation, speed * Time.deltaTime);
	}
}

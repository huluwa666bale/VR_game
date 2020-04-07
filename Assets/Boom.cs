using UnityEngine;
using System.Collections;

public class Boom : MonoBehaviour
{

    public GameObject BoomPerfab;
    // Use this for initialization
    void Start()
    {

    }

    void OnCollisionEnter(Collision other)
    {


        GameObject go = Instantiate(BoomPerfab, gameObject.transform.position, gameObject.transform.rotation) as GameObject;
        Destroy(gameObject);
        Destroy(go, 5f);
    }
}

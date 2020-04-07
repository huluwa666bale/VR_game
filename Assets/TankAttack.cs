using UnityEngine;
using System.Collections;

public class TankAttack : MonoBehaviour
{
    public GameObject go;//炮弹
    public Transform goTrans;//炮弹生成点

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Attack();
    }

    /// <summary>
    /// 
    /// 坦克的攻击
    /// </summary>
    void Attack()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //克隆炮弹
          GameObject gos=  Instantiate(go, goTrans.position, goTrans.rotation) as GameObject;
            //给炮弹初速度
           gos.GetComponent<Rigidbody>().velocity = gos.transform.up * 50;
        }
    }
}

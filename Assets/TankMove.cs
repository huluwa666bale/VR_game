using UnityEngine;
using System.Collections;

public class TankMove : MonoBehaviour
{
    public float speed=3;
    public Transform cube;
    public Transform Axis;
    public Transform Cylinder;
    public Transform CylinderAxis;
    int i = 0;
    int j = 0;
    Vector3 temp;
    Vector3 temp1;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    /// <summary>
    /// 每一帧调用
    /// </summary>
    void Update()
    {
        //获取两个虚拟轴
        float v = Input.GetAxis("Vertical");
        float h= Input.GetAxis("Horizontal");
        //Debug.Log(v);

        Move(v,h);

    }

    void Move(float v, float h)
    {
        transform.Translate(0, 0, v * Time.deltaTime * speed);
        transform.Rotate(0, h * Time.deltaTime * speed * 5, 0);
        foreach (Transform item in transform.Find("Wheel1"))
        {
            item.RotateAround(item.position, item.up, -v * 2);
        }
        foreach (Transform item in transform.Find("Wheel2"))
        {
            item.RotateAround(item.position, item.up, -v * 2);
        }

        cube.Rotate(Axis.up, Input.GetAxis("Mouse X"));
        if (Input.GetKey(KeyCode.Q))
        {
            Cylinder.RotateAround(CylinderAxis.position, CylinderAxis.right, -1);
            Cylinder.localEulerAngles = new Vector3(Cylinder.localEulerAngles.x, 0, 0);
        }
        if (Input.GetKey(KeyCode.E))
        {
            Cylinder.RotateAround(CylinderAxis.position, CylinderAxis.right, 1);
            Cylinder.localEulerAngles = new Vector3(Cylinder.localEulerAngles.x, 0, 0);
        }
        if (Cylinder.localEulerAngles.x <= 50)
        {
            i++;
            if (i == 1)
                temp = Cylinder.localPosition;
            Cylinder.localEulerAngles = new Vector3(50, 0, 0);
            Cylinder.localPosition = temp;
        }
        if (Cylinder.localEulerAngles.x >= 89)
        {
            j++;
            if (j == 1)
                temp1 = Cylinder.localPosition;
            Cylinder.localEulerAngles = new Vector3(89, 0, 0);
            Cylinder.localPosition = temp1;
        }

    }
}



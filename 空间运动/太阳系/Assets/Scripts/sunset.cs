using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sunset : MonoBehaviour
{
    public Transform sun;
    public Transform mercury;
    public Transform venus;
    public Transform earth;
    public Transform mars;
    public Transform jupiter;
    public Transform saturn;
    public Transform uranus;
    public Transform neptune;
    public Transform moon;
    // Use this for initialization
    Vector3[] a = new Vector3[9];
    float speed = 40;
    float y, z;
    void Start()
    {
        int i = 0;
        for (i = 0; i < 9; i++)
        {
            y = Random.Range(1, 360); // 随机设置角度
            z = Random.Range(1, 360); // 随机设置角度
            a[i] = new Vector3(0, y, z); // 以上是为了制造不同的运动法平面，修改y和z可以使得绕不同的轴转
        }
    }

    // Update is called once per frame
    void Update()
    { // 每个星球的旋转动作，用到了初始化的a[i]
        mercury.RotateAround(sun.position, a[0], speed * Time.deltaTime);
        mercury.Rotate(Vector3.up * speed * Time.deltaTime);
        venus.RotateAround(sun.position, a[1], speed * Time.deltaTime);
        venus.Rotate(Vector3.up * speed * Time.deltaTime);
        earth.RotateAround(sun.position, a[2], speed * Time.deltaTime);
        earth.Rotate(Vector3.up * speed * Time.deltaTime);
        mars.RotateAround(sun.position, a[3], speed * Time.deltaTime);
        mars.Rotate(Vector3.up * speed * Time.deltaTime);
        jupiter.RotateAround(sun.position, a[4], speed * Time.deltaTime);
        jupiter.Rotate(Vector3.up * speed * Time.deltaTime);
        saturn.RotateAround(sun.position, a[5], speed * Time.deltaTime);
        saturn.Rotate(Vector3.up * speed * Time.deltaTime);
        uranus.RotateAround(sun.position, a[6], speed * Time.deltaTime);
        uranus.Rotate(Vector3.up * speed * Time.deltaTime);
        neptune.RotateAround(sun.position, a[7], speed * Time.deltaTime);
        neptune.Rotate(Vector3.up * speed * Time.deltaTime);
        moon.RotateAround(earth.position, Vector3.right, 400 * Time.deltaTime);
    }
}

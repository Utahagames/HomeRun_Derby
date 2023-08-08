using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetDrawing : SingletonMonoBehaviour<TargetDrawing>
{
    [SerializeField] GameObject TargetMark;

    public Vector3 Target_position;

    GameObject Target_Instant;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void DrawingTarget()
    {
        float rndX = Random.Range(-1.5f, 1.5f);
        float rndY = Random.Range(-1.5f, 1.5f);

        // ボールマーク生成位置
        Vector3 pos = new Vector3(rndX, rndY, 0.0f);
        // ボールマークを指定位置に生成
        Target_Instant = Instantiate(TargetMark, pos, Quaternion.identity);

        Target_position = pos;
    }

    public void DestroyTarget()
    {
        Destroy(Target_Instant);
    }
}

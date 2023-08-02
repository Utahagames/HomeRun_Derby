using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDrawing : MonoBehaviour
{
    [SerializeField] GameObject ball_HitMark;

    public Vector3 ball_position;

    // Start is called before the first frame update
    void Start()
    {
        DrawingBall();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DrawingBall()
    {
        float rndX = Random.Range(-1.5f, 1.5f);
        float rndY = Random.Range(-1.5f, 1.5f);

        // ボールマーク生成位置
        Vector3 pos = new Vector3(rndX, rndY, 0.0f);
        // ボールマークを指定位置に生成
        Instantiate(ball_HitMark, pos, Quaternion.identity);

        ball_position = pos;
    }
}

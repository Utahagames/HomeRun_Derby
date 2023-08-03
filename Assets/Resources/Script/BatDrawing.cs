using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatDrawing : MonoBehaviour
{
    [SerializeField] GameObject Bat_HandSide;
    [SerializeField] GameObject Bat_EdgeSide;

    [SerializeField] LineRenderer _lineRenderer;

    [SerializeField] EdgeCollider2D _edgeCollider2D;

    //[SerializeField] PolygonCollider2D _polygonCollider2D;

    public float _width;

    Transform transform_HandSide;
    Transform transform_EdgeSide;

    // Start is called before the first frame update
    void Start()
    {
        transform_HandSide = Bat_HandSide.transform;
        transform_EdgeSide = Bat_EdgeSide.transform;

        DrawingBat();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DrawingBat()
    {
        Vector3[] positions = new Vector3[]
        {
            transform_HandSide.position,               // 開始点
            transform_EdgeSide.position               // 終了点
        };

        //始点、終点の幅を変更
        _lineRenderer.startWidth = _width;
        _lineRenderer.endWidth = _width;

        // 線を引く場所を指定する
        _lineRenderer.SetPositions(positions);

        SettingEdgeCollider();
        //SettingPolygonCollider();
    }

    void SettingEdgeCollider()
    {
        List<Vector2> collider_positions = new List<Vector2>
        {
            new Vector2( transform_HandSide.position.x ,transform_HandSide.position.y),               // 開始点
            new Vector2( transform_EdgeSide.position.x ,transform_EdgeSide.position.y)             // 終了点
        };

        _edgeCollider2D.SetPoints(collider_positions);
    }

    void SettingPolygonCollider()
    {
        List<Vector2> collider_positions = new List<Vector2>
        {
            new Vector2( transform_HandSide.position.x ,transform_HandSide.position.y + 0.01f),               // 開始点
            new Vector2( transform_EdgeSide.position.x ,transform_EdgeSide.position.y + 0.01f),
            new Vector2( transform_EdgeSide.position.x ,transform_EdgeSide.position.y - 0.01f),
            new Vector2( transform_HandSide.position.x ,transform_HandSide.position.y - 0.01f)            // 終了点
        };

        //_polygonCollider2D.SetPath( 0, collider_positions);
    }

    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        //Debug.Log("当たっている");
    }

}

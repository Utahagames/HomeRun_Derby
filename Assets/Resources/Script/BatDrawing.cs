using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatDrawing : MonoBehaviour
{
    [SerializeField] GameObject Bat_HandSide;
    [SerializeField] GameObject Bat_EdgeSide;

    [SerializeField] LineRenderer _lineRenderer;

    [SerializeField] EdgeCollider2D _edgeCollider2D;

    public float _width;

    Transform transform_HandSide;
    Transform transform_EdgeSide;

    bool TouchToTarget = false;

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
            transform_HandSide.position,               // �J�n�_
            transform_EdgeSide.position               // �I���_
        };

        //�n�_�A�I�_�̕���ύX
        _lineRenderer.startWidth = _width;
        _lineRenderer.endWidth = _width;

        // ���������ꏊ���w�肷��
        _lineRenderer.SetPositions(positions);

        SettingEdgeCollider();
    }

    void SettingEdgeCollider()
    {
        List<Vector2> collider_positions = new List<Vector2>
        {
            new Vector2( transform_HandSide.position.x ,transform_HandSide.position.y),               // �J�n�_
            new Vector2( transform_EdgeSide.position.x ,transform_EdgeSide.position.y)             // �I���_
        };

        _edgeCollider2D.SetPoints(collider_positions);
    }

    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        TouchToTarget = true;
    }

    // �Q�[���I�u�W�F�N�g���m���ڐG���痣�ꂽ�^�C�~���O�Ŏ��s
    void OnTriggerExit2D(Collider2D otherCollider)
    {
        TouchToTarget = false;
    }

    public bool JudgeHit()
    {
        return TouchToTarget;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatMovement : MonoBehaviour
{
    [SerializeField] GameObject Bat_HandSide;
    [SerializeField] GameObject Bat_EdgeSide;

    [SerializeField] Vector3 moveUP_Speed;
    [SerializeField] Vector3 moveDown_Speed;

    [SerializeField] BatDrawing batDrawing;

    Transform transform_HandSide;
    Transform transform_EdgeSide;

    // Start is called before the first frame update
    void Start()
    {
        transform_HandSide = Bat_HandSide.transform;
        transform_EdgeSide = Bat_EdgeSide.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            if(transform_HandSide.position.y <= 1.5f)
            {
                transform_HandSide.position += moveUP_Speed * Time.deltaTime;

                batDrawing.DrawingBat();
            } 
        }
        else if (Input.GetKey(KeyCode.S))
        {
            if (transform_HandSide.position.y >= -1.5f)
            {
                transform_HandSide.position += moveDown_Speed * Time.deltaTime;

                batDrawing.DrawingBat();
            }
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (transform_EdgeSide.position.y <= 1.5f)
            {
                transform_EdgeSide.position += moveUP_Speed * Time.deltaTime;

                batDrawing.DrawingBat();
            }
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            if (transform_EdgeSide.position.y >= -1.5f)
            {
                transform_EdgeSide.position += moveDown_Speed * Time.deltaTime;

                batDrawing.DrawingBat();
            }
        }
    }
}

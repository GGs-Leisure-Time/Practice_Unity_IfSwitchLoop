using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triangle : MonoBehaviour
{
    private float length = 10;
    private float width = 10;


    [Header("地板")]
    public GameObject cube;
    private void CreatFloor(int length, int width)
    {


        for (int j = 1; j < width; j++)
        {
            for (int i = 0; i < length; i++)
            {
                //API實例化(生成)
                //生成(物件、座標、角度)
                //Vector3三圍向量(保存三個浮點數)
                //Quaternion 角度
                //Quaternion.identity 零角度
                //Quaternion.Euler (x,y,z) 歐拉角度 - 0~360
                Instantiate(cube, new Vector3(j , i, 0 ), Quaternion.Euler(270, 0, 0));
            }
        }
    }

    private void Awake()
    {
        CreatFloor(10, 10);
    }

   


        // Start is called before the first frame update
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

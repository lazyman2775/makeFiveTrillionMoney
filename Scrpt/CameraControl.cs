using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public float rotateSpeed = 1f;
    private Camera mainCamera;
    private GameObject map;
    private float speed  = 100f;
    public float mapX; 
    public float mapXMax = 1000f; 
    public float mapXMin = -1000f;
    void Start()
    {
        mainCamera = GetComponent<Camera>();
        map = GameObject.FindGameObjectWithTag("Map");
        mapX=map.GetComponent<RectTransform>().rect.width/3;
    }
    
    void Update()
    {
        Rotate();
    }
    private void Rotate()
    {
        if (Input.GetMouseButton(0)){
            transform.position -=Input.GetAxis("Mouse X") * new Vector3(speed, 0,0)*Time.deltaTime; // 마우스 X 위치 * 회전 스피드
            //경계 계산
            float x = Mathf.Clamp(transform.position.x, -mapX, mapX);
            transform.position = new Vector3(x, 0, transform.position.z);
        }
    }
}

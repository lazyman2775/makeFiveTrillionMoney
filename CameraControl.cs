using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CameraControl : MonoBehaviour
{
    private Camera mainCamera;
    private GameObject map;
    //주석처리된 부분: UI 가 켜질 시 카메라의 움직임을 멈추는 코드
    /*private GameObject MapUI;
    private GameObject NoteUI;*/
    private float CameraWidth;
    public float speed  = 100f;
    private float mapX; 
    private string SceneName;
    void Start()
    {
        mainCamera = GetComponent<Camera>();
        CameraWidth = mainCamera.orthographicSize*Camera.main.aspect;
        map = GameObject.FindGameObjectWithTag("Map");
        mapX=map.GetComponent<Transform>().localScale.x*Camera.main.aspect;
        /*MapUI = GameObject.Find("MapUI");
        NoteUI = GameObject.Find("NoteUI");*/
        SceneName = SceneManager.GetActiveScene().name;
    }
    
    void Update()
    {
        Rotate();
        ChackScene();
    }
    private void Rotate()
    {
        if (Input.GetMouseButton(0)/*&&MapUI.activeSelf==false&&NoteUI.activeSelf==false*/){
            transform.position -=Input.GetAxis("Mouse X") * new Vector3(speed, 0,0)*Time.deltaTime; // 마우스 X 위치 * 회전 스피드
            //경계 계산
            float x = Mathf.Clamp(transform.position.x, -mapX, mapX);
            transform.position = new Vector3(x, 0, transform.position.z);
        }
    }
    private void ChackScene()
    {
        if(SceneName != SceneManager.GetActiveScene().name){
            SceneName = SceneManager.GetActiveScene().name;
            // 만약 Scene이 변경되었다면 다시 맵의 크기를 구하는 과정
            map = GameObject.FindGameObjectWithTag("Map");
            mapX=map.GetComponent<Transform>().localScale.x*Camera.main.aspect;
        }
    }
}

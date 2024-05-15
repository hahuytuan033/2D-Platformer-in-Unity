using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1 : MonoBehaviour
{
    public Transform player; 
    public Camera mainCamera; 
    public GameObject hiddenObject;

    void Update()
    {
        if (Mathf.Abs(player.position.x - 9.184486f) < 0.1f)
        {
            // Nếu có, dịch chuyển camera đến vị trí mới đã được chỉ định sẵn
            mainCamera.transform.position = new Vector3(18.01f, mainCamera.transform.position.y, -10f);

            // Hiển thị đối tượng có BoxCollider
            hiddenObject.SetActive(true);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchBehaviour : MonoBehaviour
{
    [SerializeField] DoorBehaviour doorBehaviour;
    [SerializeField] Animator switchAnimator; // Animator của cần gạt

    private bool isPlayerTouching = false;

    // Start is called before the first frame update
    void Start()
    {
        // Đặt animator về trạng thái ban đầu (Turn off)
        switchAnimator.SetBool("turn_on", false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayerTouching && Input.GetKeyDown(KeyCode.E))
        {
            // Kích hoạt DoorBehaviour
            doorBehaviour.isDoorOpen = true;

            // Kích hoạt animator của cần gạt
            switchAnimator.SetBool("turn_on", true);
        }
    }

    // Hàm này được gọi khi người chơi bắt đầu chạm vào cần gạt
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            isPlayerTouching = true;
        }
    }

    // Hàm này được gọi khi người chơi ngừng chạm vào cần gạt
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            isPlayerTouching = false;
            switchAnimator.SetBool("turn_on", false);
        }
    }
}

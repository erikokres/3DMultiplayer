using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomJump : MonoBehaviour
{
    [SerializeField]
    private float jumpHeight = 1.0f;
    [SerializeField]
    private float gravityValue = -9.81f;
    
    private CharacterController controller;
    private Vector3 cpuVelocity;
    private float startDelay = 2.0f;
    private float targetTime;
    [SerializeField] private bool groundedCpu;
    // Start is called before the first frame update
    void Start()
    {
        targetTime = 2;
        controller = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        groundedCpu = controller.isGrounded;
        targetTime -= Time.deltaTime;
        if (targetTime <= 0)
        {
            Jumping();
            targetTime = Random.Range(3,6);
        }
    }

    public void Jumping(){
        cpuVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
    }
}

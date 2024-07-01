using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed = 1f;
    [SerializeField] private float _fallMultiplier = 2.5f;
    [SerializeField] private Rigidbody _rb;
    private Camera cam;

    void Start()
    {
        cam = Camera.main;
    }

    private void Update()
    {
        var dir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        _rb.velocity = new Vector3(dir.x * _speed, _rb.velocity.y, dir.z * _speed);

        Vector3 playerPos = cam.WorldToScreenPoint(transform.position);
        Vector3 lookDir = Input.mousePosition - playerPos;
        transform.rotation = Quaternion.LookRotation(new Vector3(lookDir.x, 0, lookDir.y));

        if (_rb.velocity.y < 0)
        {
            _rb.velocity += Vector3.up * Physics.gravity.y * (_fallMultiplier - 1) * Time.deltaTime;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementDisplayController : MonoBehaviour
{
    private RectTransform _parentRt, _rt;
    private float _radius;

    void Start()
    {
        _rt = transform.GetComponent<RectTransform>();
        _parentRt = transform.parent.transform.GetComponent<RectTransform>();
        Vector3 parentSize = _parentRt.sizeDelta;
        _radius = parentSize.x / 2;
    }

    void Update()
    {
        Vector2 inputDir = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        float x = Mathf.Lerp(-_radius, _radius, (inputDir.x + 1) / 2);
        float y = Mathf.Lerp(-_radius, _radius, (inputDir.y + 1) / 2);
        _rt.localPosition = Vector3.ClampMagnitude(new Vector3(x, y, 0), _radius);
    }
}
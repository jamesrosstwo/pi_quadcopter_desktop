using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StatusController : MonoBehaviour
{
    private TextMeshProUGUI _tmpGui;
    private Material _on;
    private Material _off;
    private Material _error;
    private Renderer _renderer;

    public void Start()
    {
        _on = Resources.Load("Materials/On", typeof(Material)) as Material;
        _off = Resources.Load<Material>("Materials/Error");
        _error = Resources.Load<Material>("Materials/Warning");
        _tmpGui = gameObject.GetComponent<TextMeshProUGUI>();
        _renderer = transform.Find("Bar").gameObject.GetComponent<Renderer>();
    }

    public void Update()
    {
        try
        {
            switch (Quadcopter.Data.status)
            {
                case "on":
                    _renderer.material = _on;
                    break;
                case "off":
                    _renderer.material = _off;
                    break;
                default:
                    _renderer.material = _error;
                    break;
            }
            _tmpGui.text = Quadcopter.Data.status;

        }
        catch(NullReferenceException e)
        {
            _renderer.material = _error;
            _tmpGui.text = "off";
        }
    }
}
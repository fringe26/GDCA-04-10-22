using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.FilePathAttribute;

public class CubeScript : MonoBehaviour
{
    [SerializeField]
    private string _playerName = "CubePlayer";
    [SerializeField]
    private float _health = 100f;
    [SerializeField]
    private float _speed = 20f;
    [SerializeField]
    private Vector3 _location = Vector3.zero;

    private SphereScript _sphereScript;
    private Renderer _manageColor;

    void Start()
    {
        _sphereScript = GameObject.FindObjectOfType<SphereScript>();
        _manageColor = _sphereScript.GetComponent<Renderer>();
        _manageColor.material.color = Color.green;

        Debug.Log(_sphereScript);
    }

    public override string ToString()
    {
        return $"\nPlayer name : {_playerName}\n" +
               $"Player Health : {_health}\n" +
               $"Player Speed : {_speed}\n" +
               $"Player Location : x - {_location.x}; y - {_location.y}; z - {_location.z};";
    }

}

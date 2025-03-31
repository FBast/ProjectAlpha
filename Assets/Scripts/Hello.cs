using UnityEngine;

public class Hello : MonoBehaviour
{

    public float Horizontal;
    public float Vertical;
    public float Speed;
    
    private void Update()
    {
        Horizontal = Input.GetAxis("Horizontal") * Speed;
        Vertical = Input.GetAxis("Vertical") * Speed;
        transform.Rotate(Vertical, Horizontal, 0);
    }
}

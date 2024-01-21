using UnityEngine;

public class Scr_PlayerInput : MonoBehaviour
{

    public Debugger debugger;
    [Header("Debugging")]
    [SerializeField] bool dashInput;
    [SerializeField] bool mouseInput;
    [SerializeField] bool reloadInput;


    public Vector2 InputDirection()
    {
        float moveY = Input.GetAxisRaw("Vertical");
        float moveX = Input.GetAxisRaw("Horizontal");
       
        if (moveY != 0 || moveX != 0)
        {
            return new Vector2(moveX, moveY).normalized;
        }
        else
        {
            return  Vector2.zero;
        }

    }

    public bool DashInput()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            debugger.Log("Dash Input Works", dashInput);
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool FireInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            debugger.Log("Mouse Input Works", mouseInput);
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool ReloadInput()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            debugger.Log("Reload Input Works", reloadInput);
            return true;
        }
        else
        {
            return false;
        }
    }




}

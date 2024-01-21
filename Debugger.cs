using UnityEngine;

public class Debugger : MonoBehaviour
{

    [SerializeField] bool startDebugging;


   public void Log(string message,bool debugging)
    {
        if (startDebugging && debugging)
        {
            Debug.Log(message);
        }
    }

    public void Log(float message, bool debugging)
    {
        if (startDebugging && debugging)
        {
            Debug.Log(message.ToString());
        }
    }
    public void Log(int message, bool debugging)
    {
        if (startDebugging && debugging)
        {
            Debug.Log(message.ToString());
        }
    }
    public void Log(string message)
    {
        if (startDebugging)
        {
            Debug.Log(message.ToString());
        }
    }



}

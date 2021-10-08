using UnityEngine;

public class Master : MonoBehaviour, iCopyable
{
    public iCopyable Copy()
    {
        return Instantiate(this);
    }
}

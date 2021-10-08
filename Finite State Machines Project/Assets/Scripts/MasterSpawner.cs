using UnityEngine;

public class MasterSpawner : MonoBehaviour
{
    public iCopyable m_Copy;
    public Master SpawnMaster(Master prototype)
    {
        m_Copy = prototype.Copy();
        return (Master)m_Copy;
    }
}

using UnityEngine;
using Vuforia;
[System.Obsolete]
public class VirtualButtonEventHandler : MonoBehaviour, IVirtualButtonEventHandler
{


    public VirtualButtonBehaviour vb;
    public Animator animator;
    void IVirtualButtonEventHandler.OnButtonPressed(VirtualButtonBehaviour vb)
    {
        animator.SetBool("walk", true);
        Debug.Log("walk");
    }

    void IVirtualButtonEventHandler.OnButtonReleased(VirtualButtonBehaviour vb)
    {
        animator.SetBool("walk", false);
        Debug.Log("stop");
    }

    // Start is called before the first frame update
    void Start()
    {
        VirtualButtonBehaviour vbb = vb.GetComponent<VirtualButtonBehaviour>();
        if (vbb)
        {
            vbb.RegisterEventHandler(this);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

}
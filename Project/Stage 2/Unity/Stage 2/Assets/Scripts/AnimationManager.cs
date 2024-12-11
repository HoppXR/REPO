using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    private static readonly int Play = Animator.StringToHash("Play");
    [SerializeField] private Animator cameraAnimator;
    [SerializeField] private Animator characterAnimator;
    [SerializeField] private Animator canvasAnimator;
    
    [SerializeField] private Animator playButtonAnimator;
    [SerializeField] private Animator optionsButtonAnimator;
    [SerializeField] private Animator quitButtonAnimator;
    
    public void TriggerCameraAnimation()
    {
        cameraAnimator.SetTrigger(Play);
    }

    public void TriggerCharacterAnimation()
    {
        characterAnimator.SetTrigger(Play);
    }

    public void TriggerFadeOut()
    {
        canvasAnimator.SetTrigger(Play);
    }

    public void DisableUI()
    {
        playButtonAnimator.SetTrigger(Play);
        optionsButtonAnimator.SetTrigger(Play);
        quitButtonAnimator.SetTrigger(Play);
    }
}

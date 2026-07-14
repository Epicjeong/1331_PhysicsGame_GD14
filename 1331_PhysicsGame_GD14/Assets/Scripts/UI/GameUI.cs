using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// In game HUD shown when not paused
/// </summary>
public class GameUI : MenuBase
{
    public override GameMenus MenuType()
    {
        return GameMenus.InGameUI;
    }

    private void OnEnable()
    {
        if (PlayerMgr.Instance == null)
        {
            Debug.LogError("GameUI: Player manager == null");
            return;
        }
        if (PlayerMgr.Instance.HasSpawnedPlayer)
        {
            return;
        }
    }

    private void OnDisable()
    {
        if (PlayerMgr.Instance != null)
        {

        }
    }
}

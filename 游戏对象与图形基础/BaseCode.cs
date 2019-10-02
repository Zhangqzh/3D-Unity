using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum State { WIN, LOSE, PAUSE, START };
//新加的
public enum SSActionEventType : int { Started, Completed }
public class SSDirector : System.Object
{
    public State state = State.PAUSE;
    public int totalSeconds = 100;
    public int leaveSeconds;
    public string countDownTitle = "Start";
    private static SSDirector _instance;
    public SceneController currentSceneController { get; set; }

    public static SSDirector getInstance()
    {
        if (_instance == null)
        {
            _instance = new SSDirector();
        }
        return _instance;
    }
    public int getFPS()
    {
        return Application.targetFrameRate;
    }
    public void setFPS(int fps)
    {
        Application.targetFrameRate = fps;
    }
    public IEnumerator CountDown()
    {
        while (leaveSeconds > 0)
        {
            yield return new WaitForSeconds(1f);
            leaveSeconds--;
        }
    }
}

public interface SceneController
{
    void loadResources();
    void pause();
    void resume();
}

public interface IUserAction
{
    void moveBoat();
    void characterIsClicked(MyCharacterController characterCtrl);
    void restart();
}
//新加的
public interface ISSActionCallback
{
    void SSActionEvent(SSAction source, SSActionEventType events = SSActionEventType.Completed,
        int intParam = 0, string strParam = null, object objectParam = null);
}
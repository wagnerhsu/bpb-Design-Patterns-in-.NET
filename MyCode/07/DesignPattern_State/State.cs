namespace DesignPattern_State;

public class State
{
    internal AudioPlayer _player;

    public State(AudioPlayer player)
    {
        _player = player;
    }

    public virtual void ClickSwitch() { }

    public virtual void ClickPlay() { }

    public virtual void ClickNext() { }

    public virtual void ClickPrevious() { }
}

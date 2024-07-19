namespace DesignPattern_State;

public class PlayingState : State
{
    public PlayingState(AudioPlayer player)
        : base(player) { }

    public override void ClickSwitch()
    {
        Console.WriteLine("Switching device off");
        _player.ChangeState(new OnOffState(_player));
    }

    public override void ClickPlay()
    {
        _player.Stop();
        _player.ChangeState(new ReadyState(_player));
    }

    public override void ClickNext()
    {
        _player.ForwardFor(5);
    }

    public override void ClickPrevious()
    {
        _player.BackwardFor(5);
    }
}

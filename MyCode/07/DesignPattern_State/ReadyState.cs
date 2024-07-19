namespace DesignPattern_State;

public class ReadyState : State
{
    public ReadyState(AudioPlayer player)
        : base(player) { }

    public override void ClickSwitch()
    {
        Console.WriteLine("Switching device off");
        _player.ChangeState(new OnOffState(_player));
    }

    public override void ClickPlay()
    {
        _player.Start();
        _player.ChangeState(new PlayingState(_player));
    }

    public override void ClickNext()
    {
        _player.Next();
    }

    public override void ClickPrevious()
    {
        _player.Previous();
    }
}

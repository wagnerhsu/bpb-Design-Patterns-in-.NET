namespace DesignPattern_State;

public class OnOffState : State
{
    public OnOffState(AudioPlayer player)
        : base(player) { }

    public override void ClickSwitch()
    {
        Console.WriteLine("Switching device ON");
        _player.ChangeState(new ReadyState(_player));
    }
}

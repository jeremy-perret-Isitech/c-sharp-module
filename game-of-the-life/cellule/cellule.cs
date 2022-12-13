
public class Cellule {
    public Cellule ()
    {
        this.state = StateStatusKey.dead;
    }
    private StateStatusKey state = StateStatusKey.dead;
    public string getState() { return toStateStatus(this.state); }
    public void toggleState() { this.state = this.state == StateStatusKey.alive ? StateStatusKey.dead : StateStatusKey.alive; }

    private string toStateStatus(StateStatusKey stateStatusKey) {
        switch( stateStatusKey)
        {
            case StateStatusKey.alive:
                return "alive";
            case StateStatusKey.dead:
                return "dead";
            default:
                throw new Exception("The StateStatusKey received is invalid");
        }
    }
}

public enum StateStatusKey { alive, dead };

public class Cellule {
    public Cellule ()
    {
        this.state = StateStatusKey.dead;
    }
    private StateStatusKey state = StateStatusKey.dead;
    public string getState() { return toStateStatus(this.state); }

    public void setState(string stateStatusKey) { this.state = toState(stateStatusKey); }
    public void toggleState() { this.state = this.state == StateStatusKey.alive ? StateStatusKey.dead : StateStatusKey.alive; }

    private string toStateStatus(StateStatusKey stateStatusKey) {
        switch(stateStatusKey)
        {
            case StateStatusKey.alive:
                return "alive";
            case StateStatusKey.dead:
                return "dead";
            default:
                throw new Exception("The StateStatusKey received is invalid");
        }
    }

    private StateStatusKey toState(string stateStatus) {
        switch(stateStatus)
        {
            case "alive":
                return StateStatusKey.alive;
            case "dead":
                return StateStatusKey.dead;
            default:
                throw new Exception("The StateStatus received is invalid");
        }
    }
}

public enum StateStatusKey { alive, dead };